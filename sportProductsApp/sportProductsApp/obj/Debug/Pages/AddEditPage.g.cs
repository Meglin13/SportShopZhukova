#pragma checksum "..\..\..\Pages\AddEditPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "44950B7292CEBAA35F7596C08565ED4AA8DD8D14897C4B797CEDE12068DED917"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using sportProductsApp.Pages;


namespace sportProductsApp.Pages {
    
    
    /// <summary>
    /// AddEditPage
    /// </summary>
    public partial class AddEditPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\Pages\AddEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IDTB;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\AddEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CategoryCB;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\AddEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProductQuantityInStockTB;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\AddEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UnitCB;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Pages\AddEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ProductPhotoIMG;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\AddEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PhotoLoadBT;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pages\AddEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SuppliersCB;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\AddEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ManufacturerCB;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Pages\AddEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProductCostTB;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\AddEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBT;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Pages\AddEditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBT;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/sportProductsApp;component/pages/addeditpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AddEditPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.IDTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.CategoryCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.ProductQuantityInStockTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\Pages\AddEditPage.xaml"
            this.ProductQuantityInStockTB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ProductQuantityInStockTB_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UnitCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ProductPhotoIMG = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.PhotoLoadBT = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Pages\AddEditPage.xaml"
            this.PhotoLoadBT.Click += new System.Windows.RoutedEventHandler(this.PhotoLoadBT_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SuppliersCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.ManufacturerCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.ProductCostTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 52 "..\..\..\Pages\AddEditPage.xaml"
            this.ProductCostTB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ProductCostTB_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BackBT = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Pages\AddEditPage.xaml"
            this.BackBT.Click += new System.Windows.RoutedEventHandler(this.BackBT_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SaveBT = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Pages\AddEditPage.xaml"
            this.SaveBT.Click += new System.Windows.RoutedEventHandler(this.SaveBT_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

