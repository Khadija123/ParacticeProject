﻿#pragma checksum "..\..\..\Pages\frmBookingDashboard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "36F80D55EAB19BF5D41CA551924A496E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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


namespace Presentations.Pages {
    
    
    /// <summary>
    /// frmBookingDashboard
    /// </summary>
    public partial class frmBookingDashboard : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\Pages\frmBookingDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnpatientregistration;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\frmBookingDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnschedule;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Pages\frmBookingDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnbooking;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Pages\frmBookingDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnlogout;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Pages\frmBookingDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnviewpatient;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Pages\frmBookingDashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnviewbooking;
        
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
            System.Uri resourceLocater = new System.Uri("/Presentations;component/pages/frmbookingdashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\frmBookingDashboard.xaml"
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
            this.btnpatientregistration = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Pages\frmBookingDashboard.xaml"
            this.btnpatientregistration.Click += new System.Windows.RoutedEventHandler(this.btnpatientregistration_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnschedule = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Pages\frmBookingDashboard.xaml"
            this.btnschedule.Click += new System.Windows.RoutedEventHandler(this.btnschedule_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnbooking = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\Pages\frmBookingDashboard.xaml"
            this.btnbooking.Click += new System.Windows.RoutedEventHandler(this.btnbooking_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnlogout = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\Pages\frmBookingDashboard.xaml"
            this.btnlogout.Click += new System.Windows.RoutedEventHandler(this.btnlogout_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnviewpatient = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\Pages\frmBookingDashboard.xaml"
            this.btnviewpatient.Click += new System.Windows.RoutedEventHandler(this.btnviewpatient_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnviewbooking = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

