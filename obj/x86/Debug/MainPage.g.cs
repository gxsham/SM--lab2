﻿#pragma checksum "C:\Users\gxsham\documents\visual studio 2015\Projects\SoundManipulation\SoundManipulation\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7B5D132E8C267F7F096436232A8B8074"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoundManipulation
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Volume1 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 80 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.Volume1).ValueChanged += this.Volume1_ValueChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.Volume2 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 81 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.Volume2).ValueChanged += this.Volume2_ValueChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.Progress1 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 61 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.Progress1).ValueChanged += this.Progress1_ValueChanged;
                    #line default
                }
                break;
            case 4:
                {
                    this.Progress2 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 72 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.Progress2).ValueChanged += this.Progress2_ValueChanged;
                    #line default
                }
                break;
            case 5:
                {
                    this.Pause2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 68 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Pause2).Click += this.Pause2_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.Play2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 69 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Play2).Click += this.Play2_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.Stop3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 70 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Stop3).Click += this.Stop3_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.Pause1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 57 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Pause1).Click += this.Pause1_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.Play1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 58 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Play1).Click += this.Play1_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.Stop1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 59 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Stop1).Click += this.Stop1_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.Speed1 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 39 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.Speed1).ValueChanged += this.Speed1_ValueChanged;
                    #line default
                }
                break;
            case 12:
                {
                    this.Speed2 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 40 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.Speed2).ValueChanged += this.Speed2_ValueChanged;
                    #line default
                }
                break;
            case 13:
                {
                    this.Balance1 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 41 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.Balance1).ValueChanged += this.Balance1_ValueChanged;
                    #line default
                }
                break;
            case 14:
                {
                    this.Balance2 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 42 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.Balance2).ValueChanged += this.Balance2_ValueChanged;
                    #line default
                }
                break;
            case 15:
                {
                    this.mediaElement1 = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 16:
                {
                    this.mediaElement2 = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 17:
                {
                    this.Metronome1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Metronome1).Click += this.Metronome1_Click;
                    #line default
                }
                break;
            case 18:
                {
                    this.Metronome2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 27 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Metronome2).Click += this.Metronome2_Click;
                    #line default
                }
                break;
            case 19:
                {
                    this.Open1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 28 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Open1).Click += this.Open1_Click;
                    #line default
                }
                break;
            case 20:
                {
                    this.Open2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Open2).Click += this.Open2_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

