﻿#pragma checksum "..\..\..\ScrumBoard\ScrumBoardPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8496E7F09BB8D675DA45D36FED9113EF"
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
using TrabalhoLP2.ScrumBoard;


namespace TrabalhoLP2.ScrumBoard {
    
    
    /// <summary>
    /// ScrumBoardPage
    /// </summary>
    public partial class ScrumBoardPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\ScrumBoard\ScrumBoardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Utilizadores;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\ScrumBoard\ScrumBoardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Stack;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\ScrumBoard\ScrumBoardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NomeNovoUtilizador;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\ScrumBoard\ScrumBoardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpcaoCriar;
        
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
            System.Uri resourceLocater = new System.Uri("/TrabalhoLP2;component/scrumboard/scrumboardpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ScrumBoard\ScrumBoardPage.xaml"
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
            this.Utilizadores = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Stack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            
            #line 34 "..\..\..\ScrumBoard\ScrumBoardPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CriarUtilizador_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NomeNovoUtilizador = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.OpcaoCriar = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\ScrumBoard\ScrumBoardPage.xaml"
            this.OpcaoCriar.Click += new System.Windows.RoutedEventHandler(this.Criacao_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

