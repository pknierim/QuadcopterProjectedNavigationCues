﻿#pragma checksum "..\..\Settings.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E442AC58E6A52E4B3E2F012A48C606A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NaviControl;
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


namespace NaviControl {
    
    
    /// <summary>
    /// Settings
    /// </summary>
    public partial class Settings : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_return;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_setPhone;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_setBeamer;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_beamer;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_phone;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
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
            System.Uri resourceLocater = new System.Uri("/NaviControl;component/settings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Settings.xaml"
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
            this.b_return = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Settings.xaml"
            this.b_return.Click += new System.Windows.RoutedEventHandler(this.b_return_Click);
            
            #line default
            #line hidden
            
            #line 10 "..\..\Settings.xaml"
            this.b_return.TouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.b_return_TouchDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.b_setPhone = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Settings.xaml"
            this.b_setPhone.Click += new System.Windows.RoutedEventHandler(this.b_setPhone_Click);
            
            #line default
            #line hidden
            
            #line 11 "..\..\Settings.xaml"
            this.b_setPhone.TouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.b_setPhone_TouchDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.b_setBeamer = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Settings.xaml"
            this.b_setBeamer.Click += new System.Windows.RoutedEventHandler(this.b_setBeamer_Click);
            
            #line default
            #line hidden
            
            #line 12 "..\..\Settings.xaml"
            this.b_setBeamer.TouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.b_setBeamer_TouchDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tb_beamer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tb_phone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

