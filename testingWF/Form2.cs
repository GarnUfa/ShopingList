using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testingWF
{
    public partial class Form2 : Form
    {
        InputControl inputControl;
        ListViewItem editedListVI;
        public Form2()
        {
            InitializeComponent();
            this.inputControl = new InputControl(addItemButton, errorProvider1);
            editedListVI = ShoppingList.ReturnListViewItem();
            buyNameStr.Text = editedListVI.SubItems[0].Text;
            quantityStr.Text = editedListVI.SubItems[1].Text;
            actualСostInt.Text = editedListVI.SubItems[2].Text;
            notExactCostInt.Text = editedListVI.SubItems[3].Text;
        }


        private void AddItemButton_Click_1(object sender, EventArgs e)
        {
            string differenceInt = "sdas";
            string[] completedPurchase = { buyNameStr.Text, quantityStr.Text, actualСostInt.Text, notExactCostInt.Text, ShoppingList.ReturnDifference(actualСostInt.Text, notExactCostInt.Text), ShoppingList.ChekBoxStatus(ref checkBox1) };
            ShoppingList.Edit(completedPurchase);
        }



        private void Enter_Event(object sender, EventArgs e)
        {
            MaskedTextBox focuedTextBox = sender as MaskedTextBox;
            focuedTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp_Event);
            focuedTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);

        }
        private void Leave_Event(object sender, EventArgs e)
        {
            MaskedTextBox focuedTextBox = sender as MaskedTextBox;
            focuedTextBox.KeyUp -= new System.Windows.Forms.KeyEventHandler(this.KeyUp_Event);
            focuedTextBox.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
        }
        private void KeyUp_Event(object sender, KeyEventArgs e) 
        {
            inputControl.CheckAddButton4Enable(groupBox1.Controls);
        }

        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            MaskedTextBox i = sender as MaskedTextBox;
            i.SelectionStart = i.Text.Length;
        }

        private void AddItemButton_VisibleChanged(object sender, EventArgs e)
        {
            InputControl.ActionVisibleButton((Button)sender, groupBox1);
        }
    }
}
