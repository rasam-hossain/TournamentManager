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
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            InitializeComponent();
            
            //Sample Test Data
            //CreateSampleData();
            
            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Rasam", LastName = "Hossain" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Corey", LastName = "Smith" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Smith", LastName = "Anderson" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Jacky", LastName = "Lazar" });
        }
        private void WireUpLists()
        {
            /*
             * An in-efficient method has been designed to 
             * force refresh the datasource of the dropdown lists
             */
            selectTeamDropdown.DataSource = null;
            selectTeamDropdown.DataSource = availableTeamMembers;
            selectTeamDropdown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
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


                selectedTeamMembers.Add(model);
                WireUpLists(); // Refreshes the data source

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

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamDropdown.SelectedItem;

            if(p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                WireUpLists();  // Refreshes the data source
            }
            
        }

        private void removeSelectedTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if(p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);
                WireUpLists();  // Refreshes the data source
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            t = GlobalConfig.Connection.CreateTeam(t);

            // ToDo - Reset the Form, if we aren't closing the form
        }
    }
}
