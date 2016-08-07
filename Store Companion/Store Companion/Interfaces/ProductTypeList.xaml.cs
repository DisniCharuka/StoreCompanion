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
    public sealed partial class ProductTypeList : Page
    {
        Classes.ItemTypesTable itemTypesTable;
        public ProductTypeList()
        {
            this.InitializeComponent();
            this.GetProductTypeDetails();
        }

        private void GetProductTypeDetails()
        {
            List<Classes.ItemTypesTable> itemTypeList;

            itemTypesTable = new Classes.ItemTypesTable();
            itemTypeList = itemTypesTable.GetItemTypeDetails();


            foreach (Classes.ItemTypesTable obj in itemTypeList)
            {

                string typeDescription = obj.TypeDescription;
                ListBoxItem listBoxItem = new ListBoxItem();
                listBoxItem.Name = typeDescription;
                listBoxItem.Width = itemTypeListView.Width - 10;
                listBoxItem.Height = 35;
                listBoxItem.HorizontalAlignment = HorizontalAlignment.Left;
                listBoxItem.Content = typeDescription;
                itemTypeListView.Items.Add(listBoxItem);

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

        private void btnNewType_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Interfaces.ProductType));
        }
    }
}
