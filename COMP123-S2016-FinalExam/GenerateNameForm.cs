
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*NAME:RAVLEEN KAUR
 * STUDENT NUMBER:301101894
 * DATE MODIFIED:21-08-2020*/

namespace COMP123_M2020_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        private Random random;
        
        public GenerateNameForm()
        {
            
            InitializeComponent();
        }
        private void GenerateNames()
        {
            random = new Random();
            int firstname = random.Next(0, 50);
            int lastname = random.Next(0, 50);
            FirstNameListBox.SelectedIndex = firstname;
            LastNamesListbox.SelectedIndex = lastname;
            FirstNameTextBox.Text = FirstNameListBox.GetItemText(FirstNameListBox.SelectedItem);
            LastNameTextBox.Text = LastNamesListbox.GetItemText(LastNamesListbox.SelectedItem);

        }
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }

        

        private void GenerateButton_Click_1(object sender, EventArgs e)
        {
            GenerateNames();
            Program.character.firstname = FirstNameTextBox.Text;
            Program.character.lastname = LastNameTextBox.Text;
        }

        private void NextButton_Click_1(object sender, EventArgs e)
        {
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            abilityGeneratorForm.Show();
            this.Hide();
        }
    }
    }

