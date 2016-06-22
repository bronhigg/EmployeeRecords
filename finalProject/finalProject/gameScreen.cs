using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace finalProject
{
    public partial class gameScreen : UserControl
    {
        List<Employee> employeeDB = new List<Employee>();

        double count = 1;
        double steve = 1;
        double steveamount = 0;
        double steveprice = 100;
        double white = 0;
        double whiteamount = 0;
        double whiteprice = 1100;
        double blue = 0;
        double blueamount = 0;
        double blueprice = 12000;
        double green = 0;
        double greenamount = 0;
        double greenprice = 130000;
        double brown = 0;
        double brownamount = 0;
        double brownprice = 14000000;
        double yellow = 0;
        double yellowamount = 0;
        double yellowprice = 20000000;

        


        public gameScreen()
        {
            InitializeComponent();

            Form bg = new Form();
            bg.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            bg.BackColor = Color.Black;
            bg.FormBorderStyle = FormBorderStyle.None;
            bg.SendToBack();
            bg.Show();
            bg.SendToBack();

            studioNameLabel.Text = nameScreen.studioName + "'s Studio";
            steveRoss.Visible = false;
            whiteButton.Visible = false;
            blueButton.Visible = false;
            greenButton.Visible = false;
            brownButton.Visible = false;
            yellowButton.Visible = false;
        }

        

        private void buttonBob_Click(object sender, EventArgs e)
        {
            count = count + steve + white + blue + green + brown + yellow;
            if (buttonBob != null)
                amountOfBobsLabel.Text = count.ToString("#")+ " Bobs";
            if (count >= steveprice)
            {
                steveRoss.Visible = true;
            }
            if (count >= whiteprice)
            {
                whiteButton.Visible = true;
            }
            if (count >= blueprice) 

            {
                blueButton.Visible = true;
            }
            if (count >= greenprice)
            {
                greenButton.Visible = true;
            }
            if (count >= brownprice)
            {
                brownButton.Visible = true;
            }
            if (count >= yellowprice)
            {
                yellowButton.Visible = true;
            }
        }

        private void steveRoss_Click(object sender, EventArgs e)
        {
            steve ++;
            steveamount++;
            amountOfSteves.Text = steveamount.ToString() + " Steves";
            count = count - steveprice;
            steveprice = steveprice * 1.15;
            amountOfBobsLabel.Text = count.ToString("#") + " Bobs";
            stevePriceLabel.Text = steveprice.ToString("#");
            if (count < steveprice)
            {
                steveRoss.Visible = false;
            }
                if (count < whiteprice)
                {
                    whiteButton.Visible = false;
                }

            if (count < blueprice)
            {
                blueButton.Visible = false;
            }
            if (count < greenprice)
            {
                greenButton.Visible = false;
            }
            if (count < brownprice)
            {
                brownButton.Visible = false;
            }
            if (count < yellowprice)
            {
                yellowButton.Visible = false;
            }

            if (count >= steveprice)
            {
                steveRoss.Visible = true;
            }
            if (count >= whiteprice)
            {
                whiteButton.Visible = true;
            }
            if (count >= blueprice)
            {
                blueButton.Visible = true;
            }
            if (count >= greenprice)
            {
                greenButton.Visible = true;
            }
            if (count >= brownprice)
            {
                brownButton.Visible = true;
            }
            if (count >= yellowprice)
            {
                yellowButton.Visible = true;
            }
           
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            white = white + 5;
            whiteamount++;
            amountOfWhite.Text = whiteamount.ToString() + " White";
            count = count - whiteprice;
            whiteprice = whiteprice * 1.15;
            amountOfBobsLabel.Text = count.ToString("#") + " Bobs";
            titaniumWhiteLabel.Text = whiteprice.ToString("#");
            if (count < steveprice)
            {
                steveRoss.Visible = false;
            }
            if (count < whiteprice)
            {
                whiteButton.Visible = false;
            }

            if (count < blueprice)
            {
                blueButton.Visible = false;
            }
            if (count < greenprice)
            {
                greenButton.Visible = false;
            }
            if (count < brownprice)
            {
                brownButton.Visible = false;
            }
            if (count < yellowprice)
            {
                yellowButton.Visible = false;
            }
            if (count >= steveprice)
            {
                steveRoss.Visible = true;
            }
            if (count >= whiteprice)
            {
                whiteButton.Visible = true;
            }
            if (count >= blueprice)
            {
                blueButton.Visible = true;
            }
            if (count >= greenprice)
            {
                greenButton.Visible = true;
            }
            if (count >= brownprice)
            {
                brownButton.Visible = true;
            }
            if (count >= yellowprice)
            {
                yellowButton.Visible = true;
            }

        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            blue = blue + 10;
            blueamount++;
            amountOfBlue.Text = blueamount.ToString() + " Blue";
            count = count - blueprice;
            blueprice = blueprice * 1.15;
            amountOfBobsLabel.Text = count.ToString("#") + " Bobs";
            phthaloBlueLabel.Text = blueprice.ToString("#");
            if (count < steveprice)
            {
                steveRoss.Visible = false;
            }
            if (count < whiteprice)
            {
                whiteButton.Visible = false;
            }

            if (count < blueprice)
            {
                blueButton.Visible = false;
            }
            if (count < greenprice)
            {
                greenButton.Visible = false;
            }
            if (count < brownprice)
            {
                brownButton.Visible = false;
            }
            if (count < yellowprice)
            {
                yellowButton.Visible = false;
            }
            if (count >= steveprice)
            {
                steveRoss.Visible = true;
            }
            if (count >= whiteprice)
            {
                whiteButton.Visible = true;
            }
            if (count >= blueprice)
            {
                blueButton.Visible = true;
            }
            if (count >= greenprice)
            {
                greenButton.Visible = true;
            }
            if (count >= brownprice)
            {
                brownButton.Visible = true;
            }
            if (count >= yellowprice)
            {
                yellowButton.Visible = true;
            }
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            green = green + 1000 ;
            greenamount++;
            amountOfGreen.Text = greenamount.ToString() + " Green";
            count = count - greenprice;
            greenprice = greenprice * 1.15;
            amountOfBobsLabel.Text = count.ToString("#") + " Bobs";
            sapGreenLabel.Text = blueprice.ToString("#");
            if (count < steveprice)
            {
                steveRoss.Visible = false;
            }
            if (count < whiteprice)
            {
                whiteButton.Visible = false;
            }

            if (count < blueprice)
            {
                blueButton.Visible = false;
            }
            if (count < greenprice)
            {
                greenButton.Visible = false;
            }
            if (count < brownprice)
            {
                brownButton.Visible = false;
            }
            if (count < yellowprice)
            {
                yellowButton.Visible = false;
            }
            if (count >= steveprice)
            {
                steveRoss.Visible = true;
            }
            if (count >= whiteprice)
            {
                whiteButton.Visible = true;
            }
            if (count >= blueprice)
            {
                blueButton.Visible = true;
            }
            if (count >= greenprice)
            {
                greenButton.Visible = true;
            }
            if (count >= brownprice)
            {
                brownButton.Visible = true;
            }
            if (count >= yellowprice)
            {
                yellowButton.Visible = true;
            }
        }

        private void brownButton_Click(object sender, EventArgs e)
        {
            brown = brown + 2500;
            brownamount++;
            amountOfBrown.Text = brownamount.ToString() + " Brown";
            count = count - brownprice;
            brownprice = brownprice * 1.15;
            amountOfBobsLabel.Text = count.ToString("#") + " Bobs";
            vanDykeBrownLabel.Text = brownprice.ToString("#");
            if (count < steveprice)
            {
                steveRoss.Visible = false;
            }
            if (count < whiteprice)
            {
                whiteButton.Visible = false;
            }

            if (count < blueprice)
            {
                blueButton.Visible = false;
            }
            if (count < greenprice)
            {
                greenButton.Visible = false;
            }
            if (count < brownprice)
            {
                brownButton.Visible = false;
            }
            if (count < yellowprice)
            {
                yellowButton.Visible = false;
            }
            if (count >= steveprice)
            {
                steveRoss.Visible = true;
            }
            if (count >= whiteprice)
            {
                whiteButton.Visible = true;
            }
            if (count >= blueprice)
            {
                blueButton.Visible = true;
            }
            if (count >= greenprice)
            {
                greenButton.Visible = true;
            }
            if (count >= brownprice)
            {
                brownButton.Visible = true;
            }
            if (count >= yellowprice)
            {
                yellowButton.Visible = true;
            }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            yellow = yellow + 100000;
            yellowamount++;
            amountOfYellow.Text = yellowamount.ToString() + " Yellow";
            count = count - yellowprice;
            yellowprice = yellowprice * 1.15;
            amountOfBobsLabel.Text = count.ToString("#") + " Bobs";
            yellowOchreLabel.Text = yellowprice.ToString("#");
            if (count < steveprice)
            {
                steveRoss.Visible = false;
            }
            if (count < whiteprice)
            {
                whiteButton.Visible = false;
            }

            if (count < blueprice)
            {
                blueButton.Visible = false;
            }
            if (count < greenprice)
            {
                greenButton.Visible = false;
            }
            if (count < brownprice)
            {
                brownButton.Visible = false;
            }
            if (count < yellowprice)
            {
                yellowButton.Visible = false;
            }
            if (count >= steveprice)
            {
                steveRoss.Visible = true;
            }
            if (count >= whiteprice)
            {
                whiteButton.Visible = true;
            }
            if (count >= blueprice)
            {
                blueButton.Visible = true;
            }
            if (count >= greenprice)
            {
                greenButton.Visible = true;
            }
            if (count >= brownprice)
            {
                brownButton.Visible = true;
            }
            if (count >= yellowprice)
            {
                yellowButton.Visible = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string newbobAmount = amountOfBobsLabel.Text;
            string newsteveprice = stevePriceLabel.Text;
            string newsteveamount = amountOfSteves.Text;
            string newwhiteprice = titaniumWhiteLabel.Text;
            string newwhiteamount = amountOfWhite.Text;
            string newblueprice = phthaloBlueLabel.Text;
            string newblueamount = amountOfBlue.Text;
            string newgreenprice = sapGreenLabel.Text;
            string newgreenamount = amountOfGreen.Text;
            string newbrownprice = vanDykeBrownLabel.Text;
            string newbrownamount = amountOfBrown.Text;
            string newyellowprice = yellowOchreLabel.Text;
            string newyellowamount = amountOfYellow.Text;

            Employee newScores = new Employee(newbobAmount, newsteveprice, newsteveamount, newwhiteprice, newwhiteamount, newblueprice, newblueamount,newgreenprice, newgreenamount, newbrownprice, newbrownamount,newyellowprice, newyellowamount);
            employeeDB.Add(newScores);
        }

     
    }
    }
