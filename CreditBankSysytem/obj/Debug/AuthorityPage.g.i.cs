﻿#pragma checksum "..\..\AuthorityPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3B20F2AB72D5BB2F64BCDCF970F0DB29"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CreditBankSysytem;
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


namespace CreditBankSysytem {
    
    
    /// <summary>
    /// AuthorityPage
    /// </summary>
    public partial class AuthorityPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\AuthorityPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button signInButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AuthorityPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxIIN;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AuthorityPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passwordTextBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AuthorityPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock incorrectTextBlock;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AuthorityPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button signUpButton;
        
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
            System.Uri resourceLocater = new System.Uri("/CreditBankSysytem;component/authoritypage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AuthorityPage.xaml"
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
            this.signInButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\AuthorityPage.xaml"
            this.signInButton.Click += new System.Windows.RoutedEventHandler(this.SignInButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBoxIIN = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\AuthorityPage.xaml"
            this.textBoxIIN.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBoxIIN_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.passwordTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.incorrectTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.signUpButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\AuthorityPage.xaml"
            this.signUpButton.Click += new System.Windows.RoutedEventHandler(this.SignUpButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

