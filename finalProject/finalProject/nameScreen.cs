using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    public partial class nameScreen : UserControl
    {
        public static string studioName;

        public nameScreen()
        {
            InitializeComponent();
            nameBox.Text = "Enter Studio Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (nameBox.Text == "" || nameBox.Text == "Enter Studio Name")
            {
                MessageBox.Show("Nothing there dawg.", "No Name");
            }

            else
            {
                string nameText = nameBox.Text;
                studioName = nameBox.Text;
                Form f = this.FindForm();
                f.Controls.Remove(this);
                gameScreen gs = new gameScreen();
                f.Controls.Add(gs);
                gs.Location = new Point(0, 0);
            }      
    }

        private void nameBox_MouseClick(object sender, MouseEventArgs e)
        {
            nameBox.Text = "";
        }

        private void nameScreen_MouseClick(object sender, MouseEventArgs e)
        {
            if (nameBox.Text == "")
            {
                nameBox.Text = "Enter Studio Name";
            }
        }
    }
}
