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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Store_Companion.Interfaces
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LotList : Page
    {
        Classes.ItemTable itemTable;
        int lotNo;
        public LotList()
        {
            this.InitializeComponent();
            this.GetLotDetails();
        }

        private void GetLotDetails()
        {
            List<Classes.ItemTable> lotList;

            itemTable = new Classes.ItemTable();
            lotList = itemTable.GetItemDetails();

            foreach (Classes.ItemTable obj in lotList) {
                lotNo = obj.LotNo;
                //DateTime date = obj.BuyingDate;

                // string lot = lotNo.ToString() + "\t\t" + date.ToString();
                string lot = lotNo.ToString();
                ListBoxItem listBoxItem = new ListBoxItem();
                listBoxItem.Name = lot;
                listBoxItem.Width = lotListView.Width - 10;
                listBoxItem.Height = 35;
                listBoxItem.HorizontalAlignment = HorizontalAlignment.Left;
                listBoxItem.Content = lot;
                lotListView.Items.Add(listBoxItem);
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
            Frame.Navigate(typeof(Interfaces.ModifyProduct), lotNo);
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Interfaces.ProductList));
        }

        private void btnAddLot_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Interfaces.AddNewLot));
        }
    }
}
