﻿#pragma checksum "..\..\..\Views\ModificaCamin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "988BBFD3E327658088DB6DBD01013B982D4B0BAB3B494AAAC13BE0C4CBE5777A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AplicatieCamin.ViewModels;
using AplicatieCamin.Views;
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


namespace AplicatieCamin.Views {
    
    
    /// <summary>
    /// ModificaCamin
    /// </summary>
    public partial class ModificaCamin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Views\ModificaCamin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumarCamin;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\ModificaCamin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TaxaCamin;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\ModificaCamin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/AplicatieCamin;component/views/modificacamin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ModificaCamin.xaml"
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
            this.NumarCamin = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\Views\ModificaCamin.xaml"
            this.NumarCamin.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumarCamin_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TaxaCamin = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\Views\ModificaCamin.xaml"
            this.TaxaCamin.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TaxaCamin_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Views\ModificaCamin.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

