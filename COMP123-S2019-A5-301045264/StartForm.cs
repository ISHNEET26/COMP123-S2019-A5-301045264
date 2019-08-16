using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* STUDENT NAME : ISHNEET KAUR
 * STUDENT NUMBER : 301045624
 * PROJECT NAME : DOLLAR COMPUTERS
 * LAST DATE MODIFIED: 16 TH AUGUST 2019
 * DESCRIPTION: it is a multi-form project that simulates a computer purchase.The program initially gives
the user an option to “start a new order” or “load a saved order”. If the user selects “start a new order”
the program allows the user to select computer hardware from a dynamic grid generated from a
database connection. The user will then select computer hardware from a form control. The selected
hardware components will display on a separate form and the user will have the option to save the
configuration to a file. It also calculates cost of the computer in a aseperate form.
 * SHORT REVISION HISTORY-
 * GUI INTERFACE CREATED                                  :  AUGUST 9TH 2019
 * START FORM AND SPLASH SCREEN FUNCTIONALITIES COMPLETED : AUGUST 16TH , 2019
 * SELECT FORM CREATED                                    : AUGUST 16TH , 2019
 */
namespace COMP123_S2019_A5_301045264
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this event handler opens the select form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.SELECT_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// this event handler terminates the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// this event handler pops up the open file dialog box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavedOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormNames.PRODUCT_INFO_FORM].Show();
            ProductInfoForm.OpenFileDialog();
        }
    }
}
