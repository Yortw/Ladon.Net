﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ladon {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ladon.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {0} must contain at least one item..
        /// </summary>
        internal static string EnumerableCannotBeEmpty {
            get {
                return ResourceManager.GetString("EnumerableCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;NULL&gt;.
        /// </summary>
        internal static string NullPlaceholder {
            get {
                return ResourceManager.GetString("NullPlaceholder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} must be greater than zero..
        /// </summary>
        internal static string NumberCannotBeLessThanOrEqualToZero {
            get {
                return ResourceManager.GetString("NumberCannotBeLessThanOrEqualToZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be negative..
        /// </summary>
        internal static string NumberCannotBeNegative {
            get {
                return ResourceManager.GetString("NumberCannotBeNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be zero..
        /// </summary>
        internal static string NumberCannotBeZero {
            get {
                return ResourceManager.GetString("NumberCannotBeZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be more than {1}..
        /// </summary>
        internal static string NumberTooLarge {
            get {
                return ResourceManager.GetString("NumberTooLarge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be less than {1}..
        /// </summary>
        internal static string NumberTooSmall {
            get {
                return ResourceManager.GetString("NumberTooSmall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be an empty string..
        /// </summary>
        internal static string StringArgumentCannotBeEmpty {
            get {
                return ResourceManager.GetString("StringArgumentCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot contain only white space..
        /// </summary>
        internal static string StringCannotBeWhitespace {
            get {
                return ResourceManager.GetString("StringCannotBeWhitespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} must have a length between {1} and {2}..
        /// </summary>
        internal static string StringLengthOutOfRange {
            get {
                return ResourceManager.GetString("StringLengthOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be longer than {1}..
        /// </summary>
        internal static string StringTooLong {
            get {
                return ResourceManager.GetString("StringTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be &quot;{1}&quot;..
        /// </summary>
        internal static string ValueNotAllowed {
            get {
                return ResourceManager.GetString("ValueNotAllowed", resourceCulture);
            }
        }
    }
}
