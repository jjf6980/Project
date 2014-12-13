using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;

namespace Csharp_MecialSearch
{
    public partial class Form2 : Form
    {
        private string url = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/";
        private int orgID;
        public Form2(int id)
        {
            orgID = id;
            InitializeComponent();
            populateGen(id);

            
            


        }

        private void populateGen(int id)
        {
            
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url + id+ @"/General");
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(res.GetResponseStream());

            XmlNodeList elemList = xmldoc.GetElementsByTagName("data");
            for (int i = 0; i < elemList.Count; i++)
            {

                string[] arr = new string[6];
                arr[0] = elemList[i].SelectSingleNode("name").InnerText;
                arr[1] = elemList[i].SelectSingleNode("email").InnerText;
                arr[2] = elemList[i].SelectSingleNode("website").InnerText;
                arr[3] = elemList[i].SelectSingleNode("description").InnerText;
                arr[4] = elemList[i].SelectSingleNode("nummembers").InnerText;
                arr[5] = elemList[i].SelectSingleNode("numcalls").InnerText;




                genNameBox.Text=(arr[0]);
                genEmailBox.Text = (arr[1]);
                genWebBox.Text = (arr[2]);
                genDescBox.Text = (arr[3]);
                genNumMemBox.Text = (arr[4]);
                genNumCallsBox.Text = (arr[5]);
                


            }
        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            if (tabControl1.SelectedTab == tabControl1.TabPages["location"])
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url + orgID + @"/Locations");
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(res.GetResponseStream());

                XmlNodeList elemList = xmldoc.GetElementsByTagName("location");
                for (int i = 0; i < elemList.Count; i++)
                {
                    string[] arr = new string[1];
                    arr[0] = elemList[i].SelectSingleNode("type").InnerText;

                    locationBox.Items.Add(arr[0]);
                }
                locationBox.SelectedIndex = 0;


                int dumb = locationBox.SelectedIndex;
                // MessageBox.Show(" " + dumb);


                 req = (HttpWebRequest)WebRequest.Create(url + orgID + @"/Locations");
                 res = (HttpWebResponse)req.GetResponse();
                 xmldoc = new XmlDocument();
                xmldoc.Load(res.GetResponseStream());

