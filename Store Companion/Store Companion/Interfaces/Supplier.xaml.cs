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
using Windows.UI.Popups;
using Store_Companion.Classes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Store_Companion.Interfaces
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Supplier : Page
    {

        public Supplier()
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

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //SupplierTable sup = new SupplierTable();
            //App.conn.CreateTable<Classes.SupplierTable>();
            ////App.conn.Execute("DELETE FROM Supplier");

            
            //sup.SupplierName = txtSupplierName.Text;
            //sup.SupplierTele = txtSupplierTel.Text;

            //App.conn.Insert(sup);
            //MessageDialog messageBox = new MessageDialog("Supplier record Inserted successfully.");
            //await messageBox.ShowAsync();

            //txtSupplierName.Text = "";
            //txtSupplierTel.Text = "";

        }
    }
}
