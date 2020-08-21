using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* student name-Ravleen kaur;
 * student number=301101894;
 * date last modified:21-08-2020
 */

namespace COMP123_M2020_FinalExam
{
    public static class Program
    {
        public static Character character = new Character();
        public static SplashForm splashform;
        public static GenerateNameForm generateNameForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AbilityGeneratorForm());
            // create splashfrom and generatenameform objects
            splashform = new SplashForm();
            generateNameForm = new GenerateNameForm();

            // the program starts with splashform
            Application.Run(splashform);
        }
    }
}
