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
    struct ShoppingList
    {
        private static List<ListViewItem> list_buy = new List<ListViewItem>();
        //listViewItem.SubItems[1].Text; вытаскиваем текст

        public static void Add(string[] items, ref ListView list)
        {
            ListViewItem listViewItem = new ListViewItem(items);
            list_buy.Add(listViewItem);
            list.Items.Add(listViewItem);
            // Оформить метод окончательно
        }
    }
}
