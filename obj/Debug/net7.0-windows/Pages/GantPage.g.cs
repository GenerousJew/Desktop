﻿#pragma checksum "..\..\..\..\Pages\GantPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E1E3F9E54B50CD0311740132F618A56666A18FFB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using NewDesktop.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace NewDesktop.Pages {
    
    
    /// <summary>
    /// GantPage
    /// </summary>
    public partial class GantPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Pages\GantPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider MarginSlider;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Pages\GantPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TimeBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Pages\GantPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TimeRange;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Pages\GantPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GantGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NewDesktop;component/pages/gantpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\GantPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MarginSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 13 "..\..\..\..\Pages\GantPage.xaml"
            this.MarginSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.MarginChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TimeBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\..\..\Pages\GantPage.xaml"
            this.TimeBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TimeBoxSelected);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\..\..\Pages\GantPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LeftCLick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TimeRange = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            
            #line 17 "..\..\..\..\Pages\GantPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RightClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 18 "..\..\..\..\Pages\GantPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ImportCLick);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 19 "..\..\..\..\Pages\GantPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.GantGrid = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