                XmlNode locList = xmldoc.GetElementsByTagName("location")[dumb];
                for (int i = 0; i < locList.ChildNodes.Count; i++)
                {
                    string[] arr = new string[10];
                    arr[0] = locList.SelectSingleNode("address1").InnerText;
                    arr[0] = locList.SelectSingleNode("address1").InnerText;
                    arr[1] = locList.SelectSingleNode("address2").InnerText;
                    arr[2] = locList.SelectSingleNode("city").InnerText;
                    arr[3] = locList.SelectSingleNode("state").InnerText;
                    arr[4] = locList.SelectSingleNode("zip").InnerText;
                    arr[5] = locList.SelectSingleNode("phone").InnerText;
                    if (locList.SelectSingleNode("ttyphone") == null)
                    {
                        if (locList.SelectSingleNode("fax") == null)
                        {
                            if (locList.SelectSingleNode("latitude") == null)
                            {
                                if (locList.SelectSingleNode("longitude") == null)
                                {
                                    break;
                                }

                            }
                            arr[8] = locList.SelectSingleNode("latitude").InnerText;
                            arr[9] = locList.SelectSingleNode("longitude").InnerText;
                        }
                        else
                        {
                            arr[7] = locList.SelectSingleNode("fax").InnerText;
                            if (locList.SelectSingleNode("latitude") == null)
                            {
                                if (locList.SelectSingleNode("longitude") == null)
                                {
                                    break;
                                }

                            }
                            else
                            {
                                arr[8] = locList.SelectSingleNode("latitude").InnerText;
                                if (locList.SelectSingleNode("longitude") == null)
                                {
                                    locAddress2Change.Text = (arr[1]);
                                    locAddress1Change.Text = (arr[0]);
                                    locCityChange.Text = (arr[2]);
                                    locStateChange.Text = (arr[3]);
                                    locZipChange.Text = (arr[4]);
                                    locPhoneChange.Text = (arr[5]);
                                }
                                else
                                {
                                    arr[9] = locList.SelectSingleNode("longitude").InnerText;
                                }
                            }

                            //arr[9] = locList[i].SelectSingleNode("longitutde").InnerText;
                        }

                    }
                    else
                    {
                        arr[6] = locList.SelectSingleNode("ttyphone").InnerText;
                        arr[7] = locList.SelectSingleNode("fax").InnerText;
                        arr[8] = locList.SelectSingleNode("latitude").InnerText;
                        arr[9] = locList.SelectSingleNode("longitutde").InnerText;
                    }
                    locAddress2Change.Text = (arr[1]);
                    locAddress1Change.Text = (arr[0]);
                    locCityChange.Text = (arr[2]);
                    locStateChange.Text = (arr[3]);
                    locZipChange.Text = (arr[4]);
                    locPhoneChange.Text = (arr[5]);
                    locTTYChange.Text = (arr[6]);
                    locFaxChange.Text = (arr[7]);
                    locLatChange.Text = (arr[8]);
                    locLongChange.Text = (arr[9]);


                }

                
                
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["treatment"])
            {
                XmlReader xmlFile = XmlReader.Create(url + orgID + @"/Treatments");
                DataSet dataSet = new DataSet();
                //MessageBox.Show(url+"Organizations?type="+orgType+@"&town="+@"&state="+state+@"&zip="+zip+@"&county="+county);
                //read the xml into dataset
                dataSet.ReadXml(xmlFile);

                //Pass row table to dataGrid the datasource
                treatGrid.DataSource = dataSet.Tables["treatment"];

                treatGrid.Columns[0].Visible = false;
                // OR
                //dataGridView1.Columns["OrganizationID"].Visible = false;


                xmlFile.Close();
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["training"])
            {
                XmlReader xmlFile = XmlReader.Create(url + orgID + @"/Training");
                DataSet dataSet = new DataSet();
                //MessageBox.Show(url+"Organizations?type="+orgType+@"&town="+@"&state="+state+@"&zip="+zip+@"&county="+county);
                //read the xml into dataset
                dataSet.ReadXml(xmlFile);

                //Pass row table to dataGrid the datasource
                trainGrid.DataSource = dataSet.Tables["training"];

                trainGrid.Columns[0].Visible = false;
                // OR
                //dataGridView1.Columns["OrganizationID"].Visible = false;


                xmlFile.Close();
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["facilities"])
            {
                XmlReader xmlFile = XmlReader.Create(url + orgID + @"/Facilities");
                DataSet dataSet = new DataSet();
                //MessageBox.Show(url+"Organizations?type="+orgType+@"&town="+@"&state="+state+@"&zip="+zip+@"&county="+county);
                //read the xml into dataset
                dataSet.ReadXml(xmlFile);

                //Pass row table to dataGrid the datasource
                facGrid.DataSource = dataSet.Tables["facility"];

                facGrid.Columns[0].Visible = false;
                // OR
                //dataGridView1.Columns["OrganizationID"].Visible = false;


                xmlFile.Close();
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["equipment"])
            {
                try
                {
                    XmlReader xmlFile = XmlReader.Create(url + orgID + @"/Equipment");
                    DataSet dataSet = new DataSet();
                    //MessageBox.Show(url+"Organizations?type="+orgType+@"&town="+@"&state="+state+@"&zip="+zip+@"&county="+county);
                    //read the xml into dataset
                    dataSet.ReadXml(xmlFile);

                    //Pass row table to dataGrid the datasource
                    equipGrid.DataSource = dataSet.Tables["equipment"];

                    equipGrid.Columns[0].Visible = false;
                    // OR
                    //dataGridView1.Columns["OrganizationID"].Visible = false;
                    xmlFile.Close();
                }
                catch (ArgumentOutOfRangeException are)
                {
                    MessageBox.Show("No Results Found");
                }
               
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["physician"])
            {
                XmlReader xmlFile = XmlReader.Create(url + orgID + @"/Physicians");
                DataSet dataSet = new DataSet();
                //MessageBox.Show(url+"Organizations?type="+orgType+@"&town="+@"&state="+state+@"&zip="+zip+@"&county="+county);
                //read the xml into dataset
                dataSet.ReadXml(xmlFile);

                //Pass row table to dataGrid the datasource
                phyGrid.DataSource = dataSet.Tables["physician"];

                phyGrid.Columns[0].Visible = false;
                // OR
                //dataGridView1.Columns["OrganizationID"].Visible = false;


                xmlFile.Close();
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["people"])
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url + orgID + @"/Locations");
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(res.GetResponseStream());
                XmlNodeList elemList = xmldoc.GetElementsByTagName("location");
                for (int i = 0; i < elemList.Count; i++)
                {
                    string[] arr = new string[1];
                    arr[0] = elemList[i].SelectSingleNode("address1").InnerText;

                    addressBox.Items.Add(arr[0]);
                }
                addressBox.SelectedIndex = 0;
            }
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url + orgID + @"/Locations");
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                XmlDocument xmldoc = new XmlDocument();
                XmlReader xmlFile = XmlReader.Create(url + orgID + @"/People");
                DataSet dataSet = new DataSet();
                
                //MessageBox.Show(url+"Organizations?type="+orgType+@"&town="+@"&state="+state+@"&zip="+zip+@"&county="+county);
                //read the xml into dataset
                dataSet.ReadXml(xmlFile);



                    //Pass row table to dataGrid the datasource
                peopleGrid.DataSource = dataSet.Tables["person"];

                        peopleGrid.Columns[0].Visible = false;
                // OR
                //dataGridView1.Columns["OrganizationID"].Visible = false;


                xmlFile.Close();
            }

        }

        private void locationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
   
            int dumb = locationBox.SelectedIndex;
           // MessageBox.Show(" " + dumb);

            
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url + orgID + @"/Locations");
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(res.GetResponseStream());

                XmlNode locList = xmldoc.GetElementsByTagName("location")[dumb];
                for (int i = 0; i < locList.ChildNodes.Count; i++)
                {
                    string[] arr = new string[10];
                    arr[0] = locList.SelectSingleNode("address1").InnerText;
                    arr[0] = locList.SelectSingleNode("address1").InnerText;
                    arr[1] = locList.SelectSingleNode("address2").InnerText;
                    arr[2] = locList.SelectSingleNode("city").InnerText;
                    arr[3] = locList.SelectSingleNode("state").InnerText;
                    arr[4] = locList.SelectSingleNode("zip").InnerText;
                    arr[5] = locList.SelectSingleNode("phone").InnerText;
                    if (locList.SelectSingleNode("ttyphone") == null)
                    {
                        if (locList.SelectSingleNode("fax") == null)
                        {
                            if (locList.SelectSingleNode("latitude") == null)
                            {
                                if (locList.SelectSingleNode("longitude") == null)
                                {
                                    break;
                                }

                            }
                            arr[8] = locList.SelectSingleNode("latitude").InnerText;
                            arr[9] = locList.SelectSingleNode("longitude").InnerText;
                        }
                        else
                        {
                            arr[7] = locList.SelectSingleNode("fax").InnerText;
                            if (locList.SelectSingleNode("latitude") == null)
                            {
                                if (locList.SelectSingleNode("longitude") == null)
                                {
                                    break;
                                }

                            }
                            else
                            {
                                arr[8] = locList.SelectSingleNode("latitude").InnerText;
                                if (locList.SelectSingleNode("longitude") == null)
                                {
                                    locAddress2Change.Text = (arr[1]);
                                    locAddress1Change.Text = (arr[0]);
                                    locCityChange.Text = (arr[2]);
                                    locStateChange.Text = (arr[3]);
                                    locZipChange.Text = (arr[4]);
                                    locPhoneChange.Text = (arr[5]);
                                }
                                else
                                {
                                    arr[9] = locList.SelectSingleNode("longitude").InnerText;
                                }
                            }
                                
                            //arr[9] = locList[i].SelectSingleNode("longitutde").InnerText;
                        }

                    }
                    else
                    {
                        arr[6] = locList.SelectSingleNode("ttyphone").InnerText;
                        arr[7] = locList.SelectSingleNode("fax").InnerText;
                        arr[8] = locList.SelectSingleNode("latitude").InnerText;
                        arr[9] = locList.SelectSingleNode("longitutde").InnerText;
                    }
                    locAddress2Change.Text = (arr[1]);
                    locAddress1Change.Text = (arr[0]);
                    locCityChange.Text = (arr[2]);
                    locStateChange.Text = (arr[3]);
                    locZipChange.Text = (arr[4]);
                    locPhoneChange.Text = (arr[5]);
                    locTTYChange.Text = (arr[6]);
                    locFaxChange.Text = (arr[7]);
                    locLatChange.Text = (arr[8]);
                    locLongChange.Text = (arr[9]);


               }

                
           
        }
            
        }

    }

