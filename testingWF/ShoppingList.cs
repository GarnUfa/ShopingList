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
        private static ListView listView;
        //listViewItem.SubItems[1].Text; вытаскиваем текст
        public static void Add(string[] items, ref ListView list)
        {
            
            ListViewItem listViewItem = new ListViewItem(items);
            AddToList_buy(listViewItem);
            listView = list;
            AddToListViewInForm();
            // Оформить метод окончательно
        }

        private static void AddToList_buy(ListViewItem x)
        {
            list_buy.Add(x);
        }

        private static void AddToListViewInForm()
        {
            listView.Items.Clear();
            foreach(ListViewItem x in list_buy)
            {
                listView.Items.Add(x);
            }
        }
        

    }
}
