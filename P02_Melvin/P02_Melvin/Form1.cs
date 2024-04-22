using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace P02_Melvin

{
    public partial class Form1 : Form
{
        const double TAX = 0.05;


        public Form1()
    {
        InitializeComponent();
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
            try
            {
                MessageBox.Show("Program ended");
            }
            catch { 
            }
            Close();

            // I want to cry ;(
        }

    private void addButton_Click(object sender, EventArgs e)
    {
            try
            {
                //declare variables
                double List = double.Parse(listTextBox.Text);
                double Discount = double.Parse(discountTextBox.Text);
                double OutputList = double.Parse(outputListLabel.Text);


                double taxTotal, taxesAmount, discountTotal, discountedAmount, netTotal;

                netTotal = double.Parse(outputNetLabel.Text);

                // Calculate


                //Discount Total
                discountedAmount = List * Discount; // 100 * 0.1 = 10
                discountTotal = List - discountedAmount; // 100 - 10 = 90

                //Taxes Total
                taxesAmount = List * TAX;       // 100 * 0.05 = 5
                taxTotal = List + taxesAmount;  // 100 + 5 = 105

                //Net Total
                netTotal = List - discountedAmount + taxesAmount;



                // Output (display)

                outputListLabel.Text = List.ToString();
                outputDiscountLabel.Text = discountTotal.ToString();
                outputTaxLabel.Text = taxTotal.ToString();
                outputNetLabel.Text = netTotal.ToString();

                //  /\/\/\/\/\/\/\/\/\ WHY ISN'T THIS WORKING!??!?!??!?! I've been doing this for HOURS WITH NOTHING TO SHOW FOR IT!!!!! ;-;

            }

            catch(Exception)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void outputNetLabel_Click(object sender, EventArgs e)
    {

    }

    private void outputListLabel_Click(object sender, EventArgs e)
    {
        string List = listTextBox.Text;
        listTextBox.Text = List;


    }

    private void totalTaxLabel_Click(object sender, EventArgs e)
    {

    }

    private void outputTaxLabel_Click(object sender, EventArgs e)
    {
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
        listTextBox.Text = "";
        discountTextBox.Clear();
    }

        private void outputDiscountLabel_Click(object sender, EventArgs e)
        {

        }
    } 
}
