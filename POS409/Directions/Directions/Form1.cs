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
using Microsoft.VisualBasic;
using System.Threading;

namespace Directions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetDirections_MouseClick(object sender, MouseEventArgs e)
        {
            Navigator letsGo = new Navigator();

            letsGo.SetCurrentLocation(txtFrom.Text);

            letsGo.SetDestination(txtTo.Text);

            string route;

            route = letsGo.GetDirections();

            txtDirections.Text = route;
        }

        List<tempNav> Navigation = new List<tempNav>(); 

        private void btnGetDirections_Click(object sender, EventArgs e)
        {

            string[] nav;

            if (File.Exists("..\\directionsdata.txt"))
            {
                TextFieldParser parser = new TextFieldParser("..\\directionsdata.txt");

                parser.Delimiters = new string[] { "," };
                int trnCnt = 0;
                int prtCnt = 0;
                while(true)
                {

                    nav = parser.ReadFields();
                    if(nav == null)
                    {
                        break;
                    }

                    Navigation[trnCnt].startPoint = nav[prtCnt];
                    Navigation[trnCnt].endPoint = nav[prtCnt + 1];
                    Navigation[trnCnt].directionOne = nav[prtCnt + 2];
                    Navigation[trnCnt].directionTwo = nav[prtCnt + 3];
                    Navigation[trnCnt].directionThree = nav[prtCnt + 4];
                    Navigation[trnCnt].directionFour = nav[prtCnt + 5];
                    Navigation[trnCnt].arrivalMsg = nav[prtCnt + 6];

                    trnCnt++;

                }
                

                foreach (tempNav NavPoint in Navigation)
                {
                    txtFrom.Text = NavPoint.startPoint;
                    txtFrom.Text = NavPoint.endPoint;
                    txtDirections.Text = NavPoint.directionOne + " ; " + NavPoint.directionTwo + " ; " + NavPoint.directionThree + " ; " + 
                        NavPoint.directionFour + " You Have Arrived! "  + NavPoint.arrivalMsg;
                        
                }

                
            }
            else
            {
                txtFrom.Text = "File Unavailable";
            }

        }
    }
}
