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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Store_Companion
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProductType : Page
    {
        DatabaseConnections databaseConnections;
        SQLite.Net.SQLiteConnection conn;

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
            txtTypeId.Text = "";
            txtTypeDescription.Text = "";
        }

        public class ItemTypes
        {
            public string TypeId { get; set; }
            public string TypeDescription { get; set; }
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var s = conn.Insert(new ItemTypes()
            {
                TypeId = txtTypeId.Text,
                TypeDescription = txtTypeDescription.Text
            });
        }
    }
}
