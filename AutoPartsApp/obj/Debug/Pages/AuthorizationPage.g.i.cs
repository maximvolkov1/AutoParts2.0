﻿#pragma checksum "..\..\..\Pages\AuthorizationPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F3E61366302CF30005DB19319BB3C3AD73201C5E"
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
    /// AuthorizationPage
    /// </summary>
    public partial class AuthorizationPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Pages\AuthorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginTxb;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Pages\AuthorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordBx;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\AuthorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkPasswordChbx;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\AuthorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button inputBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoPartsApp;component/pages/authorizationpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AuthorizationPage.xaml"
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
            this.loginTxb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.passwordBx = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 16 "..\..\..\Pages\AuthorizationPage.xaml"
            this.passwordBx.KeyUp += new System.Windows.Input.KeyEventHandler(this.passwordBx_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.checkPasswordChbx = ((System.Windows.Controls.CheckBox)(target));
            
            #line 20 "..\..\..\Pages\AuthorizationPage.xaml"
            this.checkPasswordChbx.Checked += new System.Windows.RoutedEventHandler(this.checkPasswordChbx_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.inputBtn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Pages\AuthorizationPage.xaml"
            this.inputBtn.Click += new System.Windows.RoutedEventHandler(this.inputBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

