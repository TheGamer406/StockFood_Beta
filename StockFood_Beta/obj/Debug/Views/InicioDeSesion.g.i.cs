﻿#pragma checksum "..\..\..\Views\InicioDeSesion.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DCBEF8E4E68CEAA82C8E55644DAF7DBD623B7E63DC919CC15E6427D1B719DA36"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using StockFood_Beta.Views;
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


namespace StockFood_Beta.Views {
    
    
    /// <summary>
    /// InicioDeSesion
    /// </summary>
    public partial class InicioDeSesion : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\Views\InicioDeSesion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMinimizar;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Views\InicioDeSesion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCerrar;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\Views\InicioDeSesion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtUsuario;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\Views\InicioDeSesion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtContraseña;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\Views\InicioDeSesion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnIniciarSesion;
        
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
            System.Uri resourceLocater = new System.Uri("/StockFood_Beta;component/views/iniciodesesion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\InicioDeSesion.xaml"
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
            
            #line 14 "..\..\..\Views\InicioDeSesion.xaml"
            ((StockFood_Beta.Views.InicioDeSesion)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnMinimizar = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\Views\InicioDeSesion.xaml"
            this.BtnMinimizar.Click += new System.Windows.RoutedEventHandler(this.BtnMinimizar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnCerrar = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\Views\InicioDeSesion.xaml"
            this.BtnCerrar.Click += new System.Windows.RoutedEventHandler(this.BtnCerrar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TxtUsuario = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtContraseña = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.BtnIniciarSesion = ((System.Windows.Controls.Button)(target));
            
            #line 193 "..\..\..\Views\InicioDeSesion.xaml"
            this.BtnIniciarSesion.Click += new System.Windows.RoutedEventHandler(this.BtnIniciarSesion_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

