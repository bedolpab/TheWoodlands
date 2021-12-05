﻿#pragma checksum "..\..\Customize.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F9727FFCF213DA017A994447D214B74EED009F1DA3BA4ADE839826337B12F53D"
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
using TheWoodlands;


namespace TheWoodlands {
    
    
    /// <summary>
    /// Customize
    /// </summary>
    public partial class Customize : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\Customize.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CustomizeTitle;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Customize.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CustomizeTextBoxWarning;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Customize.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Fair;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Customize.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Light;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Customize.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Medium;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Customize.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Tan;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Customize.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Deep;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Customize.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Avatar;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Customize.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CustomizeContinueButton;
        
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
            System.Uri resourceLocater = new System.Uri("/TheWoodlands;component/customize.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Customize.xaml"
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
            this.CustomizeTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.CustomizeTextBoxWarning = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Fair = ((System.Windows.Controls.RadioButton)(target));
            
            #line 27 "..\..\Customize.xaml"
            this.Fair.Checked += new System.Windows.RoutedEventHandler(this.Fair_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Light = ((System.Windows.Controls.RadioButton)(target));
            
            #line 28 "..\..\Customize.xaml"
            this.Light.Checked += new System.Windows.RoutedEventHandler(this.Light_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Medium = ((System.Windows.Controls.RadioButton)(target));
            
            #line 29 "..\..\Customize.xaml"
            this.Medium.Checked += new System.Windows.RoutedEventHandler(this.Medium_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Tan = ((System.Windows.Controls.RadioButton)(target));
            
            #line 30 "..\..\Customize.xaml"
            this.Tan.Checked += new System.Windows.RoutedEventHandler(this.Tan_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Deep = ((System.Windows.Controls.RadioButton)(target));
            
            #line 31 "..\..\Customize.xaml"
            this.Deep.Checked += new System.Windows.RoutedEventHandler(this.Deep_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Avatar = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.CustomizeContinueButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\Customize.xaml"
            this.CustomizeContinueButton.Click += new System.Windows.RoutedEventHandler(this.CustomizeContinueButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
