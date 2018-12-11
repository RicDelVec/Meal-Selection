using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //Defining variables
            int breakfast = cmbBreakfast.SelectedIndex;
            int lunch = cmbLunch.SelectedIndex;
            int dinner = cmbDinner.SelectedIndex;

            //Creating arrays
            double[] price = { 3.95, 10.95, 11.95 };
            int[] meal = { breakfast, lunch, dinner };

            //Meal validation
            for (int i = 0; i < meal.Length; i++)
            {
                if (meal[i] != -1)
                {
                    //Quantity validation
                    int quantityBreak;
                    bool isBreak = int.TryParse(txtBreakfast.Text, out quantityBreak);
                    int quantityLunch;
                    bool isLunch = int.TryParse(txtLunch.Text, out quantityLunch);
                    int quantityDinner;
                    bool isDinner = int.TryParse(txtDinner.Text, out quantityDinner);

                    //Implementing loop
                    int[] quantity = { quantityBreak, quantityLunch, quantityDinner };                    
                    for (int j = 0; j < quantity.Length; j++)
                    {
                        if (quantity[j] > 0)
                        {
                            //Calculating meal prices
                            double priceBreak = price[0] * quantityBreak;
                            double priceLunch = price[1] * quantityLunch;
                            double priceDinner = price[2] * quantityDinner;

                            //Calculating and displaying Sub Total
                            double subTotal = priceBreak + priceLunch + priceDinner;
                            lblPriceSub.Text = "$ " + Convert.ToString(subTotal);

                            //Calculating and displaying Tax
                            double tax = subTotal * 0.13;
                            lblPriceTax.Text = "$ " + Convert.ToString(tax);

                            //Calculating and displaying Total
                            double total = subTotal + tax;
                            lblPriceTotal.Text = "$ " + total;
                        }
                        else
                        {
                            Error();
                        }
                    }
                }
                else
                {
                    Error();
                }
            }
        }

        //Error message
        private void Error()
        {
            lblErrorBreak.Text = "Invalid Meal Selection. Invalid Quantity.";
            lblErrorLunch.Text = "Invalid Meal Selection. Invalid Quantity.";
            lblErrorDinner.Text = "Invalid Meal Selection. Invalid Quantity.";
        }
    }
}
