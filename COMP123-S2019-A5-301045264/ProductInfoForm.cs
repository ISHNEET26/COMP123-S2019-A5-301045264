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
 * DESCRIPTION: THIS IS THE PRODUCT INFO FORM
 */
namespace COMP123_S2019_A5_301045264
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this is sthe event handler for the next button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.ORDER_FORM].Show();
            this.Hide();

            
        }
        /// <summary>
        /// this is sthe event handler for the click event of the cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// this is the method that opens the dialog box that enables users to choose files from their system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void OpenFileDialog()
        {
            //EXTERNAL RESOURCE: https://www.youtube.com/user/ProgrammingKnowledge/videos
            OpenFileDialog dialogbox1 = new OpenFileDialog();
            dialogbox1.Filter = "TextFiles|*.txt";
            if(dialogbox1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string doc = dialogbox1.FileName;
                MessageBox.Show(doc);
            }
        }

       

        private void AnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.SELECT_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// this is the event handler for the exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is thwe event handler for the select another product option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.SELECT_FORM].Show();
            this.Hide();
        }
    }
}
