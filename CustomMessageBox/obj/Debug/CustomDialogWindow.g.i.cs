﻿#pragma checksum "..\..\CustomDialogWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "898C3DAB3DA3D7EF6CCC6626DA444CDA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IQ.Core.Common.Localization.Markup;
using IQ.Core.Common.Markup;
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


namespace CustomMessageBox {
    
    
    /// <summary>
    /// CustomDialogWindow
    /// </summary>
    public partial class CustomDialogWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\CustomDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgInstructionIcon;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\CustomDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbInstructionHeading;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\CustomDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbInstructionText;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\CustomDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbAdditionalDetailsText;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\CustomDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton expAdditionalDetails;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\CustomDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnYes;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\CustomDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOK;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\CustomDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\CustomDialogWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNo;
        
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
            System.Uri resourceLocater = new System.Uri("/CustomMessageBox;component/customdialogwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CustomDialogWindow.xaml"
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
            this.imgInstructionIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.tbInstructionHeading = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.tbInstructionText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.tbAdditionalDetailsText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.expAdditionalDetails = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 96 "..\..\CustomDialogWindow.xaml"
            this.expAdditionalDetails.Click += new System.Windows.RoutedEventHandler(this.ExpAdditionalDetailsClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnYes = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\CustomDialogWindow.xaml"
            this.btnYes.Click += new System.Windows.RoutedEventHandler(this.BtnYesClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnOK = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\CustomDialogWindow.xaml"
            this.btnOK.Click += new System.Windows.RoutedEventHandler(this.BtnOkClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\CustomDialogWindow.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancelClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnNo = ((System.Windows.Controls.Button)(target));
            
            #line 135 "..\..\CustomDialogWindow.xaml"
            this.btnNo.Click += new System.Windows.RoutedEventHandler(this.BtnNoClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

