﻿#pragma checksum "..\..\DomaineMetierView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ECAD398012228002B68F79BFC9945E76"
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
    /// DomaineMetierView
    /// </summary>
    public partial class DomaineMetierView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\DomaineMetierView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LST_NomDomaine;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\DomaineMetierView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Ajouter;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\DomaineMetierView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TXT_NomDomaine;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\DomaineMetierView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Modifier;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\DomaineMetierView.xaml"
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
            System.Uri resourceLocater = new System.Uri("/MegaCastingsWPF;component/domainemetierview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DomaineMetierView.xaml"
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
            this.LST_NomDomaine = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.BTN_Ajouter = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\DomaineMetierView.xaml"
            this.BTN_Ajouter.Click += new System.Windows.RoutedEventHandler(this.BTN_Ajouter_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TXT_NomDomaine = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BTN_Modifier = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\DomaineMetierView.xaml"
            this.BTN_Modifier.Click += new System.Windows.RoutedEventHandler(this.BTN_Modifier_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BTN_Supprimer = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\DomaineMetierView.xaml"
            this.BTN_Supprimer.Click += new System.Windows.RoutedEventHandler(this.BTN_Supprimer_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

