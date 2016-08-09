using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using SQLite.Net.Attributes;
using Windows.UI.Popups;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Store_Companion.Interfaces
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddNewLot : Page
    {
        Classes.SupplierTable supplierTable;
        public AddNewLot()
        {
            this.InitializeComponent();
            this.GetSupplierList();
        }

        private void GetSupplierList()
        {
            List<Classes.SupplierTable> supplierList;

            supplierTable = new Classes.SupplierTable();
            supplierList = supplierTable.GetSupplierDetails();

            foreach (Classes.SupplierTable obj in supplierList)
            {
                string supplier = obj.SupplierName;
                cboSupplier.Items.Add(supplier);
            }
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Classes.ItemTable item = new Classes.ItemTable();
            App.conn.CreateTable<Classes.ItemTable>();
            //App.conn.Execute("DELETE FROM ItemTable");

            item.LotNo = Convert.ToInt32(txtLotNo.Text);
            item.ItemName = txtItemName.Text;
            item.QuantityInLot = Convert.ToInt32(txtQtyInLot.Text);
            item.Price = Convert.ToDouble(txtPrice.Text);
            //item.ExpDate = Convert.ToDateTime(dateExpDate);
            item.SupplierName = cboSupplier.PlaceholderText;
            
            App.conn.Insert(item);
            MessageDialog messageBox = new MessageDialog("Sccessfully inserted a new Item record.");
            await messageBox.ShowAsync();

            Frame.Navigate(typeof(Interfaces.ProductList));
        }
    }
}
