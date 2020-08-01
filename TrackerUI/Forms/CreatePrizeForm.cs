﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI.Forms
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PrizeModel model = new PrizeModel(placeNumberValue.Text, 
                                                placeNameValue.Text, 
                                                prizeAmountValue.Text, 
                                                prizePercentageValue.Text);                
                GlobalConfig.Connection.CreatePrize(model);

                // Clear-out the form
                placeNumberValue.Text = "";
                placeNameValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid infromation."); 
            }
        }
        private bool ValidateForm()
        {
            bool output = true;

            // Place Number Validation
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            if(!placeNumberValidNumber) output = false;
            if (placeNumber < 1) output = false;
            if (placeNameValue.Text.Length == 0) output = false;


            // Prize Amount and Prize Percentge 
            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (prizePercentageValid == false || prizePercentageValid == false) output = false;
            if (prizeAmount <= 0 && prizePercentage <= 0) output = false;
            if (prizePercentage < 0 || prizePercentage > 100) output = false;

            return output;
        }
    }
}
