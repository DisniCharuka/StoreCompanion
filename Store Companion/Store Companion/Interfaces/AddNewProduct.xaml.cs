using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Store_Companion.Interfaces
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddNewProduct : Page
    {
        Classes.ItemTypesTable itemTypesTable;
        public AddNewProduct()
        {
            this.InitializeComponent();

            this.GetProductTypeList();
        }

        private void GetProductTypeList()
        {
            List<Classes.ItemTypesTable> itemTypeList;

            itemTypesTable = new Classes.ItemTypesTable();
            itemTypeList = itemTypesTable.GetItemTypeDetails();

            foreach (Classes.ItemTypesTable obj in itemTypeList)
            {
                string typeDescription = obj.TypeDescription;
                cboProductType.Items.Add(typeDescription);
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
            /*Classes.ItemsTable items = new Classes.ItemsTable();
            App.conn.CreateTable<Classes.ItemsTable>();
            //App.conn.Execute("DELETE FROM ItemsTable");

            items.ProductType = cboProductType.SelectedValue.ToString();
            items.ItemName = txtItemName.Text;
            items.QuantityAlert = Convert.ToInt32(txtQuantityAlert.Text);
            items.ExpireAlert = Convert.ToInt32(txtExpDateAlert.Text);

            App.conn.Insert(items);
            MessageDialog messageBox = new MessageDialog("Successfully inserted a Product record.");
            await messageBox.ShowAsync();

            //Frame.Navigate(typeof(AddNewLot));
            Frame.Navigate(typeof(AddNewLot), txtItemName.Text);*/

            //cboProductType.PlaceholderText = "";
            //txtItemName.Text = "";
            //txtQuantityAlert.Text = "";
            //txtExpDateAlert.Text = "";
        }
    }
}
