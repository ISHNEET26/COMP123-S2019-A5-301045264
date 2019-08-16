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
 * DESCRIPTION: THIS IS THE SPLASH FORM
 * LAST DATE MODIFIED:  AUGUST 9TH, 2019
 */
namespace COMP123_S2019_A5_301045264
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.Forms[FormNames.START_FORM].Show();
            this.Hide();
        }
    }
}
