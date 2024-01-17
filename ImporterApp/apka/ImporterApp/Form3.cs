using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Xml;
using ExcelDataReader;
using System.Globalization;
using System.Net.NetworkInformation;

namespace ImporterApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Import_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void ImportButton_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FileButton_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void FileButton_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void GoBaseButton_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void GoBaseButton_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void GoBaseButton_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
        private void ImportButton_Click(object sender, EventArgs e)

        {
            string selectedFileName = FileNameTextBox.Text;

            if (!string.IsNullOrEmpty(selectedFileName))
            {
                string xmlFilePath = @"databaseConfig.xml";
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(xmlFilePath);
                string connectionString = $"Data Source={xmlDocument.SelectSingleNode("/databaseConfig/instanceName").InnerText};" +
                    $"Initial Catalog={xmlDocument.SelectSingleNode("/databaseConfig/catalogName").InnerText};" +
                    $"User ID={xmlDocument.SelectSingleNode("/databaseConfig/login").InnerText};" +
                    $"Password={xmlDocument.SelectSingleNode("/databaseConfig/password").InnerText};";

                using (SqlConnection connection = new SqlConnection(connectionString))

                try
                {
                    connection.Open();

                    // Otwórz plik xls i zaimportuj dane
                    using (var stream = System.IO.File.Open(selectedFileName, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            // Odczytaj dane z arkusza
                                DataSet result = reader.AsDataSet();

                                DataTable XLSTable = result.Tables[0];

                                string[] id_client= new string[XLSTable.Rows.Count - 1];
                                string[] id_people= new string[XLSTable.Rows.Count - 1];
                                string[] id_ticket = new string[XLSTable.Rows.Count - 1];
                                string time_spent;
                                string title;
                                DateTime created_date;
                                DateTime modified_date;
                                string id_group = "3"; // sztywno
                                string id_supporter = "19933"; // sztywno
                                string id_status = "5"; // sztywno
                                string id_type = "5"; // sztywno
                                string id_category = "2"; // sztywno
                                string id_calculate = "6"; // sztywno
                                string id_priority = "1"; // sztywno
                                string created_by = "19933"; // sztywno
                                string modified_by = "19933"; // sztywno
                                //DataTime deadline; // NULL
                                string description;
                                string id_model = "5";// sztywno
                                string serial_number = "5";// sztywno
                                string equipment = "Brak";// sztywno
                                //string active = "1";// sztywno - samo sie dodaje
                                string approved = "1";// sztywno
                                //string distance = NULL


                                // Iteruj przez wiersze w pliku xls
                                for (int i = 1; i < XLSTable.Rows.Count; i++)
                                {
                                    string xlsFirm = XLSTable.Rows[i][0].ToString();
                                    string query = "SELECT id FROM Client WHERE name = @xlsFirm";
                                   
                                    using (SqlCommand cmd = new SqlCommand(query, connection))
                                    {
                                        //cmd.Parameters.Clear();
                                        cmd.Parameters.AddWithValue("@xlsFirm", xlsFirm);
                                        object resultID = cmd.ExecuteScalar();

                                        if (resultID != null)
                                        {
                                            id_client[i-1] = resultID.ToString();
                                        }
                                        else
                                        {
                                            // Brak rekordu o podanym name w tabeli Client
                                            MessageBox.Show($"Nie znaleziono rekordu w tabeli Client o name '{xlsFirm}'.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            break;
                                        }
                                    }
                                }

                                for (int j = 1; j < XLSTable.Rows.Count; j++)
                                {
                                    string xlsName = XLSTable.Rows[j][1].ToString();
                                    string queryName = "SELECT id FROM People WHERE firstname + ' ' + surname = @xlsName";

                                    using (SqlCommand cmdName = new SqlCommand(queryName, connection))
                                    {
                                        //cmdName.Parameters.Clear();
                                        cmdName.Parameters.AddWithValue("@xlsName", xlsName);
                                        object resultIDPeople = cmdName.ExecuteScalar();

                                        if (resultIDPeople != null)
                                        {
                                            id_people[j-1] = resultIDPeople.ToString();
                                                                                    }
                                        else
                                        {
                                            MessageBox.Show($"Nie znaleziono rekordu w tabeli People o imieniu i nazwisku '{xlsName}'.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            break;
                                        }
                                    }
                                }

                                for (int j = 1; j < XLSTable.Rows.Count; j++)
                                {
                                    string xlsTask = XLSTable.Rows[j][2].ToString();
                                    description = XLSTable.Rows[j][3].ToString();
                                    time_spent = XLSTable.Rows[j][4].ToString();

                                    title = xlsTask;
                                    string queryTask = "SELECT id FROM Ticket WHERE title = @title AND id_client = @id_client"; // tutaj dopisac jeszcze ze dla takiego samego id firmy 
                                    
                                    String created_dateSTR = XLSTable.Rows[j][8].ToString();
                                    String modified_dateSTR = XLSTable.Rows[j][9].ToString();
                  
                                    string dateFormat = "yyyy-MM-ddTHH:mm:sszzz";

                                    created_date = DateTime.ParseExact(created_dateSTR, dateFormat, CultureInfo.InvariantCulture);

                                    modified_date = DateTime.ParseExact(modified_dateSTR, dateFormat, CultureInfo.InvariantCulture);

                                    using (SqlCommand cmdName = new SqlCommand(queryTask, connection))
                                    {
                                        //cmdName.Parameters.Clear();
                                        cmdName.Parameters.AddWithValue("@title", title);
                                        cmdName.Parameters.AddWithValue("@id_client", id_client[j-1]);
                                        object titleTask = cmdName.ExecuteScalar();
                                        

                                        if (titleTask != null)
                                        {
                                            id_ticket[j - 1] = titleTask.ToString();
                                            string insQuery = "INSERT INTO TicketHistory (id_ticket, id_status, modified_by, modified_date, description, time_spent)" +
                                                "VALUES (@id_ticket, @id_status, @modified_by, @modified_date, @description, @time_spent)";

                                            using (SqlCommand insertCmd = new SqlCommand(insQuery, connection))
                                            {
                                                insertCmd.Parameters.AddWithValue("@id_ticket", id_ticket[j-1]);
                                                insertCmd.Parameters.AddWithValue("@id_status", id_status);
                                                insertCmd.Parameters.AddWithValue("@modified_by", modified_by);
                                                insertCmd.Parameters.AddWithValue("@modified_date", modified_date);
                                                insertCmd.Parameters.AddWithValue("@description", description);
                                                insertCmd.Parameters.AddWithValue("@time_spent", time_spent);
                                                insertCmd.ExecuteNonQuery();
                                            }
                                        }
                                        else
                                        {
                                            
                                            string insertQuery = "INSERT INTO Ticket (id_group, id_supporter, id_client, id_people, id_status, id_type," +
                                                " id_category, id_calculate, id_priority, created_date, created_by, modified_date, modified_by, title, serial_number, equipment, approved) " +
                                                "VALUES (@id_group, @id_supporter, @id_client, @id_people, @id_status, @id_type, @id_category, @id_calculate, @id_priority," +
                                                " @created_date, @created_by, @modified_date, @modified_by, @title, @serial_number, @equipment, @approved)";

                                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                                            {
                                                insertCmd.Parameters.AddWithValue("@id_group", id_group);
                                                insertCmd.Parameters.AddWithValue("@id_supporter", id_supporter);
                                                insertCmd.Parameters.AddWithValue("@id_client", id_client[j - 1]);
                                                insertCmd.Parameters.AddWithValue("@id_people", id_people[j - 1]);
                                                insertCmd.Parameters.AddWithValue("@id_status", id_status);
                                                insertCmd.Parameters.AddWithValue("@id_type", id_type);
                                                insertCmd.Parameters.AddWithValue("@id_category", id_category);
                                                insertCmd.Parameters.AddWithValue("@id_calculate", id_calculate);
                                                insertCmd.Parameters.AddWithValue("@id_priority", id_priority);
                                                insertCmd.Parameters.AddWithValue("@created_date", created_date);
                                                insertCmd.Parameters.AddWithValue("@created_by", created_by);
                                                insertCmd.Parameters.AddWithValue("@modified_date", modified_date);
                                                insertCmd.Parameters.AddWithValue("@modified_by", modified_by);
                                                insertCmd.Parameters.AddWithValue("@title", title);
                                                //insertCmd.Parameters.AddWithValue("@id_model", id_model);
                                                insertCmd.Parameters.AddWithValue("@serial_number", serial_number);
                                                insertCmd.Parameters.AddWithValue("@equipment", equipment);
                                                insertCmd.Parameters.AddWithValue("@approved", approved);
                                                insertCmd.ExecuteNonQuery();
                                            }

                                            using (SqlCommand cmdName2 = new SqlCommand(queryTask, connection))
                                            {
                                                cmdName2.Parameters.AddWithValue("@title", title);
                                                cmdName2.Parameters.AddWithValue("@id_client", id_client[j - 1]);
                                                object titleTask2 = cmdName2.ExecuteScalar();
                                                id_ticket[j - 1] = titleTask2.ToString();
                                                string insQuery = "INSERT INTO TicketHistory (id_ticket, id_status, modified_by, modified_date, description, time_spent)" +
                                                "VALUES (@id_ticket, @id_status, @modified_by, @modified_date, @description, @time_spent)";
                                                

                                                using (SqlCommand insertCmd = new SqlCommand(insQuery, connection))
                                                {
                                                    
                                                    insertCmd.Parameters.AddWithValue("@id_ticket", id_ticket[j - 1]);
                                                    insertCmd.Parameters.AddWithValue("@id_status", id_status);
                                                    insertCmd.Parameters.AddWithValue("@modified_by", modified_by);
                                                    insertCmd.Parameters.AddWithValue("@modified_date", modified_date);
                                                    insertCmd.Parameters.AddWithValue("@description", description);
                                                    insertCmd.Parameters.AddWithValue("@time_spent", time_spent);
                                                    insertCmd.ExecuteNonQuery();
                                                }
                                            }
                                        }
                                    }
                                }
                                MessageBox.Show($"Poprawnie zimportowano plik do bazy danych!", "Sukces!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać plik przed importem.");
            }
        

        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            // Utwórz instancję OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Ustaw filtr dla plików Excela (xls i xlsx)
            openFileDialog.Filter = "Pliki Excela|*.xls;*.xlsx";

            // Wyświetl okno dialogowe do wyboru pliku
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Pobierz nazwę wybranego pliku
                string selectedFileName = openFileDialog.FileName;

                // Wyświetl nazwę pliku w TextBox
                FileNameTextBox.Text = selectedFileName;
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FileNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
