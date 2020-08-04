using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI.Forms
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PersonModel model = new PersonModel(firstNameValue.Text,
                                                    lastNameValue.Text,
                                                    emailValue.Text,
                                                    cellPhoneValue.Text);
                GlobalConfig.Connection.Createperson(model);

                // Clear out the form
                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellPhoneValue.Text = "";
            }
        }
        private bool ValidateForm()
        {
            //TODO - Add the form validations here
            if (firstNameValue.Text.Length == 0)
                return false;
            if (lastNameValue.Text.Length == 0)
                return false;
            if (emailValue.Text.Length == 0)
                return false;
            if (cellPhoneValue.Text.Length == 0)
                return false;
            return true;
        }
    }
}
