﻿#pragma checksum "..\..\..\Pages\UsersCab.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5294786F4C78D54E6BE2CAE99D8CAD795D294441041347232FC7481D672CCDC9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
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
using WPF_SQL;


namespace WPF_SQL {
    
    
    /// <summary>
    /// UsersCab
    /// </summary>
    public partial class UsersCab : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Pages\UsersCab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderMain;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Pages\UsersCab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image IUserPhoto;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Pages\UsersCab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BChagePhoto;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Pages\UsersCab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBLOCKFIO;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Pages\UsersCab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBLOCKlogin;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Pages\UsersCab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBLOCKrole;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Pages\UsersCab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBLOCKGender;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_SQL;component/pages/userscab.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\UsersCab.xaml"
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
            this.BorderMain = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            
            #line 35 "..\..\..\Pages\UsersCab.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 36 "..\..\..\Pages\UsersCab.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 38 "..\..\..\Pages\UsersCab.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_2);
            
            #line default
            #line hidden
            return;
            case 5:
            this.IUserPhoto = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.BChagePhoto = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\Pages\UsersCab.xaml"
            this.BChagePhoto.Click += new System.Windows.RoutedEventHandler(this.BChagePhoto_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TBLOCKFIO = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.TBLOCKlogin = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.TBLOCKrole = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.TBLOCKGender = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

