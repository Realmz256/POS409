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

namespace Directions
{
    public partial class Form1 : Form
    {
        List<Navigator> directions = new List<Navigator>();
        public Form1()
        {
            InitializeComponent();
            populateData();
        }

        private void btnGetDirections_MouseClick(object sender, MouseEventArgs e)
        {
            var query = directions.Where(o => (o.startPoint.ToString() == textFrom.Text && o.endPoint.ToString() == textTo.Text)); 
            /*
            Navigator letsGo = new Navigator();

            letsGo.SetCurrentLocation(txtFrom.Text);

            letsGo.SetDestination(txtTo.Text);*/

            string route;

            route = query.ElementAt(0).displayDirections();

            txtDirections.Text = route;
        }

        private void populateData()
        {
            using (var reader = new StreamReader(@"DataSource.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    var temp = new Navigator(values[0], values[1], values[2]);
                    directions.Add(temp);
                }
            }

        }

        public static string CleanString(string dirtyString)
        {
            dirtyString = dirtyString.Trim();
            dirtyString = dirtyString.ToLower();
            HashSet<char> removeChars = new HashSet<char>(" ?&^$#@!()+-,:;<>’\'-_*");
            StringBuilder result = new StringBuilder(dirtyString.Length);
            foreach (char c in dirtyString)
                if (!removeChars.Contains(c)) // prevent dirty chars
                    result.Append(c);
            return result.ToString();
        }
    }
}
