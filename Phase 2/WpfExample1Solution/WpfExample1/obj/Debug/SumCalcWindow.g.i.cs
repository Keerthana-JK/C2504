﻿#pragma checksum "..\..\SumCalcWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DE2BE4F164C0DDA02F63629799A936202521B6FBFBC00D8B6CE955485533793F"
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
using WpfExample1;


namespace WpfExample1 {
    
    
    /// <summary>
    /// SumCalcWindow
    /// </summary>
    public partial class SumCalcWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\SumCalcWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblNumber1;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\SumCalcWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblNumber2;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\SumCalcWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblSum;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\SumCalcWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumber1;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\SumCalcWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumber2;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\SumCalcWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSum;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\SumCalcWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFindSum;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfExample1;component/sumcalcwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SumCalcWindow.xaml"
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
            this.lblNumber1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.lblNumber2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.lblSum = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.txtNumber1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtNumber2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtSum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnFindSum = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\SumCalcWindow.xaml"
            this.btnFindSum.Click += new System.Windows.RoutedEventHandler(this.btnFindSum_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

