using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderingApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void showMainCourseButton_Click(object sender, EventArgs e)
        {
            string items = mainCourseComboBox.Text;
            MessageBox.Show(items,"Ordered Item",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }

        private void showDessertButton_Click(object sender, EventArgs e)
        {
            if (iceCreamCheckBox.Checked && mixedFruitCheckBox.Checked && faludaCheckBox.Checked && cakeCheckBox.Checked)
            {
                MessageBox.Show(iceCreamCheckBox.Text + " and " + mixedFruitCheckBox.Text + " and " + faludaCheckBox.Text + " and "+ cakeCheckBox.Text, "Ordered Items", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (iceCreamCheckBox.Checked && mixedFruitCheckBox.Checked && faludaCheckBox.Checked)
            {
                MessageBox.Show(iceCreamCheckBox.Text + " and " + mixedFruitCheckBox.Text +" and "+ faludaCheckBox.Text, "Ordered Items", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (iceCreamCheckBox.Checked && mixedFruitCheckBox.Checked && cakeCheckBox.Checked)
            {
                MessageBox.Show(iceCreamCheckBox.Text + " and " + mixedFruitCheckBox.Text + " and " + cakeCheckBox.Text, "Ordered Items", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (cakeCheckBox.Checked && mixedFruitCheckBox.Checked && faludaCheckBox.Checked)
            {
                MessageBox.Show(cakeCheckBox.Text + " and " + mixedFruitCheckBox.Text + " and " + faludaCheckBox.Text, "Ordered Items", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (iceCreamCheckBox.Checked && cakeCheckBox.Checked && faludaCheckBox.Checked)
            {
                MessageBox.Show(iceCreamCheckBox.Text + " and " + cakeCheckBox.Text + " and " + faludaCheckBox.Text, "Ordered Items", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (iceCreamCheckBox.Checked && mixedFruitCheckBox.Checked)
            {
                MessageBox.Show(iceCreamCheckBox.Text + " and " + mixedFruitCheckBox.Text,"Ordered Items",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
            else if (iceCreamCheckBox.Checked && faludaCheckBox.Checked)
            {
                MessageBox.Show(iceCreamCheckBox.Text + " and " + faludaCheckBox.Text, "Ordered Items", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (iceCreamCheckBox.Checked && cakeCheckBox.Checked)
            {
                MessageBox.Show(iceCreamCheckBox.Text + " and " +cakeCheckBox.Text, "Ordered Items", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (cakeCheckBox.Checked && mixedFruitCheckBox.Checked)
            {
                MessageBox.Show(cakeCheckBox.Text + " and " + mixedFruitCheckBox.Text, "Ordered Items", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (faludaCheckBox.Checked && mixedFruitCheckBox.Checked)
            {
                MessageBox.Show(faludaCheckBox.Text + " and " + mixedFruitCheckBox.Text, "Ordered Items", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (faludaCheckBox.Checked && cakeCheckBox.Checked)
            {
                MessageBox.Show(faludaCheckBox.Text + " and " + cakeCheckBox.Text, "Ordered Items", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (iceCreamCheckBox.Checked)
            {
                MessageBox.Show(iceCreamCheckBox.Text,"Ordered Items",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
            else if (faludaCheckBox.Checked)
            {
                MessageBox.Show(faludaCheckBox.Text, "Ordered Items", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (mixedFruitCheckBox.Checked)
            {
                MessageBox.Show(mixedFruitCheckBox.Text, "Ordered Items", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (cakeCheckBox.Checked)
            {
                MessageBox.Show(cakeCheckBox.Text, "Ordered Items", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Order Something");
            }
        }

        private void showBeverageButton_Click(object sender, EventArgs e)
        {
            if (cokeRadioButton.Checked)
            {
                MessageBox.Show(cokeRadioButton.Text,"Ordered Item",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
            else if (spriteRadioButton.Checked)
            {
                MessageBox.Show(spriteRadioButton.Text, "Ordered Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (mountainDewRadioButton.Checked)
            {
                MessageBox.Show(mountainDewRadioButton.Text, "Ordered Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (fantaRadioButton.Checked)
            {
                MessageBox.Show(fantaRadioButton.Text, "Ordered Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Order Something");
            }
        }
    }
}
