﻿

#pragma checksum "F:\Projects\StoreCompanionWP8.1\StoreCompanion\Store Companion\Store Companion\Interfaces\ProductList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5290F179084DB6A169E487441F3FC9CE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Store_Companion.Interfaces
{
    partial class ProductList : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button btnAddProduct; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button btnAddLot; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ListView productListView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox txtSearchProductName; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button btnSearchProduct; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock lblStoreHeading; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock lblScreenHeading; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///Interfaces/ProductList.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            btnAddProduct = (global::Windows.UI.Xaml.Controls.Button)this.FindName("btnAddProduct");
            btnAddLot = (global::Windows.UI.Xaml.Controls.Button)this.FindName("btnAddLot");
            productListView = (global::Windows.UI.Xaml.Controls.ListView)this.FindName("productListView");
            txtSearchProductName = (global::Windows.UI.Xaml.Controls.TextBox)this.FindName("txtSearchProductName");
            btnSearchProduct = (global::Windows.UI.Xaml.Controls.Button)this.FindName("btnSearchProduct");
            lblStoreHeading = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("lblStoreHeading");
            lblScreenHeading = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("lblScreenHeading");
        }
    }
}



