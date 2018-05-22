using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            string route;

            route = letsGo.GetDirections();
        }
    }
}
