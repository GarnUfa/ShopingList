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
    public class InputControl
    {

        private static List<MaskedTextBox> maskedName = new List<MaskedTextBox>();
        private Button addButton;
        private ErrorProvider unfilledMaskedTB;

        public InputControl(Button addButton, ErrorProvider unfilledMaskedTB)
        {
            this.addButton = addButton;
            this.unfilledMaskedTB = unfilledMaskedTB;
        }

        public void CheckAddButton4Enable(GroupBox.ControlCollection maskedBoxColl)
        {
            foreach (Control control in maskedBoxColl)
            {
                if (control is MaskedTextBox)
                {
                    ErrProvider(maskedBoxColl);
                    Add((MaskedTextBox)control);
                }
            }

            for(int i = 0; i<maskedName.Count; i++ )
            {
                if (string.IsNullOrEmpty(maskedName[i].Text))
                {
                    addButton.Enabled = false;
                    Clear();
                    break;
                }
                if (i == maskedName.Count - 1)
                {
                    Clear();
                    addButton.Enabled = true;
                }
            }

        }

        private static void Add(MaskedTextBox focusedTextBox)
        {
            maskedName.Add(focusedTextBox);
        }
        public static void Clear()
        {
            maskedName.Clear();
        }

        private void ErrProvider(GroupBox.ControlCollection maskedBoxColl)
        {
            foreach (Control control in maskedBoxColl)
            {
                if (control is MaskedTextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                        unfilledMaskedTB.SetError(control, "Нихуя нет");
                    else
                        unfilledMaskedTB.SetError(control, null);
                }

            }
        }
        public static void ActionVisibleButton(Button actionWithShopList, GroupBox textBoxGroupBox)
        {
            foreach (Control con in textBoxGroupBox.Controls)
            {
                if (con is MaskedTextBox)
                {
                    if (string.IsNullOrEmpty(con.Text))
                    {
                        actionWithShopList.Enabled = false;
                        break;
                    }

                }

            }
        }
    }

}