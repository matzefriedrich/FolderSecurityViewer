﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FSV.Console.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FSV.Console.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to FSV terminated abruptly..
        /// </summary>
        internal static string ApplicationTerminated {
            get {
                return ResourceManager.GetString("ApplicationTerminated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FolderSecurityViewer CLI ({0}), Version: {1}.
        /// </summary>
        internal static string ApplicationVersion {
            get {
                return ResourceManager.GetString("ApplicationVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter {0} to start scan..
        /// </summary>
        internal static string ArgumentEmptyError {
            get {
                return ResourceManager.GetString("ArgumentEmptyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A path of directory to scan. Use quotes if the path has whitespace in it..
        /// </summary>
        internal static string ArgumentPathDescriptionText {
            get {
                return ResourceManager.GetString("ArgumentPathDescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A name of shared server to scan..
        /// </summary>
        internal static string ArgumentServerDescriptionText {
            get {
                return ResourceManager.GetString("ArgumentServerDescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A name of user (either user or domain\\user).
        /// </summary>
        internal static string ArgumentUserDescriptionText {
            get {
                return ResourceManager.GetString("ArgumentUserDescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database has not been set up..
        /// </summary>
        internal static string DatabaseUnavailable {
            get {
                return ResourceManager.GetString("DatabaseUnavailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access denied:.
        /// </summary>
        internal static string DirectoryAccessDeniedError {
            get {
                return ResourceManager.GetString("DirectoryAccessDeniedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not exist..
        /// </summary>
        internal static string DirectoryNotExistsError {
            get {
                return ResourceManager.GetString("DirectoryNotExistsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exporting....
        /// </summary>
        internal static string ExportingText {
            get {
                return ResourceManager.GetString("ExportingText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder Report.
        /// </summary>
        internal static string FolderReportCaption {
            get {
                return ResourceManager.GetString("FolderReportCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start Folder Report.
        /// </summary>
        internal static string FolderReportDescription {
            get {
                return ResourceManager.GetString("FolderReportDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to export folder report due to unhandled exception..
        /// </summary>
        internal static string FolderReportException {
            get {
                return ResourceManager.GetString("FolderReportException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder report exported to &quot;{0}&quot;..
        /// </summary>
        internal static string FolderReportExportedText {
            get {
                return ResourceManager.GetString("FolderReportExportedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scan completed with total {0} folders..
        /// </summary>
        internal static string FolderScanCompleteText {
            get {
                return ResourceManager.GetString("FolderScanCompleteText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No result generated to export..
        /// </summary>
        internal static string NoResultToExportText {
            get {
                return ResourceManager.GetString("NoResultToExportText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Saves the report to database..
        /// </summary>
        internal static string OptionDatabaseDescriptionText {
            get {
                return ResourceManager.GetString("OptionDatabaseDescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export to file - excel, csv, or html. Default is HTML.
        /// </summary>
        internal static string OptionExportDescriptionText {
            get {
                return ResourceManager.GetString("OptionExportDescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An export file path..
        /// </summary>
        internal static string OptionExportPathDescriptionText {
            get {
                return ResourceManager.GetString("OptionExportPathDescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scans the differences of permissions deep in the directory structure, and exports the result..
        /// </summary>
        internal static string OptionPermissionSubFoldersDescriptionText {
            get {
                return ResourceManager.GetString("OptionPermissionSubFoldersDescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Owner Report.
        /// </summary>
        internal static string OwnerReportCaption {
            get {
                return ResourceManager.GetString("OwnerReportCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start Owner Report.
        /// </summary>
        internal static string OwnerReportDescription {
            get {
                return ResourceManager.GetString("OwnerReportDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to export owner report due to unhandled exception..
        /// </summary>
        internal static string OwnerReportException {
            get {
                return ResourceManager.GetString("OwnerReportException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Owner report exported to &quot;{0}&quot;.
        /// </summary>
        internal static string OwnerReportExportedText {
            get {
                return ResourceManager.GetString("OwnerReportExportedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scanning {0} for owner {1}....
        /// </summary>
        internal static string OwnerReportScanningText {
            get {
                return ResourceManager.GetString("OwnerReportScanningText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to store permission report in the database..
        /// </summary>
        internal static string PermissionReportDbException {
            get {
                return ResourceManager.GetString("PermissionReportDbException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start Permission Report.
        /// </summary>
        internal static string PermissionReportDescription {
            get {
                return ResourceManager.GetString("PermissionReportDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to export permission differences.
        /// </summary>
        internal static string PermissionReportDifferenceException {
            get {
                return ResourceManager.GetString("PermissionReportDifferenceException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hierarchical permissions exported to {0}..
        /// </summary>
        internal static string PermissionReportDifferenceExportedText {
            get {
                return ResourceManager.GetString("PermissionReportDifferenceExportedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scanned {0}: {1} permissions..
        /// </summary>
        internal static string PermissionReportDifferenceScanCompleteText {
            get {
                return ResourceManager.GetString("PermissionReportDifferenceScanCompleteText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory is inaccesible: {0}.
        /// </summary>
        internal static string PermissionReportDifferenceScanFailedText {
            get {
                return ResourceManager.GetString("PermissionReportDifferenceScanFailedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to export permission differences due to an unhandled exception..
        /// </summary>
        internal static string PermissionReportDifferenceUnhandledException {
            get {
                return ResourceManager.GetString("PermissionReportDifferenceUnhandledException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permission report exported to &quot;{0}&quot;..
        /// </summary>
        internal static string PermissionReportExportedText {
            get {
                return ResourceManager.GetString("PermissionReportExportedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to export permission report..
        /// </summary>
        internal static string PermissionReportFileExportException {
            get {
                return ResourceManager.GetString("PermissionReportFileExportException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No difference of permission found in sub-directories..
        /// </summary>
        internal static string PermissionReportNoDifferenceText {
            get {
                return ResourceManager.GetString("PermissionReportNoDifferenceText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A permission report could not be generated. Please check the log..
        /// </summary>
        internal static string PermissionReportNotExportedText {
            get {
                return ResourceManager.GetString("PermissionReportNotExportedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permission report saved in database..
        /// </summary>
        internal static string PermissionReportSavedInDbText {
            get {
                return ResourceManager.GetString("PermissionReportSavedInDbText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scan completed with total {0} permissions..
        /// </summary>
        internal static string PermissionReportScanCompleteText {
            get {
                return ResourceManager.GetString("PermissionReportScanCompleteText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The primary argument cannot be null..
        /// </summary>
        internal static string PrimaryArgumentError {
            get {
                return ResourceManager.GetString("PrimaryArgumentError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scan failed..
        /// </summary>
        internal static string ScanFailedException {
            get {
                return ResourceManager.GetString("ScanFailedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scanning {0}....
        /// </summary>
        internal static string ScanningText {
            get {
                return ResourceManager.GetString("ScanningText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shared server &quot;{0}&quot; not found..
        /// </summary>
        internal static string SharedServerNotFoundError {
            get {
                return ResourceManager.GetString("SharedServerNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Share Report.
        /// </summary>
        internal static string ShareReportCaption {
            get {
                return ResourceManager.GetString("ShareReportCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start Share Report.
        /// </summary>
        internal static string ShareReportDescription {
            get {
                return ResourceManager.GetString("ShareReportDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to export share report due to unhandled exception..
        /// </summary>
        internal static string ShareReportException {
            get {
                return ResourceManager.GetString("ShareReportException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CSV export is not available for share reports..
        /// </summary>
        internal static string ShareReportExportCsvException {
            get {
                return ResourceManager.GetString("ShareReportExportCsvException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Share report exported to &quot;{0}&quot;..
        /// </summary>
        internal static string ShareReportExportedText {
            get {
                return ResourceManager.GetString("ShareReportExportedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Share report could not be exported. Please check the log..
        /// </summary>
        internal static string ShareReportNotExportedText {
            get {
                return ResourceManager.GetString("ShareReportNotExportedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export to file - Excel, or HTML (HTML is default)..
        /// </summary>
        internal static string ShareReportOptionExportDescriptionText {
            get {
                return ResourceManager.GetString("ShareReportOptionExportDescriptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scanning {0} for shares....
        /// </summary>
        internal static string ShareReportScanningText {
            get {
                return ResourceManager.GetString("ShareReportScanningText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported export format..
        /// </summary>
        internal static string UnsupportedFormatError {
            get {
                return ResourceManager.GetString("UnsupportedFormatError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User {0} in {1}.
        /// </summary>
        internal static string UserInDirectoryText {
            get {
                return ResourceManager.GetString("UserInDirectoryText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User Permission Report.
        /// </summary>
        internal static string UserPermissionReportCaption {
            get {
                return ResourceManager.GetString("UserPermissionReportCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start User Permission Report.
        /// </summary>
        internal static string UserPermissionReportDescription {
            get {
                return ResourceManager.GetString("UserPermissionReportDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User permission report exported to &quot;{0}&quot;..
        /// </summary>
        internal static string UserPermissionReportExportedText {
            get {
                return ResourceManager.GetString("UserPermissionReportExportedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to export user permission report..
        /// </summary>
        internal static string UserPermissionReportFileExportException {
            get {
                return ResourceManager.GetString("UserPermissionReportFileExportException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user permission report could not be exported. Please check the log..
        /// </summary>
        internal static string UserPermissionReportNotExportedText {
            get {
                return ResourceManager.GetString("UserPermissionReportNotExportedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scanning {0} for user {1}....
        /// </summary>
        internal static string UserPermissionReportScanningText {
            get {
                return ResourceManager.GetString("UserPermissionReportScanningText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be null or whitespace..
        /// </summary>
        internal static string ValueNullOrWhitespaceException {
            get {
                return ResourceManager.GetString("ValueNullOrWhitespaceException", resourceCulture);
            }
        }
    }
}