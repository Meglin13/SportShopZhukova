﻿#pragma checksum "..\..\..\Pages\ManagerAndAuthUserPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B9B448EC3F05207AD8DB175F0107132708F64AA3D127CCD206D498A95D5D8DE6"
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
    /// ManagerAndAuthUserPage
    /// </summary>
    public partial class ManagerAndAuthUserPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Pages\ManagerAndAuthUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FIOTextBlock;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\ManagerAndAuthUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CounterOfRecordsLabel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\ManagerAndAuthUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\ManagerAndAuthUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton PriceOrderByRadioButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\ManagerAndAuthUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton PriceOrderByDescRadioButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\ManagerAndAuthUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ManufacturerComboBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pages\ManagerAndAuthUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListView;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\Pages\ManagerAndAuthUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
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
            System.Uri resourceLocater = new System.Uri("/sportProductsApp;component/pages/managerandauthuserpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ManagerAndAuthUserPage.xaml"
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
            this.FIOTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.CounterOfRecordsLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\Pages\ManagerAndAuthUserPage.xaml"
            this.SearchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PriceOrderByRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 33 "..\..\..\Pages\ManagerAndAuthUserPage.xaml"
            this.PriceOrderByRadioButton.Checked += new System.Windows.RoutedEventHandler(this.PriceOrderByRadioButton_Checked);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\Pages\ManagerAndAuthUserPage.xaml"
            this.PriceOrderByRadioButton.Unchecked += new System.Windows.RoutedEventHandler(this.PriceOrderByRadioButton_Unchecked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PriceOrderByDescRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 40 "..\..\..\Pages\ManagerAndAuthUserPage.xaml"
            this.PriceOrderByDescRadioButton.Checked += new System.Windows.RoutedEventHandler(this.PriceOrderByDescRadioButton_Checked);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\Pages\ManagerAndAuthUserPage.xaml"
            this.PriceOrderByDescRadioButton.Unchecked += new System.Windows.RoutedEventHandler(this.PriceOrderByDescRadioButton_Unchecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ManufacturerComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 45 "..\..\..\Pages\ManagerAndAuthUserPage.xaml"
            this.ManufacturerComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ManufacturerComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 132 "..\..\..\Pages\ManagerAndAuthUserPage.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

