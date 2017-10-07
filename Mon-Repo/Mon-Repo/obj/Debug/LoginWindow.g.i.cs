﻿#pragma checksum "..\..\LoginWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EFE549169BA56C8A6CC93EC930F27251"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Mon_Repo;
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


namespace Mon_Repo {
    
    
    /// <summary>
    /// LoginWindow
    /// </summary>
    public partial class LoginWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Db;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Reg;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserTextBox;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Mon-Repo;component/loginwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LoginWindow.xaml"
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
            
            #line 8 "..\..\LoginWindow.xaml"
            ((Mon_Repo.LoginWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.LoginWindowClosing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Db = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\LoginWindow.xaml"
            this.Db.Click += new System.Windows.RoutedEventHandler(this.DbClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Reg = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\LoginWindow.xaml"
            this.Reg.Click += new System.Windows.RoutedEventHandler(this.RegClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 30 "..\..\LoginWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoginClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\LoginWindow.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitClick);
            
            #line default
            #line hidden
            
            #line 33 "..\..\LoginWindow.xaml"
            this.ExitButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ExitMouseEnter);
            
            #line default
            #line hidden
            
            #line 33 "..\..\LoginWindow.xaml"
            this.ExitButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ExitMouseLeave);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UserTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.PasswordTextBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 76 "..\..\LoginWindow.xaml"
            this.PasswordTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.PasswordTextboxClick);
            
            #line default
            #line hidden
            
            #line 76 "..\..\LoginWindow.xaml"
            this.PasswordTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.PasswordTextBoxLostFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

