﻿#pragma checksum "..\..\AddMonument.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5613CE784597B16CE5507908BFBD860D41AE6906"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
using WpfApp11;


namespace WpfApp11 {
    
    
    /// <summary>
    /// AddMonument
    /// </summary>
    public partial class AddMonument : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\AddMonument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CountryTextBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AddMonument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CityTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\AddMonument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MonumentTextBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\AddMonument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ImageTextBox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\AddMonument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GoogleMapsLinkTextBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\AddMonument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\AddMonument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Browse;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp11;component/addmonument.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddMonument.xaml"
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
            this.CountryTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\AddMonument.xaml"
            this.CountryTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CountryTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 15 "..\..\AddMonument.xaml"
            this.CountryTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.CountryTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CityTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\AddMonument.xaml"
            this.CityTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CityTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 28 "..\..\AddMonument.xaml"
            this.CityTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.CityTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MonumentTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\AddMonument.xaml"
            this.MonumentTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.MonumentTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 41 "..\..\AddMonument.xaml"
            this.MonumentTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.MonumentTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ImageTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\AddMonument.xaml"
            this.ImageTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ImageTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GoogleMapsLinkTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\AddMonument.xaml"
            this.GoogleMapsLinkTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.GoogleMapsLinkTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\AddMonument.xaml"
            this.DescriptionTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.DescriptionComboBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 59 "..\..\AddMonument.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Browse = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\AddMonument.xaml"
            this.Browse.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
