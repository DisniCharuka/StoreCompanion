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
using System.Collections.ObjectModel;
using SQLite.Net;
using Store_Companion.Classes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Store_Companion.Interfaces
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SupplierList : Page
    {
        Classes.SupplierTable supplierTable;
        public SupplierList()
        {
            this.InitializeComponent();
            this.GetSupplierDetails();
            
        }

        private void GetSupplierDetails()
        {
            List<Classes.SupplierTable> supplierList;

            supplierTable = new Classes.SupplierTable();
            supplierList = supplierTable.GetSupplierDetails();


            foreach (Classes.SupplierTable obj in supplierList)
            {

                string supName = obj.SupplierName;
                string supTel = obj.SupplierTele;

                string supplier = supName + "\t\t" + supTel;
                ListBoxItem listBoxItem = new ListBoxItem();
                listBoxItem.Name = supName;
                listBoxItem.Width = supplierListView.Width - 10;
                listBoxItem.Height = 35;
                listBoxItem.HorizontalAlignment = HorizontalAlignment.Left;
                listBoxItem.Content = supplier;
                supplierListView.Items.Add(listBoxItem); 

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


    }
}

