using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TravelExtravaganza
{
    public partial class frmCruiseBuilder : Form
    {

        public frmCruiseBuilder()
        {
            InitializeComponent();
        }

        private void frmCruiseBuilder_Load(object sender, EventArgs e)
        {
            //put the service check boxes in a list for use later
            List<CheckBox> services = new List<CheckBox>()
        {chkService1, chkService2, chkService3, chkService4, chkService5, chkService6};

            //put tag from splash form into string variable for use with SetCruiseControls();
            string cruiseLocation = (string)Application.OpenForms["frmSplash"].Tag;
            SetCruiseControls(cruiseLocation, services);
        }


        //selectedindex of the combo box

        decimal cruiseBasePrice;
        decimal[] prices = new decimal[7];


        //List<string> caribbeanServices = new List<string>()
        //{ "Snorkeling", "stuff", "party", "random stuff", "fun times", "yep"};

        //we can just put the names in the switch statement?
        //or could declare them here and reference them in the switch statement...


        private void SetCruiseControls(string cruise, List<CheckBox> services)
        {
            switch (cruise)
            {
                case "Caribbean":
                    {
                        //so this is an example array that holds prices (currently empty)
                        //first price will be the base price of the cruise
                        //and subsequent prices will be prices of services

                        prices[0] = 828.96m;
                        prices[1] = 182m;
                        prices[2] = 150m;
                        prices[3] = 200m;
                        prices[4] = 80m;
                        prices[5] = 112m;
                        prices[6] = 114m;


                        //determine text properties for form
                        this.Text = "Caribbean";

                        int i = 0;
                        //assigns correct Text and prices for each service

                        foreach (CheckBox service in services)
                        {
                            services[i].Text = "text"; //this will actually be i of a string array/list
                            services[i].Tag = prices[i + 1]; //add 1 to index to account for index 0 being the base price
                            i++;    
                        }
                        
                        //assigns base price of cruise
                        cruiseBasePrice = prices[0];

                        break;
                    }
                case "Norway":
                    {
                        //determine text properties for form and controls
                        this.Text = "Norway";

                        prices[0] = 2380.7m;
                        prices[1] = 200m;
                        prices[2] = 100m;
                        prices[3] = 119m;
                        prices[4] = 250m;
                        prices[5] = 300m;
                        prices[6] = 200m;


                        cruiseBasePrice = 2m;
                        break;
                    }
                case "Lake Minnetonka":
                    {
                        //determine text properties for form and controls
                        this.Text = "Lake Minnetonka";

                        prices[0] = 45m;
                        prices[1] = 10m;
                        prices[2] = 8m;
                        prices[3] = 5m;
                        prices[4] = 6m;
                        prices[5] = 7m;
                        prices[6] = 9m;


                        cruiseBasePrice = 3m;
                        break;
                    }
                default:
                    break;
            }

        }

        private void chkService_CheckedChanged(object sender, EventArgs e)
        {
            //check box functionality
            var SenderObject = (CheckBox)sender;
            string activity = SenderObject.Text;
            decimal activityPrice = (decimal)SenderObject.Tag;

            if (SenderObject.Checked)
            {
                lstQuotes.Items.Add(activity);
                cruiseBasePrice += activityPrice;
                lblTotalPrice.Text = cruiseBasePrice.ToString();
                //int index = prices.IndexOf(25);
                //PictureBox.Show();
            }
            if (!SenderObject.Checked)
            {
                lstQuotes.Items.Remove(activity);
                cruiseBasePrice -= activityPrice;
                lblTotalPrice.Text = cruiseBasePrice.ToString();

            }
        }

        //TO DO: 
        //includes populating list box with services & their prices

        //TO DO: calculation method to get the total

        //TO DO: Data validation? Exception handling.
    }
}
