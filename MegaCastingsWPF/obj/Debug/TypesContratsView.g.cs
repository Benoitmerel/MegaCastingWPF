﻿#pragma checksum "..\..\TypesContratsView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DA71BC376024AA1B90B0910F95CECB08"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MegaCastingsWPF;
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


namespace MegaCastingsWPF {
    
    
    /// <summary>
    /// TypesContratsView
    /// </summary>
    public partial class TypesContratsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\TypesContratsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LST_Contrat;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\TypesContratsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Ajouter;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\TypesContratsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TXT_NomContrat;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\TypesContratsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Modifier;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\TypesContratsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Supprimer;
        
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
            System.Uri resourceLocater = new System.Uri("/MegaCastingsWPF;component/typescontratsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TypesContratsView.xaml"
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
            this.LST_Contrat = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.BTN_Ajouter = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\TypesContratsView.xaml"
            this.BTN_Ajouter.Click += new System.Windows.RoutedEventHandler(this.BTN_Ajouter_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TXT_NomContrat = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BTN_Modifier = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\TypesContratsView.xaml"
            this.BTN_Modifier.Click += new System.Windows.RoutedEventHandler(this.BTN_Modifier_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BTN_Supprimer = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\TypesContratsView.xaml"
            this.BTN_Supprimer.Click += new System.Windows.RoutedEventHandler(this.BTN_Supprimer_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

