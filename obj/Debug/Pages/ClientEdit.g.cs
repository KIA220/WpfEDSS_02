﻿#pragma checksum "..\..\..\Pages\ClientEdit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "890F383EB9F87AFF8954674E45E4ED99940DF53BB0373EFF0C87A4762EB36C64"
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
    /// ClientEdit
    /// </summary>
    public partial class ClientEdit : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\Pages\ClientEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idClientIdBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\ClientEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ClientFIOBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\ClientEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idTelBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\ClientEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClientAdd;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Pages\ClientEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClientEdit;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Pages\ClientEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClientDel;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfEDSS;component/pages/clientedit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ClientEdit.xaml"
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
            this.idClientIdBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ClientFIOBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.idTelBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BtnClientAdd = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\Pages\ClientEdit.xaml"
            this.BtnClientAdd.Click += new System.Windows.RoutedEventHandler(this.BtnClientAdd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnClientEdit = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\Pages\ClientEdit.xaml"
            this.BtnClientEdit.Click += new System.Windows.RoutedEventHandler(this.BtnClientEdit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnClientDel = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\Pages\ClientEdit.xaml"
            this.BtnClientDel.Click += new System.Windows.RoutedEventHandler(this.BtnClientDel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

