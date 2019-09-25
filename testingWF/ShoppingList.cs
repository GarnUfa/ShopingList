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
        private static ListView listView { get; set; }
        private static ListViewItem selectedItem { get; set; }
        private static int selectedItemsRowNum;
        public static void Add(string[] items, ref ListView list)
        {
            ListViewItem listViewItem = new ListViewItem(items);
            AddToList_buy(listViewItem);
            listView = list;
            AddToListViewInForm();
        }


        public static void SelectedItemOnForm1(ListViewItem selectedItem)
        {
            ShoppingList.selectedItem = selectedItem;
        }
        // Эта хунта повторяется но эт потому что я мало знал
        public static int selectedItemsRow
        {
            get { return selectedItemsRowNum;}
            set {selectedItemsRowNum = value;}
        }

        public static int SelItemRow()
        {
            int i = listView.SelectedItems[0].Index;
            return i;
        }
        // Дада эта ^^

        public static void Edit(string[] editedList)
        {
            foreach (string x in editedList)
            {
                int indexOfEditElement = Array.IndexOf(editedList, x);
                ListViewItem ds = new ListViewItem();
                list_buy.Insert(selectedItemsRowNum, ds);
                listView.Items[selectedItemsRowNum].SubItems[indexOfEditElement].Text = x;
            }

        }
        public static void Delete()
        {
            list_buy.RemoveAt(SelItemRow());
            listView.SelectedItems[0].Remove();
        }

        private static void AddToList_buy(ListViewItem x)
        {
            list_buy.Add(x);
        }

        private static void AddToListViewInForm()
        {
            //listView.Items.Clear();
            foreach(ListViewItem x in list_buy)
            {
                if (listView.Items.Contains(x))
                    MessageBox.Show(x.SubItems[0].Text);
                else
                    listView.Items.Add(x);
                
            }
        }
        
        public static ListViewItem ReturnListViewItem ()
        {
           return list_buy[0];
        }

        public static string ChekBoxStatus(ref CheckBox buyStatus)
        {
            if (buyStatus.Checked)
                return "V";
            else
                return "X";
        }
        public static string ReturnDifference(string actualСost, string notExactCost)
        {
            int actualСostInt = int.Parse(actualСost);
            int notExactCostInt = int.Parse(notExactCost);
            string answer;
            if (actualСostInt > notExactCostInt)
                answer = "Дешевле на " + (actualСostInt - notExactCostInt).ToString();
            else if (actualСostInt == notExactCostInt)
                answer = "0";
            else
                answer = "Дороже на " + (notExactCostInt - actualСostInt).ToString();

            return answer;
            //Дописать метод просчета разницы
        }


    }
}
