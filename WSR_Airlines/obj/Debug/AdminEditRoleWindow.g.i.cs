#pragma checksum "..\..\AdminEditRoleWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0B43549178CB0E99991D82626FE56657873ED497DCABFE5CF4D7EF865275EF36"
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
using WSR_Airlines;


namespace WSR_Airlines {
    
    
    /// <summary>
    /// AdminEditRoleWindow
    /// </summary>
    public partial class AdminEditRoleWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\AdminEditRoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailTB;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AdminEditRoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstnameTB;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\AdminEditRoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lastnameTB;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\AdminEditRoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox officeCB;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\AdminEditRoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel RadioStack;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\AdminEditRoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Admin;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\AdminEditRoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton User;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\AdminEditRoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveBTN;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\AdminEditRoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelBTN;
        
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
            System.Uri resourceLocater = new System.Uri("/WSR_Airlines;component/admineditrolewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminEditRoleWindow.xaml"
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
            this.emailTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.firstnameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.lastnameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.officeCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.RadioStack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.Admin = ((System.Windows.Controls.RadioButton)(target));
            
            #line 47 "..\..\AdminEditRoleWindow.xaml"
            this.Admin.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.User = ((System.Windows.Controls.RadioButton)(target));
            
            #line 49 "..\..\AdminEditRoleWindow.xaml"
            this.User.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.saveBTN = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\AdminEditRoleWindow.xaml"
            this.saveBTN.Click += new System.Windows.RoutedEventHandler(this.saveBTN_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cancelBTN = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\AdminEditRoleWindow.xaml"
            this.cancelBTN.Click += new System.Windows.RoutedEventHandler(this.cancelBTN_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

