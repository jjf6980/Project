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
            //textBoxZipCode.Text = "";
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            //string orgtype = comboBox1; 

                string orgType = comboBox1.SelectedItem.ToString();
                string orgName = textBoxOrgName.Text;
                string state = comboBoxState.SelectedItem.ToString();
                //MessageBox.Show(orgType);
                string zip = zipBox.SelectedItem.ToString();
                string county = countyBox.SelectedItem.ToString();

                /*XmlReader xmlFile = XmlReader.Create(@"data.xml");
                DataSet dataSet = new DataSet();
                */
                XmlReader xmlFile = XmlReader.Create(url+"Organizations?type="+orgType+@"&name="+orgName+@"&town="+@"&state="+state+@"&zip="+zip+@"&county="+county);
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



            //XmlNodeList elemList = xmldoc.GetElementsByTagName("facility");

        }

        private void getOrgtypes()
        {
            // XmlReader xmlFile = XmlReader.Create(path + "getOrgtypes");
            // DataSet dataSet = new DataSet();

            //read the xml into dataset
            comboBox1.Items.Add("");
            comboBox1.SelectedIndex = 0;
            zipBox.Items.Add("");
            zipBox.SelectedIndex = 0;
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
            MessageBox.Show(countything);
            req = (HttpWebRequest)WebRequest.Create(countything);
            res = (HttpWebResponse)req.GetResponse();
            XmlDocument xmldoc2 = new XmlDocument();
            xmldoc2.Load(res.GetResponseStream());

            XmlNodeList countyList = xmldoc2.GetElementsByTagName("row");
            for (int i = 0; i < countyList.Count; i++)
            {

                string[] arr = new string[1];
                arr[0] = countyList[i].SelectSingleNode("CountyName").InnerText;




                countyBox.Items.Add(arr[0]);

            }


        }
    }
}
