﻿#pragma checksum "..\..\WindowFuncionario.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F1EEDF598641E562012EF0A0A03C7BF5FD40CC25"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
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
using projetoPizzaria;


namespace projetoPizzaria {
    
    
    /// <summary>
    /// WindowFuncionario
    /// </summary>
    public partial class WindowFuncionario : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\WindowFuncionario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idFuncionario;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\WindowFuncionario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nomeFuncionario;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\WindowFuncionario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox senhaFuncionario;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\WindowFuncionario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button insert;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\WindowFuncionario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button update;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\WindowFuncionario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\WindowFuncionario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button confirmar;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\WindowFuncionario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button voltar;
        
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
            System.Uri resourceLocater = new System.Uri("/projetoPizzaria;component/windowfuncionario.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowFuncionario.xaml"
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
            this.idFuncionario = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\WindowFuncionario.xaml"
            this.idFuncionario.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.nomeFuncionario = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.senhaFuncionario = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\WindowFuncionario.xaml"
            this.senhaFuncionario.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.insert = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.update = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.delete = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\WindowFuncionario.xaml"
            this.delete.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.confirmar = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.voltar = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

