﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PS3DumpChecker.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PS3DumpChecker.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: Filesize don&apos;t match expected size from the configuration! Please doublecheck your image and configuration!.
        /// </summary>
        internal static string badsize {
            get {
                return ResourceManager.GetString("badsize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR - Bad dump.
        /// </summary>
        internal static string Checks_StartCheck_ERROR___Bad_dump {
            get {
                return ResourceManager.GetString("Checks_StartCheck_ERROR___Bad_dump", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration files|*.cfg|All Files|*.*.
        /// </summary>
        internal static string conf_filter {
            get {
                return ResourceManager.GetString("conf_filter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR - Bad Size.
        /// </summary>
        internal static string error_bad_size {
            get {
                return ResourceManager.GetString("error_bad_size", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: No configuration loaded!.
        /// </summary>
        internal static string error_noconfig {
            get {
                return ResourceManager.GetString("error_noconfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR - No config!.
        /// </summary>
        internal static string error_noconfig_title {
            get {
                return ResourceManager.GetString("error_noconfig_title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon logo {
            get {
                object obj = ResourceManager.GetObject("logo", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to N/A.
        /// </summary>
        internal static string N_A {
            get {
                return ResourceManager.GetString("N_A", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Binary Files|*.bin|All Files|*.*.
        /// </summary>
        internal static string ofdfilter {
            get {
                return ResourceManager.GetString("ofdfilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select Dump to check.
        /// </summary>
        internal static string seldump {
            get {
                return ResourceManager.GetString("seldump", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select configuration file to load.
        /// </summary>
        internal static string select_conf {
            get {
                return ResourceManager.GetString("select_conf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WARNING!.
        /// </summary>
        internal static string WARNING {
            get {
                return ResourceManager.GetString("WARNING", resourceCulture);
            }
        }
    }
}
