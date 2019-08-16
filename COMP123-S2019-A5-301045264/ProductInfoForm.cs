using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if(dialogbox1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string doc = dialogbox1.FileName;
                MessageBox.Show(doc);
            }
        }
    }
}
