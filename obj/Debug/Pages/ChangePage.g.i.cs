// Updated by XamlIntelliSenseFileGenerator 22.11.2021 17:39:45
#pragma checksum "..\..\..\Pages\ChangePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4E63EB569CD12E2121CAFAFC81002876CD9AC4C902256649D7C6233BCE1DB286"
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


namespace WPF_SQL
{


    /// <summary>
    /// ChangePage
    /// </summary>
    public partial class ChangePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 13 "..\..\..\Pages\ChangePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LAdd;

#line default
#line hidden


#line 14 "..\..\..\Pages\ChangePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Maintable;

#line default
#line hidden


#line 23 "..\..\..\Pages\ChangePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lback;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_SQL;component/pages/changepage.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Pages\ChangePage.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.LAdd = ((System.Windows.Controls.Label)(target));

#line 13 "..\..\..\Pages\ChangePage.xaml"
                    this.LAdd.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.AddUser);

#line default
#line hidden
                    return;
                case 2:
                    this.Maintable = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 3:
                    this.Lback = ((System.Windows.Controls.Label)(target));

#line 23 "..\..\..\Pages\ChangePage.xaml"
                    this.Lback.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Lback_MouseLeftButtonUp);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Label LDelete;
    }
}

