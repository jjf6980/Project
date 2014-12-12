using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Csharp_MecialSearch
{
    public partial class Form1 : Form
    {
        string url = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/";
        public Form1()
        {
            InitializeComponent();
            getOrgtypes();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxOrgName.Text = "";
            townBox.SelectedIndex = 0;
            zipBox.Text = "";
            comboBoxState.SelectedIndex = 33;
            comboBox1.SelectedIndex = 0;
            countyBox.SelectedIndex = 0;
            
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            //string orgtype = comboBox1; 
            try
            {
                string orgType = comboBox1.SelectedItem.ToString();
                string orgName = textBoxOrgName.Text;
                string state = comboBoxState.SelectedItem.ToString();
                //MessageBox.Show(orgType);
                string zip = zipBox.Text;
                string county = countyBox.SelectedItem.ToString();

                /*XmlReader xmlFile = XmlReader.Create(@"data.xml");
                DataSet dataSet = new DataSet();
                */
                XmlReader xmlFile = XmlReader.Create(url + "Organizations?type=" + orgType + @"&name=" + orgName + @"&town=" + @"&state=" + state + @"&zip=" + zip + @"&county=" + county);
                DataSet dataSet = new DataSet();
                //MessageBox.Show(url+"Organizations?type="+orgType+@"&town="+@"&state="+state+@"&zip="+zip+@"&county="+county);
                //read the xml into dataset
                dataSet.ReadXml(xmlFile);

                //Pass row table to dataGrid the datasource
                dataGridView1.DataSource = dataSet.Tables["row"];

                dataGridView1.Columns[0].Visible = false;
                // OR
                //dataGridView1.Columns["OrganizationID"].Visible = false;


                xmlFile.Close();
            }
            catch(NullReferenceException){
                MessageBox.Show("No Results Match That Search Criteria");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No Results Match That Search Criteria");
            }


            //XmlNodeList elemList = xmldoc.GetElementsByTagName("facility");

        }

        private void getOrgtypes()
        {
            // XmlReader xmlFile = XmlReader.Create(path + "getOrgtypes");
            // DataSet dataSet = new DataSet();

            //read the xml into dataset
            comboBox1.Items.Add("");
            comboBox1.SelectedIndex = 0;
            countyBox.Items.Add("");
            countyBox.SelectedIndex = 0;
            townBox.Items.Add("");
            townBox.SelectedIndex = 0;
            comboBoxState.SelectedIndex = 33;
            string state = comboBoxState.SelectedItem.ToString();

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url + "OrgTypes" );
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(res.GetResponseStream());

            XmlNodeList elemList = xmldoc.GetElementsByTagName("row");
            for (int i = 0; i < elemList.Count; i++)
            {

                string[] arr = new string[1];
                arr[0] = elemList[i].SelectSingleNode("type").InnerText;




                comboBox1.Items.Add(arr[0]);

            }
            
            string countything = url + "Counties?state=" + state;
            //MessageBox.Show(countything);
            req = (HttpWebRequest)WebRequest.Create(countything);
            res = (HttpWebResponse)req.GetResponse();
            xmldoc = new XmlDocument();
            xmldoc.Load(res.GetResponseStream());

            XmlNodeList countyList = xmldoc.GetElementsByTagName("row");
            for (int i = 0; i < countyList.Count; i++)
            {

                string[] arr = new string[1];
                arr[0] = countyList[i].SelectSingleNode("CountyName").InnerText;




                countyBox.Items.Add(arr[0]);

            }
            string towns = url + "Cities?state=" + state;
            //MessageBox.Show(countything);
            req = (HttpWebRequest)WebRequest.Create(towns);
            res = (HttpWebResponse)req.GetResponse();
            xmldoc = new XmlDocument();
            xmldoc.Load(res.GetResponseStream());

            XmlNodeList townList = xmldoc.GetElementsByTagName("row");
            for (int i = 0; i < townList.Count; i++)
            {

                string[] arr = new string[1];
                arr[0] = townList[i].SelectSingleNode("city").InnerText;




                townBox.Items.Add(arr[0]);

            }
        }

        private void comboBoxState_SelectionChangeCommitted(object sender, EventArgs e)
        {
            countyBox.Items.Clear();
            countyBox.Items.Add("");
            countyBox.SelectedIndex = 0;
            string state = comboBoxState.SelectedItem.ToString();
            string countything = url + "Counties?state=" + state;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(countything);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(res.GetResponseStream());

            XmlNodeList countyList = xmldoc.GetElementsByTagName("row");
            for (int i = 0; i < countyList.Count; i++)
            {

                string[] arr = new string[1];
                arr[0] = countyList[i].SelectSingleNode("CountyName").InnerText;




                countyBox.Items.Add(arr[0]);

            }
            townBox.Items.Clear();
            townBox.Items.Add("");
            townBox.SelectedIndex = 0;
            string towns = url + "Cities?state=" + state;
            //MessageBox.Show(countything);
            req = (HttpWebRequest)WebRequest.Create(towns);
            res = (HttpWebResponse)req.GetResponse();
            xmldoc = new XmlDocument();
            xmldoc.Load(res.GetResponseStream());

            XmlNodeList townList = xmldoc.GetElementsByTagName("row");
            for (int i = 0; i < townList.Count; i++)
            {

                string[] arr = new string[1];
                arr[0] = townList[i].SelectSingleNode("city").InnerText;




                townBox.Items.Add(arr[0]);

            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Physician")
            {
                label2.Text = "Physician name";
            }
            else
            {
                label2.Text = "Organization Name";
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show("Clicked");
            // which one am I clicking
            int col = e.ColumnIndex;
            int row = e.RowIndex;

            int orgId = Convert.ToInt32(dataGridView1[0, row].Value);

            string tabs = "getTabs?orgId" + orgId;
            MessageBox.Show(tabs);

            string criteria = orgId + "/general";
            MessageBox.Show(criteria);
        }
    }
}
