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
                        decimal[] prices = new decimal[7];

                        //determine text properties for form
                        this.Text = "Caribbean";

                        //assigns correct Text and prices for each service
                        for (int i = 0; i < services.Count; i++)
                        {
                            foreach (CheckBox service in services)
                            {
                                service.Text = "text"; //this will actually be i of a string array/list
                                service.Tag = prices[i + 1]; //add 1 to index to account for index 0 being the base price
                            }
                        }
                        
                        //assigns base price of cruise
                        cruiseBasePrice = prices[0];

                        break;
                    }
                case "Norway":
                    {
                        //determine text properties for form and controls
                        this.Text = "Norway";


                        cruiseBasePrice = 2m;
                        break;
                    }
                case "Lake Minnetonka":
                    {
                        //determine text properties for form and controls
                        this.Text = "Lake Minnetonka";


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

            if (SenderObject.Checked)
            {
                lstQuotes.Items.Add(activity);
            }
        }

        //TO DO: 
        //includes populating list box with services & their prices

        //TO DO: calculation method to get the total

        //TO DO: Data validation? Exception handling.
    }
}
