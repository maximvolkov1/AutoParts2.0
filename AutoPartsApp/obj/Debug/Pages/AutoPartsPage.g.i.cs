﻿#pragma checksum "..\..\..\Pages\AutoPartsPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8C4C5B94647CC75B5F8017C744C5ED66CD094A9C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoPartsApp.Pages;
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


namespace AutoPartsApp.Pages {
    
    
    /// <summary>
    /// AutoPartsPage
    /// </summary>
    public partial class AutoPartsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 12 "..\..\..\Pages\AutoPartsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView AutoPartLV;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Pages\AutoPartsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem addAutoPart;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Pages\AutoPartsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem delAutoPart;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Pages\AutoPartsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem updateAutoPart;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Pages\AutoPartsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Pages\AutoPartsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTxt;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Pages\AutoPartsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox APCcbx;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoPartsApp;component/pages/autopartspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AutoPartsPage.xaml"
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
            this.AutoPartLV = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.addAutoPart = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\..\Pages\AutoPartsPage.xaml"
            this.addAutoPart.Click += new System.Windows.RoutedEventHandler(this.addAutoPart_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.delAutoPart = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\..\Pages\AutoPartsPage.xaml"
            this.delAutoPart.Click += new System.Windows.RoutedEventHandler(this.delAutoPart_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.updateAutoPart = ((System.Windows.Controls.MenuItem)(target));
            
            #line 17 "..\..\..\Pages\AutoPartsPage.xaml"
            this.updateAutoPart.Click += new System.Windows.RoutedEventHandler(this.updateAutoPart_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\Pages\AutoPartsPage.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.backBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.searchTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 75 "..\..\..\Pages\AutoPartsPage.xaml"
            this.searchTxt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchTxt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.APCcbx = ((System.Windows.Controls.ComboBox)(target));
            
            #line 77 "..\..\..\Pages\AutoPartsPage.xaml"
            this.APCcbx.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.APCcbx_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 65 "..\..\..\Pages\AutoPartsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.editAutoPartBtn_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
