﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BilingualSubtitler.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Gold")]
        public global::System.Drawing.Color FirstRussianSubtitlesColor {
            get {
                return ((global::System.Drawing.Color)(this["FirstRussianSubtitlesColor"]));
            }
            set {
                this["FirstRussianSubtitlesColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color PrimarySubtitlesColor {
            get {
                return ((global::System.Drawing.Color)(this["PrimarySubtitlesColor"]));
            }
            set {
                this["PrimarySubtitlesColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string YandexTranslatorAPIKey {
            get {
                return ((string)(this["YandexTranslatorAPIKey"]));
            }
            set {
                this["YandexTranslatorAPIKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 192, 192")]
        public global::System.Drawing.Color SecondRussianSubtitlesColor {
            get {
                return ((global::System.Drawing.Color)(this["SecondRussianSubtitlesColor"]));
            }
            set {
                this["SecondRussianSubtitlesColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Silver")]
        public global::System.Drawing.Color ThirdRussianSubtitlesColor {
            get {
                return ((global::System.Drawing.Color)(this["ThirdRussianSubtitlesColor"]));
            }
            set {
                this["ThirdRussianSubtitlesColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".eng.ass")]
        public string OriginalSubtitlesFileNameEnding {
            get {
                return ((string)(this["OriginalSubtitlesFileNameEnding"]));
            }
            set {
                this["OriginalSubtitlesFileNameEnding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".ruseng.ass")]
        public string BilingualSubtitlesFileNameEnding {
            get {
                return ((string)(this["BilingualSubtitlesFileNameEnding"]));
            }
            set {
                this["BilingualSubtitlesFileNameEnding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CreateOriginalSubtitlesFile {
            get {
                return ((bool)(this["CreateOriginalSubtitlesFile"]));
            }
            set {
                this["CreateOriginalSubtitlesFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("S@83@")]
        public string VideoPlayerChangeToBilingualSubtitlesHotkeyString {
            get {
                return ((string)(this["VideoPlayerChangeToBilingualSubtitlesHotkeyString"]));
            }
            set {
                this["VideoPlayerChangeToBilingualSubtitlesHotkeyString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("S, Shift@83@SHIFT")]
        public string VideoPlayerChangeToOriginalSubtitlesHotkeyString {
            get {
                return ((string)(this["VideoPlayerChangeToOriginalSubtitlesHotkeyString"]));
            }
            set {
                this["VideoPlayerChangeToOriginalSubtitlesHotkeyString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Space@32@")]
        public string VideoPlayerPauseButtonString {
            get {
                return ((string)(this["VideoPlayerPauseButtonString"]));
            }
            set {
                this["VideoPlayerPauseButtonString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mpc-hc64")]
        public string VideoPlayerProcessName {
            get {
                return ((string)(this["VideoPlayerProcessName"]));
            }
            set {
                this["VideoPlayerProcessName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SecondRussianSubtitlesIsVisible {
            get {
                return ((bool)(this["SecondRussianSubtitlesIsVisible"]));
            }
            set {
                this["SecondRussianSubtitlesIsVisible"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ThirdRussianSubtitlesIsVisible {
            get {
                return ((bool)(this["ThirdRussianSubtitlesIsVisible"]));
            }
            set {
                this["ThirdRussianSubtitlesIsVisible"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Arial;42;20;2;2;0;50;0")]
        public string OriginalSubtitlesStyleString {
            get {
                return ((string)(this["OriginalSubtitlesStyleString"]));
            }
            set {
                this["OriginalSubtitlesStyleString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Arial;0;20;2;2;0;50;0")]
        public string FirstRussianSubtitlesStyleString {
            get {
                return ((string)(this["FirstRussianSubtitlesStyleString"]));
            }
            set {
                this["FirstRussianSubtitlesStyleString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Arial;206;20;2;2;40;50;0")]
        public string SecondRussianSubtitlesStyleString {
            get {
                return ((string)(this["SecondRussianSubtitlesStyleString"]));
            }
            set {
                this["SecondRussianSubtitlesStyleString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Arial;248;20;2;2;40;50;0")]
        public string ThirdRussianSubtitlesStyleString {
            get {
                return ((string)(this["ThirdRussianSubtitlesStyleString"]));
            }
            set {
                this["ThirdRussianSubtitlesStyleString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ChangeRussianSubtitlesStylesAccordingToOriginal {
            get {
                return ((bool)(this["ChangeRussianSubtitlesStylesAccordingToOriginal"]));
            }
            set {
                this["ChangeRussianSubtitlesStylesAccordingToOriginal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpgradeRequired {
            get {
                return ((bool)(this["UpgradeRequired"]));
            }
            set {
                this["UpgradeRequired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool FirstLaunch {
            get {
                return ((bool)(this["FirstLaunch"]));
            }
            set {
                this["FirstLaunch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SecondAndThirdRussianSubtitlesAtTopOfTheScreen {
            get {
                return ((bool)(this["SecondAndThirdRussianSubtitlesAtTopOfTheScreen"]));
            }
            set {
                this["SecondAndThirdRussianSubtitlesAtTopOfTheScreen"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool YandexTranslatorAPIEnabled {
            get {
                return ((bool)(this["YandexTranslatorAPIEnabled"]));
            }
            set {
                this["YandexTranslatorAPIEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>NumPad0@96@</string>
  <string>Decimal@110@</string>
  <string>Return@13@</string>
  <string>F3@114@</string>
  <string>Space@32@</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection Hotkeys {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Hotkeys"]));
            }
            set {
                this["Hotkeys"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SecondAndThirdRussianSubtitlesAtTopOfTheScreenEnabled {
            get {
                return ((bool)(this["SecondAndThirdRussianSubtitlesAtTopOfTheScreenEnabled"]));
            }
            set {
                this["SecondAndThirdRussianSubtitlesAtTopOfTheScreenEnabled"] = value;
            }
        }
    }
}
