﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace nu.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class nuresources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal nuresources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("nu.Resources.nuresources", typeof(nuresources).Assembly);
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
        ///   Looks up a localized string similar to command &apos;{0}&apos; not found.
        /// </summary>
        internal static string Common_CommandNotFound {
            get {
                return ResourceManager.GetString("Common_CommandNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to help.
        /// </summary>
        internal static string Dispatcher_DefaultCommand {
            get {
                return ResourceManager.GetString("Dispatcher_DefaultCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}Error: The following arguments are required but were not provided:{0}{0}.
        /// </summary>
        internal static string Dispatcher_MissingRequiredArguments {
            get {
                return ResourceManager.GetString("Dispatcher_MissingRequiredArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File transformation was provided &apos;{0}&apos; via the manifest which does not exist.
        /// </summary>
        internal static string FileTransformation_MissingFile {
            get {
                return ResourceManager.GetString("FileTransformation_MissingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Available Commands.
        /// </summary>
        internal static string Help_AvailableCommands {
            get {
                return ResourceManager.GetString("Help_AvailableCommands", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command: {0}.
        /// </summary>
        internal static string Help_CommandName {
            get {
                return ResourceManager.GetString("Help_CommandName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: nu {0} {1}.
        /// </summary>
        internal static string Help_CommandUsage {
            get {
                return ResourceManager.GetString("Help_CommandUsage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; manifest does not exist.
        /// </summary>
        internal static string ProjectManifest_ManifestDoesNotExist {
            get {
                return ResourceManager.GetString("ProjectManifest_ManifestDoesNotExist", resourceCulture);
            }
        }
    }
}
