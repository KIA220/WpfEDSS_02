﻿#pragma checksum "..\..\..\Pages\LoginPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "44DAF43827C6410C1591E46351FCE8B6CCD9CE8FEC0F03EBD30B9208FFA66766"
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
using WpfEDSS.Pages;


namespace WpfEDSS.Pages {
    
    
    /// <summary>
    /// LoginPage
    /// </summary>
    public partial class LoginPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Pages\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblLoginHint;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginTextBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblPasswordHint;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        
        #line 35 "..\..\..\Pages\LoginPage.xaml"

            
            private void OnPasswordChanged(object sender, RoutedEventArgs e) 
                => tblPasswordHint.Visibility = passwordBox.Password.Length == 0 ? Visibility.Visible : Visibility.Hidden;
            private void OnLoginChanged(object sender, RoutedEventArgs e) 
                => tblLoginHint.Visibility = loginTextBox.Text.Length == 0 ? Visibility.Visible : Visibility.Hidden;
            
        
        #line default
        #line hidden
        
        
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
            System.Uri resourceLocater = new System.Uri("/WpfEDSS;component/pages/loginpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\LoginPage.xaml"
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
            this.tblLoginHint = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.loginTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\Pages\LoginPage.xaml"
            this.loginTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnLoginChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tblPasswordHint = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.passwordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 31 "..\..\..\Pages\LoginPage.xaml"
            this.passwordBox.PasswordChanged += new System.Windows.RoutedEventHandler(this.OnPasswordChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 32 "..\..\..\Pages\LoginPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoginButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 33 "..\..\..\Pages\LoginPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

