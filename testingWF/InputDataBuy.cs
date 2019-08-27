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
    class InputDataBuy
    {
        
        MaskedTextBox m;
        List<MaskedTextBox> maskedName = new List<MaskedTextBox>();


        public void mb()
        {
            MessageBox.Show(m.Text);
        }


        //private void CheckAddButton4Enable(MaskedTextBox maskedText)
        //{
        //    if (string.IsNullOrEmpty(maskedText.Text))
        //    {
        //        errorProvider1.SetError(maskedText, "Введите наименование покупки");
        //        maskedText.Focus();
        //        button4.Enabled = false;
        //    }
        //    else
        //    {
        //        bool x = true;
        //        errorProvider1.SetError(maskedText, null);
        //        if (!maskedName.Contains(maskedText))
        //            maskedName.Add(maskedText);
        //        foreach (Control control in groupBox1.Controls)
        //        {
        //            if (control is MaskedTextBox)
        //            {
        //                if (string.IsNullOrEmpty(control.Text))
        //                {
        //                    x = false;
        //                    break;
        //                }
        //            }
        //        }
        //        if (x) { button4.Enabled = true; }
        //    }
        //}

    }
}
