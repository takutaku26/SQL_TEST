﻿#pragma checksum "..\..\StudentInfoRegist.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2D69E0CDA1A784E67C6440B7E90767BADF4E8BA498B0344BA210D2268A97E7CE"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

using SuperChat;
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


namespace SuperChat {
    
    
    /// <summary>
    /// StudentInfoRegist
    /// </summary>
    public partial class StudentInfoRegist : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\StudentInfoRegist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_name;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\StudentInfoRegist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_gender;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\StudentInfoRegist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_age;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\StudentInfoRegist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_course;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\StudentInfoRegist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cansel;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\StudentInfoRegist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_add;
        
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
            System.Uri resourceLocater = new System.Uri("/SuperChat;component/studentinforegist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StudentInfoRegist.xaml"
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
            this.txt_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cmb_gender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.txt_age = ((System.Windows.Controls.TextBox)(target));
            
            #line 82 "..\..\StudentInfoRegist.xaml"
            this.txt_age.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.textBoxPrice_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 83 "..\..\StudentInfoRegist.xaml"
            this.txt_age.AddHandler(System.Windows.Input.CommandManager.PreviewExecutedEvent, new System.Windows.Input.ExecutedRoutedEventHandler(this.textBoxPrice_PreviewExecuted));
            
            #line default
            #line hidden
            return;
            case 4:
            this.txt_course = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btn_cansel = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\StudentInfoRegist.xaml"
            this.btn_cansel.Click += new System.Windows.RoutedEventHandler(this.btn_cansel_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_add = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\StudentInfoRegist.xaml"
            this.btn_add.Click += new System.Windows.RoutedEventHandler(this.btn_add_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

