﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FSV.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ShareReportTourResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ShareReportTourResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FSV.Resources.ShareReportTourResource", typeof(ShareReportTourResource).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Click here to view list of computers available in a domain..
        /// </summary>
        public static string AdBrowserButton {
            get {
                return ResourceManager.GetString("AdBrowserButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select a computer from this domain..
        /// </summary>
        public static string AdBrowserComputerSelection {
            get {
                return ResourceManager.GetString("AdBrowserComputerSelection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Or you can scan your network for Windows computers..
        /// </summary>
        public static string ScanNetworkButton {
            get {
                return ResourceManager.GetString("ScanNetworkButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It shows a list of servers and their shares. Clicking on server or a share opens a share report. You can also start generating a permission report from here..
        /// </summary>
        public static string ServersList {
            get {
                return ResourceManager.GetString("ServersList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify server name. If there are several servers, you can specify them by comma or semicolon.
        /// </summary>
        public static string ServersNameTextBox {
            get {
                return ResourceManager.GetString("ServersNameTextBox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shows extended information of selected share..
        /// </summary>
        public static string ShareDetails {
            get {
                return ResourceManager.GetString("ShareDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A list of available shares. Select a share to view its details..
        /// </summary>
        public static string SharesList {
            get {
                return ResourceManager.GetString("SharesList", resourceCulture);
            }
        }
    }
}