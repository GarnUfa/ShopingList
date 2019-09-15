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
    public partial class Form1 : Form
    {
        List<MaskedTextBox> maskedName = new List<MaskedTextBox>();
        InputControl inputControl;



        public Form1()
        {
            InitializeComponent();
            this.inputControl = new InputControl(addItemButton, errorProvider1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox1.Location = listView1.Location;
            listView1.Visible = false;
            addItemButton.Enabled = false;
            

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            listView1.Visible = true;
            listView1.Focus();
            addItemButton.Enabled = true;
            foreach (Control con in groupBox1.Controls)
            {
                if (con is MaskedTextBox)
                    con.Text = "";

                else if (con is CheckBox)
                    ((CheckBox)con).Checked = false;
            }


            foreach (MaskedTextBox m in groupBox1.Controls.OfType<MaskedTextBox>())
            {
                errorProvider1.SetError(m, null);
            }
            InputControl.Clear();

        }



        private void AddItemButton(object sender, EventArgs e)
        {
            string chekBoxBuyOrNot = "V";
            string differenceInt = "sdas";
            string[] completedPurchase = {buyNameStr.Text, quantityStr.Text, actualСostInt.Text, notExactCostInt.Text, differenceInt, chekBoxBuyOrNot };
            ShoppingList.Add(completedPurchase, ref listView1);
            button6.Visible = true;
            this.Refresh();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Подключить чекбокс к результатам
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            foreach (Control con in groupBox1.Controls)
            {
                if (con is MaskedTextBox)
                    con.Text = "";

                else if (con is CheckBox)
                    ((CheckBox)con).Checked = false;
            }
            InputControl.Clear();
            buyNameStr.Focus();
            button6.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                listView1.SelectedItems[0].Remove();
                label6.Visible = false;
            }
            catch
            {
                if (listView1.Items.Count != 0)
                {
                    label6.Text = "Выберете элемент удаления";
                    label6.Visible = true;
                    Task.Delay(1000).Wait();
                    label6.Visible = false;
                }
                else
                {
                    label6.Text = "Добавьте покупку";
                    label6.Visible = true;
                    Task.Delay(1000).Wait();
                    label6.Visible = false;
                }

            }
            

            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Создать класс посвящ редактированию
            MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);
            
        }
        private void ListView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
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

        private void KeyUp_Event(object sender, KeyEventArgs e) //KeyPress
        {
            inputControl.CheckAddButton4Enable(groupBox1.Controls);
        }

        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            MaskedTextBox i = sender as MaskedTextBox;
            i.SelectionStart = i.Text.Length;
        }


    }
    
}
