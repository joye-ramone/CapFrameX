﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapFrameX.Configuration.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("40")]
        public int MovingAverageWindowSize {
            get {
                return ((int)(this["MovingAverageWindowSize"]));
            }
            set {
                this["MovingAverageWindowSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2.5")]
        public double StutteringFactor {
            get {
                return ((double)(this["StutteringFactor"]));
            }
            set {
                this["StutteringFactor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MyDocuments\\CapFrameX\\Captures")]
        public string ObservedDirectory {
            get {
                return ((string)(this["ObservedDirectory"]));
            }
            set {
                this["ObservedDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int FpsValuesRoundingDigits {
            get {
                return ((int)(this["FpsValuesRoundingDigits"]));
            }
            set {
                this["FpsValuesRoundingDigits"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowLowParameter {
            get {
                return ((bool)(this["ShowLowParameter"]));
            }
            set {
                this["ShowLowParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MyDocuments\\CapFrameX\\Screenshots")]
        public string ScreenshotDirectory {
            get {
                return ((string)(this["ScreenshotDirectory"]));
            }
            set {
                this["ScreenshotDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseSingleRecordMaxStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordMaxStatisticParameter"]));
            }
            set {
                this["UseSingleRecordMaxStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseSingleRecordP99QuantileStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP99QuantileStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP99QuantileStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordP95QuantileStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP95QuantileStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP95QuantileStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordAverageStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordAverageStatisticParameter"]));
            }
            set {
                this["UseSingleRecordAverageStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordP5QuantileStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP5QuantileStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP5QuantileStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordP1QuantileStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP1QuantileStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP1QuantileStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseSingleRecordP0Dot1QuantileStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP0Dot1QuantileStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP0Dot1QuantileStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseSingleRecordP1LowAverageStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP1LowAverageStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP1LowAverageStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseSingleRecordP0Dot1LowAverageStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP0Dot1LowAverageStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP0Dot1LowAverageStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseSingleRecordMinStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordMinStatisticParameter"]));
            }
            set {
                this["UseSingleRecordMinStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordAdaptiveSTDStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordAdaptiveSTDStatisticParameter"]));
            }
            set {
                this["UseSingleRecordAdaptiveSTDStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("F12")]
        public string CaptureHotKey {
            get {
                return ((string)(this["CaptureHotKey"]));
            }
            set {
                this["CaptureHotKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("voice response")]
        public string HotkeySoundMode {
            get {
                return ((string)(this["HotkeySoundMode"]));
            }
            set {
                this["HotkeySoundMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int CaptureTime {
            get {
                return ((int)(this["CaptureTime"]));
            }
            set {
                this["CaptureTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSingleRecordP0Dot2QuantileStatisticParameter {
            get {
                return ((bool)(this["UseSingleRecordP0Dot2QuantileStatisticParameter"]));
            }
            set {
                this["UseSingleRecordP0Dot2QuantileStatisticParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.25")]
        public double VoiceSoundLevel {
            get {
                return ((double)(this["VoiceSoundLevel"]));
            }
            set {
                this["VoiceSoundLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.5")]
        public double SimpleSoundLevel {
            get {
                return ((double)(this["SimpleSoundLevel"]));
            }
            set {
                this["SimpleSoundLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P1")]
        public string SecondMetric {
            get {
                return ((string)(this["SecondMetric"]));
            }
            set {
                this["SecondMetric"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P0dot2")]
        public string ThirdMetric {
            get {
                return ((string)(this["ThirdMetric"]));
            }
            set {
                this["ThirdMetric"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DateTime")]
        public string ComparisonContext {
            get {
                return ((string)(this["ComparisonContext"]));
            }
            set {
                this["ComparisonContext"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GameName")]
        public string RecordingListSortMemberPath {
            get {
                return ((string)(this["RecordingListSortMemberPath"]));
            }
            set {
                this["RecordingListSortMemberPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ascending")]
        public string RecordingListSortDirection {
            get {
                return ((string)(this["RecordingListSortDirection"]));
            }
            set {
                this["RecordingListSortDirection"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("40")]
        public string SyncRangeLower {
            get {
                return ((string)(this["SyncRangeLower"]));
            }
            set {
                this["SyncRangeLower"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("120")]
        public string SyncRangeUpper {
            get {
                return ((string)(this["SyncRangeUpper"]));
            }
            set {
                this["SyncRangeUpper"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowOutlierWarning {
            get {
                return ((bool)(this["ShowOutlierWarning"]));
            }
            set {
                this["ShowOutlierWarning"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Auto")]
        public string HardwareInfoSource {
            get {
                return ((string)(this["HardwareInfoSource"]));
            }
            set {
                this["HardwareInfoSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CPU")]
        public string CustomCpuDescription {
            get {
                return ((string)(this["CustomCpuDescription"]));
            }
            set {
                this["CustomCpuDescription"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GPU")]
        public string CustomGpuDescription {
            get {
                return ((string)(this["CustomGpuDescription"]));
            }
            set {
                this["CustomGpuDescription"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("RAM")]
        public string CustomRamDescription {
            get {
                return ((string)(this["CustomRamDescription"]));
            }
            set {
                this["CustomRamDescription"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Alt+O")]
        public string OverlayHotKey {
            get {
                return ((string)(this["OverlayHotKey"]));
            }
            set {
                this["OverlayHotKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsOverlayActive {
            get {
                return ((bool)(this["IsOverlayActive"]));
            }
            set {
                this["IsOverlayActive"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Alt+R")]
        public string ResetHistoryHotkey {
            get {
                return ((string)(this["ResetHistoryHotkey"]));
            }
            set {
                this["ResetHistoryHotkey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseRunHistory {
            get {
                return ((bool)(this["UseRunHistory"]));
            }
            set {
                this["UseRunHistory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P1")]
        public string SecondMetricOverlay {
            get {
                return ((string)(this["SecondMetricOverlay"]));
            }
            set {
                this["SecondMetricOverlay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P0dot2")]
        public string ThirdMetricOverlay {
            get {
                return ((string)(this["ThirdMetricOverlay"]));
            }
            set {
                this["ThirdMetricOverlay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseAggregation {
            get {
                return ((bool)(this["UseAggregation"]));
            }
            set {
                this["UseAggregation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int SelectedHistoryRuns {
            get {
                return ((int)(this["SelectedHistoryRuns"]));
            }
            set {
                this["SelectedHistoryRuns"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int SelectedAggregationRuns {
            get {
                return ((int)(this["SelectedAggregationRuns"]));
            }
            set {
                this["SelectedAggregationRuns"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("500")]
        public int OSDRefreshPeriod {
            get {
                return ((int)(this["OSDRefreshPeriod"]));
            }
            set {
                this["OSDRefreshPeriod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool KeepRecordFiles {
            get {
                return ((bool)(this["KeepRecordFiles"]));
            }
            set {
                this["KeepRecordFiles"] = value;
            }
        }
    }
}
