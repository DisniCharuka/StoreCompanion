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
using Store_Companion.Classes;
using SQLite.Net.Attributes;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Store_Companion.Interfaces
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProductType : Page
    {
        public ProductType()
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

        public class ItemTypes
        {
            public string TypeId { get; set; }
            public string TypeDescription { get; set; }
        }


        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //ItemTypesTable itemType = new ItemTypesTable();
            //App.conn.CreateTable<Classes.ItemTypesTable>();

            //itemType.TypeDescription = txtTypeDescription.Text;

            //App.conn.Insert(itemType);
            //MessageDialog messageBox = new MessageDialog("Successfully Inserted an new Item Type record.");
            //await messageBox.ShowAsync();
            
            //txtTypeDescription.Text = "";

        }
    }
}
