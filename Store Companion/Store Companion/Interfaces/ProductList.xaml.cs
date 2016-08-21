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
    public sealed partial class ProductList : Page
    {
        Classes.ItemsTable itemsTable;
        ListBoxItem listBoxItem;
        public ProductList()
        {
            this.InitializeComponent();
            this.GetProductDetails();
        }

        private void GetProductDetails()
        {
            List<Classes.ItemsTable> productsList;

            itemsTable = new Classes.ItemsTable();
            productsList = itemsTable.GetItemsDetails();

            foreach (Classes.ItemsTable obj in productsList)
            {

                string itemType = obj.ProductType;
                string itemName = obj.ItemName;
                int totalQty = obj.TotalQuantity;

                string product = itemType + "\t\t" + itemName + "\t\t" + totalQty.ToString();
                listBoxItem = new ListBoxItem();
                listBoxItem.Name = product;
                listBoxItem.Width = productListView.Width - 10;
                listBoxItem.Height = 35;
                listBoxItem.HorizontalAlignment = HorizontalAlignment.Left;
                listBoxItem.Content = product;
                productListView.Items.Add(listBoxItem);

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

        private void ScrollViewer_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Interfaces.LotList));
        }

        private void btnSearchProduct_Tapped(object sender, TappedRoutedEventArgs e)
        {
            
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Interfaces.AddNewProduct));
        }

        private void btnAddLot_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Interfaces.AddNewLot));
        }

        private void Hawhawhaw(object sender, ItemClickEventArgs e)
        {
            int x = 0;
        }

        private void productListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void productListView_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string hawwa = ((ListView)sender).Name;


        }
    }
}

