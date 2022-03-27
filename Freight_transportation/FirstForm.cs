using Serialization;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace Freight_transportation
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
           
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            //ChelANDgood repository;
            //MemoryStream stream = new MemoryStream(File.ReadAllBytes("XMLFile.xml"));
            //System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(ChelANDgood));
            //repository = (ChelANDgood)serializer.Deserialize(stream);
            //stream.Close();
            //int i = 1;
            ChelANDgood chelANDgood = new ChelANDgood();
            chelANDgood.Drivers = new Drivers();
            chelANDgood.
        }
    }
}
