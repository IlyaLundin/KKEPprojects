﻿#pragma checksum "..\..\..\Windows\WindowAuthorisation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "945367C26BD8BC399C89057C1A64104F8F720150B19FAFDCA804F0A4BEA574A3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CalendarNotes;
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


namespace CalendarNotes {
    
    
    /// <summary>
    /// WindowAuthorisation
    /// </summary>
    public partial class WindowAuthorisation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Windows\WindowAuthorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Login;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Windows\WindowAuthorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Parole;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Windows\WindowAuthorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordText;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Windows\WindowAuthorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Windows\WindowAuthorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CalendarNotes.UserControlEye ShowPass;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Windows\WindowAuthorisation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAuthorise;
        
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
            System.Uri resourceLocater = new System.Uri("/CalendarNotes;component/windows/windowauthorisation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\WindowAuthorisation.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.Login = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\Windows\WindowAuthorisation.xaml"
            this.Login.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Login_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Parole = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.PasswordText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Password = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 17 "..\..\..\Windows\WindowAuthorisation.xaml"
            this.Password.PasswordChanged += new System.Windows.RoutedEventHandler(this.Password_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ShowPass = ((CalendarNotes.UserControlEye)(target));
            return;
            case 6:
            this.ButtonAuthorise = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Windows\WindowAuthorisation.xaml"
            this.ButtonAuthorise.Click += new System.Windows.RoutedEventHandler(this.Authorise);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
