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
    public sealed partial class MainMenu : Page
    {
        public MainMenu()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btnProductList_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Interfaces.ProductList));
        }

        private void btnAddNewProduct_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Interfaces.AddNewProduct));
        }

        private void btnProductTypes_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Interfaces.ProductType));
        }

        private void btnSuppliers_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Interfaces.SupplierList));
        }

        private void btnTotalAssets_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Interfaces.ProductTypeList));
        }
    }
}


// Frame.Navigate(typeof(MainMenu));