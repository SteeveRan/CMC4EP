﻿#pragma checksum "..\..\Left_Panel_main_menu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "65ECCBB2621F66329CED842136870729"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34209
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace Ctrl {
    
    
    /// <summary>
    /// Left_Panel_main_menu
    /// </summary>
    public partial class Left_Panel_main_menu : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 638 "..\..\Left_Panel_main_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Play_button;
        
        #line default
        #line hidden
        
        
        #line 651 "..\..\Left_Panel_main_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chat_button;
        
        #line default
        #line hidden
        
        
        #line 654 "..\..\Left_Panel_main_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Friends_button;
        
        #line default
        #line hidden
        
        
        #line 657 "..\..\Left_Panel_main_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Search_button;
        
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
            System.Uri resourceLocater = new System.Uri("/Ctrl_lib;component/left_panel_main_menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Left_Panel_main_menu.xaml"
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
            this.Play_button = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.Chat_button = ((System.Windows.Controls.Button)(target));
            
            #line 651 "..\..\Left_Panel_main_menu.xaml"
            this.Chat_button.Click += new System.Windows.RoutedEventHandler(this.Chat_button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Friends_button = ((System.Windows.Controls.Button)(target));
            
            #line 654 "..\..\Left_Panel_main_menu.xaml"
            this.Friends_button.Click += new System.Windows.RoutedEventHandler(this.Friends_button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Search_button = ((System.Windows.Controls.Button)(target));
            
            #line 657 "..\..\Left_Panel_main_menu.xaml"
            this.Search_button.Click += new System.Windows.RoutedEventHandler(this.Search_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

