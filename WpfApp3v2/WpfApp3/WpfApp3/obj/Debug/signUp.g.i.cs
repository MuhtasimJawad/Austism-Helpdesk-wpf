﻿#pragma checksum "..\..\signUp.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "553FF772A7B1FACAB5F1DADDEE9933BF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using WpfApp3;


namespace WpfApp3 {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\signUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uname;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\signUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fname;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\signUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phone;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\signUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pass;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\signUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pass2;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\signUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cname;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\signUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox age;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\signUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox location;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\signUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button signBtn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\signUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loginBtn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\signUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton malebtn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\signUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton febtn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\signUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton otherbtn;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/signup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\signUp.xaml"
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
            this.uname = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\signUp.xaml"
            this.uname.GotFocus += new System.Windows.RoutedEventHandler(this.tb_GotFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.fname = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\signUp.xaml"
            this.fname.GotFocus += new System.Windows.RoutedEventHandler(this.tb_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.phone = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\signUp.xaml"
            this.phone.GotFocus += new System.Windows.RoutedEventHandler(this.tb_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pass = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\signUp.xaml"
            this.pass.GotFocus += new System.Windows.RoutedEventHandler(this.tb_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.pass2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\signUp.xaml"
            this.pass2.GotFocus += new System.Windows.RoutedEventHandler(this.tb_GotFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cname = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\signUp.xaml"
            this.cname.GotFocus += new System.Windows.RoutedEventHandler(this.tb_GotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.age = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\signUp.xaml"
            this.age.GotFocus += new System.Windows.RoutedEventHandler(this.tb_GotFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.location = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\signUp.xaml"
            this.location.GotFocus += new System.Windows.RoutedEventHandler(this.tb_GotFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.signBtn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\signUp.xaml"
            this.signBtn.Click += new System.Windows.RoutedEventHandler(this.signBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.loginBtn = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\signUp.xaml"
            this.loginBtn.Click += new System.Windows.RoutedEventHandler(this.loginBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.malebtn = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 12:
            this.febtn = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 13:
            this.otherbtn = ((System.Windows.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

