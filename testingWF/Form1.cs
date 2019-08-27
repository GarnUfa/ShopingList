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
        
        int validatedCount = 0;
        List<MaskedTextBox> maskedName = new List<MaskedTextBox>();
        InputDataBuy x;


        public Form1()
        {
            InitializeComponent();
        }


        
        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            InputDataBuy g = new InputDataBuy();
            x = g;
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox1.Location = listView1.Location;
            listView1.Visible = false;
            button4.Enabled = false;
            

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            validatedCount = 0;
            groupBox1.Visible = false;
            listView1.Visible = true;
            listView1.Focus();
            button4.Enabled = true;
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
            maskedName.Clear();

        }



        private void Button4_Click(object sender, EventArgs e)
        {
            string[] qwe = {maskedTextBox1.Text, maskedTextBox2.Text, maskedTextBox3.Text, maskedTextBox4.Text };
            ListViewItem buy = new ListViewItem(qwe);
            listView1.Items.Add(buy);
            button6.Visible = true;
            this.Refresh();
            //Добавить функцию с резултатами
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
            maskedName.Clear();
            maskedTextBox1.Focus();
            button6.Visible = false;
        }


        private void MaskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            CheckAddButton4Enable(maskedTextBox1);
            
        }
 
        private void MaskedTextBox2_Validating(object sender, CancelEventArgs e)
        {
            CheckAddButton4Enable(maskedTextBox2);
        }

        private void MaskedTextBox4_Validating(object sender, CancelEventArgs e)
        {
            CheckAddButton4Enable(maskedTextBox4);
        }

        private void MaskedTextBox3_Validating(object sender, CancelEventArgs e)
        {
            CheckAddButton4Enable(maskedTextBox3);
        }


        private void CheckAddButton4Enable(MaskedTextBox maskedText)
        {
            if (string.IsNullOrEmpty(maskedText.Text))
            {
                errorProvider1.SetError (maskedText, "Введите наименование покупки");
                maskedText.Focus();
                button4.Enabled = false;
            }
            else
            {
                bool x = true;
                errorProvider1.SetError(maskedText, null);
                if (!maskedName.Contains(maskedText))
                    maskedName.Add(maskedText);
                foreach(Control control in groupBox1.Controls)
                {
                    if(control is MaskedTextBox)
                    {
                        if (string.IsNullOrEmpty(control.Text))
                        {
                            x = false;
                            break;
                        }
                    }
                }
                if (x) { button4.Enabled = true; }
            }
        }


        private void MaskedTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            maskedTextBox1.SelectionStart = maskedTextBox1.Text.Length;
            maskedTextBox1.Select();
            if (maskedName.Count >= 3)
            {
                textChange(maskedTextBox1);
            }
        }
        private void MaskedTextBox2_MouseDown(object sender, MouseEventArgs e)
        {
            maskedTextBox2.SelectionStart = maskedTextBox2.Text.Length;
            maskedTextBox2.Select();
            if (maskedName.Count >= 3)
            {
                textChange(maskedTextBox2);
            }
        }
        private void MaskedTextBox3_MouseDown(object sender, MouseEventArgs e)
        {
            maskedTextBox3.SelectionStart = maskedTextBox3.Text.Length;
            maskedTextBox3.Select();
            if (maskedName.Count >= 3)
            {
                textChange(maskedTextBox3);
            }
        }
        private void MaskedTextBox4_MouseDown(object sender, MouseEventArgs e)
        {
            maskedTextBox4.SelectionStart = maskedTextBox4.Text.Length;
            maskedTextBox4.Select();
            if (maskedName.Count >= 3)
            {
                textChange(maskedTextBox4);
            }
        }
        MaskedTextBox mtBox;
        private void textChange (MaskedTextBox mtb)
        {
            mtb.TextChanged += Mtb_TextChanged;
            mtBox = mtb;
        }
        private void Mtb_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(mtBox.Text))
                button4.Enabled = false;
            else
                button4.Enabled = true;
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

        private void MaskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (maskedTextBox1.Text.Length == 0)
                ReturnSumbolToFirsPosition(maskedTextBox1);
        }

        private void MaskedTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            ReturnSumbolToFirsPosition(maskedTextBox2);
        }

        private void MaskedTextBox4_KeyDown(object sender, KeyEventArgs e)
        {
            ReturnSumbolToFirsPosition(maskedTextBox4);
        }

        private void MaskedTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            ReturnSumbolToFirsPosition(maskedTextBox3);
        }

        private void ReturnSumbolToFirsPosition(MaskedTextBox toFirst)
        {

            if (toFirst.SelectionStart > toFirst.Text.Length)
            {
                toFirst.SelectionStart = toFirst.Text.Length;
            }
        }

        private void ListView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }


    }
    
}
