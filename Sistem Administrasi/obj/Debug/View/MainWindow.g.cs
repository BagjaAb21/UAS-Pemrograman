#pragma checksum "..\..\..\View\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B26AF6F868F404B0ACC5B87AD88753E7DAE0344FDB18A6A69C8EF6F0C7C67F8E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Sistem_Administrasi.View;
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


namespace Sistem_Administrasi.View {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 108 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel btnAntrean;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel btnRiwayat;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border btnProfile;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageProfile;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblProfile;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvasProfile;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAkun;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLogout;
        
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
            System.Uri resourceLocater = new System.Uri("/Sistem Administrasi;component/view/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\MainWindow.xaml"
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
            this.btnAntrean = ((System.Windows.Controls.DockPanel)(target));
            
            #line 111 "..\..\..\View\MainWindow.xaml"
            this.btnAntrean.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btnAntrean_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnRiwayat = ((System.Windows.Controls.DockPanel)(target));
            
            #line 121 "..\..\..\View\MainWindow.xaml"
            this.btnRiwayat.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btnRiwayat_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnProfile = ((System.Windows.Controls.Border)(target));
            
            #line 133 "..\..\..\View\MainWindow.xaml"
            this.btnProfile.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.btnProfile_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ImageProfile = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.lblProfile = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Main = ((System.Windows.Controls.Frame)(target));
            return;
            case 7:
            this.canvasProfile = ((System.Windows.Controls.Canvas)(target));
            return;
            case 8:
            this.lblAkun = ((System.Windows.Controls.Label)(target));
            
            #line 189 "..\..\..\View\MainWindow.xaml"
            this.lblAkun.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lblAkun_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lblLogout = ((System.Windows.Controls.Label)(target));
            
            #line 197 "..\..\..\View\MainWindow.xaml"
            this.lblLogout.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lblLogout_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

