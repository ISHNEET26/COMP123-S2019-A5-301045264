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

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.ORDER_FORM].Show();
            this.Hide();

            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
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

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {

            

        }

        private void AnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.SELECT_FORM].Show();
            this.Hide();
        }
    }
}
