using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ImporterApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string xmlFilePath = @"databaseConfig.xml";
            XmlDocument xmlDocument = new XmlDocument();    
            xmlDocument.Load(xmlFilePath);

            LoginBaseTextBox.Text = xmlDocument.SelectSingleNode("/databaseConfig/login").InnerText;
            PasswordBaseTextBox.Text = xmlDocument.SelectSingleNode("/databaseConfig/password").InnerText;
            NameBaseTextBox.Text = xmlDocument.SelectSingleNode("/databaseConfig/instanceName").InnerText;
            CatalogBaseTextBox.Text = xmlDocument.SelectSingleNode("/databaseConfig/catalogName").InnerText;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GoImportButton_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void GoImportButton_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void GoImportButton_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();

        }

        private void NameBaseTextBox_TextChanged(object sender, EventArgs e)
        {

            string xmlFilePath = @"databaseConfig.xml";
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlFilePath);
            XmlNode nameNode = xmlDocument.SelectSingleNode("/databaseConfig/instanceName");
            if (nameNode != null)
            {
                nameNode.InnerText = NameBaseTextBox.Text;
            }

            // Zapisz zmieniony dokument do pliku XML
            xmlDocument.Save(xmlFilePath);
        }

        private void LoginBaseTextBox_TextChanged(object sender, EventArgs e)
        {

            string xmlFilePath = @"databaseConfig.xml";
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlFilePath);
            XmlNode loginNode = xmlDocument.SelectSingleNode("/databaseConfig/login");
            if (loginNode != null)
            {
                loginNode.InnerText = LoginBaseTextBox.Text;
            }

            // Zapisz zmieniony dokument do pliku XML
            xmlDocument.Save(xmlFilePath);
        }

        private void PasswordBaseTextBox_TextChanged(object sender, EventArgs e)
        {
            string xmlFilePath = @"databaseConfig.xml";
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlFilePath);
            XmlNode passwordNode = xmlDocument.SelectSingleNode("/databaseConfig/password");
            if (passwordNode != null)
            {
                passwordNode.InnerText = PasswordBaseTextBox.Text;
            }

            // Zapisz zmieniony dokument do pliku XML
            xmlDocument.Save(xmlFilePath);
        }

        private void CatalogTextBox_TextChanged(object sender, EventArgs e)
        {
            string xmlFilePath = @"databaseConfig.xml";
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlFilePath);
            XmlNode catalogNode = xmlDocument.SelectSingleNode("/databaseConfig/catalogName");
            if (catalogNode != null)
            {
                catalogNode.InnerText = CatalogBaseTextBox.Text;
            }

            // Zapisz zmieniony dokument do pliku XML
            xmlDocument.Save(xmlFilePath);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
