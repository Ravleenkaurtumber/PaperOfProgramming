using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*STUDENT NAME :RAVLEEN KAUR 
 * STUDENT NUMBER:301101894
 * LAST MODIFIED DATE:21-08-2020*/

namespace COMP123_M2020_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void splashtimer_Tick(object sender, EventArgs e)
        {
            Program.generateNameForm.Show();
            this.Hide();
            splashtimer.Enabled = false;
        }

        
    }
}
