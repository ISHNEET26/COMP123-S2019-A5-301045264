
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
 * DESCRIPTION: THIS IS THE SELECT FORM
 */

namespace COMP123_S2019_A5_301045264
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormNames.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void SelectFormDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.SelectFormDataGridView.Rows[e.RowIndex];

                SelectionTextBox.Text = "Cost:" + SelectFormDataGridView.SelectedRows[0].Cells[1].Value.ToString() + "\n Manufacturer :" + SelectFormDataGridView.SelectedRows[0].Cells[2].Value.ToString() + "\n Model: " + SelectFormDataGridView.SelectedRows[0].Cells[3].Value.ToString();
               

            }
        }

        private void SelectFormDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void SelectFormDataGridView_Click(object sender, EventArgs e)
        {

            ProductInfoForm poi = new ProductInfoForm();
            poi.ProductIDTextBox.Text = SelectFormDataGridView.CurrentRow.Cells[0].Value.ToString();
            poi.ConditionTextBox.Text = SelectFormDataGridView.CurrentRow.Cells[1].Value.ToString();
            poi.CostTextBox.Text = SelectFormDataGridView.CurrentRow.Cells[2].Value.ToString();
            poi.PlatformTextBox.Text = SelectFormDataGridView.CurrentRow.Cells[3].Value.ToString();
            poi.OSTextBox.Text = SelectFormDataGridView.CurrentRow.Cells[4].Value.ToString();
            poi.ManufacturerTextBox.Text = SelectFormDataGridView.CurrentRow.Cells[5].Value.ToString();
            poi.ModelTextBox.Text = SelectFormDataGridView.CurrentRow.Cells[6].Value.ToString();
            poi.MemoryTextBox.Text = SelectFormDataGridView.CurrentRow.Cells[7].Value.ToString();
            poi.LCDSizeTextBox.Text = SelectFormDataGridView.CurrentRow.Cells[8].Value.ToString();
            poi.HDDTextBox.Text = SelectFormDataGridView.CurrentRow.Cells[9].Value.ToString();
            poi.CPUBrandTextBox.Text = SelectFormDataGridView.CurrentRow.Cells[10].Value.ToString();
            poi.CPUNumberTextBox.Text = SelectFormDataGridView.CurrentRow.Cells[11].Value.ToString();
            poi.GPUTypeTextBox.Text = SelectFormDataGridView.CurrentRow.Cells[12].Value.ToString();
            poi.CPUTypeTextBox.Text = SelectFormDataGridView.CurrentRow.Cells[13].Value.ToString();
            poi.CPUSpeedTextBox.Text = SelectFormDataGridView.CurrentRow.Cells[14].Value.ToString();
            poi.WebCamTextBox.Text = SelectFormDataGridView.CurrentRow.Cells[15].Value.ToString();
            poi.Show();
        }
    }
}
