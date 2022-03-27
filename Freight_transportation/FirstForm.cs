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
            ChelANDgood chelANDgood;
            MemoryStream stream = new MemoryStream(File.ReadAllBytes("XMLFile.xml"));
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(ChelANDgood));
            chelANDgood = (ChelANDgood)serializer.Deserialize(stream);
            stream.Close();

            foreach (Pilot pilot in chelANDgood.Pilots.PilotsArray)
            {
                dataTable.Rows.Add(new object[4] { pilot.Name_pilot, pilot.Surname_pilot, pilot.Stage_pilot, pilot.IdEdu });
            }
            foreach (Driver driver in chelANDgood.Drivers.DriversArray)
            {
                dataTable_driver.Rows.Add(new object[3] { driver.Name_driver, driver.Surname_driver, driver.Stage_driver });
            }
            foreach (Good good in chelANDgood.Goods.GoodsArray)
            {
                dataGood.Rows.Add(new object[2] { good.Name_good, good.Weight });
            }
        }

  
    }
}
