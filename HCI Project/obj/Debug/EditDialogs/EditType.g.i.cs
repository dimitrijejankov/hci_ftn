﻿#pragma checksum "..\..\..\EditDialogs\EditType.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "48C9A32EDAEA296D161D6F64AFE1A94B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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


namespace HCI_Project.EditDialogs {
    
    
    /// <summary>
    /// EditType
    /// </summary>
    public partial class EditType : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\EditDialogs\EditType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lista;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\EditDialogs\EditType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBox;
        
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
            System.Uri resourceLocater = new System.Uri("/HCI Project;component/editdialogs/edittype.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EditDialogs\EditType.xaml"
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
            this.lista = ((System.Windows.Controls.ListView)(target));
            
            #line 6 "..\..\..\EditDialogs\EditType.xaml"
            this.lista.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListMouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.searchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\EditDialogs\EditType.xaml"
            this.searchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextChanged);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\EditDialogs\EditType.xaml"
            this.searchBox.GotFocus += new System.Windows.RoutedEventHandler(this.SearchGotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 25 "..\..\..\EditDialogs\EditType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OkButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 26 "..\..\..\EditDialogs\EditType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddButtonClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 27 "..\..\..\EditDialogs\EditType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

