//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// 
// This template generates PublicResXFileCodeGenerator compatible code plus some
// useful extensions. 
// 
// The original version provided by ResXResourceManager is restricted to resource key names
// that are valid c# identifiers to keep this template simple (KISS!).
// 
// Us it as it is or as a scaffold to generate the code you need.
//
// As long as you have ResXResourceManager running in the background, the generated code 
// will be kept up to date.
//  
//------------------------------------------------------------------------------

namespace tomenglertde.ResXManager.VSIX {
    using System;
    using System.Diagnostics.Contracts;

    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by a text template.
    // To add or remove a member, edit your .ResX file.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ResXResourceManager", "1.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("tomenglertde.ResXManager.VSIX.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Assembly location: {0}.
        /// </summary>
        public static string AssemblyLocation {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("AssemblyLocation", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Can not create tool window..
        /// </summary>
        public static string CanNotCreateWindow {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("CanNotCreateWindow", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Code generator.
        /// </summary>
        public static string CodeGenerator_CommandGroup {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("CodeGenerator_CommandGroup", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Custom tool (internal access).
        /// </summary>
        public static string CodeGenerator_CommandInternal {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("CodeGenerator_CommandInternal", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Custom tool (public access).
        /// </summary>
        public static string CodeGenerator_CommandPublic {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("CodeGenerator_CommandPublic", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Text template.
        /// </summary>
        public static string CodeGenerator_CommandTextTemplate {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("CodeGenerator_CommandTextTemplate", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Custom tool code generator, internal access..
        /// </summary>
        public static string CodeGenerator_Internal {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("CodeGenerator_Internal", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Custom tool code generator, public access..
        /// </summary>
        public static string CodeGenerator_Public {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("CodeGenerator_Public", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to TextTemplate code generator..
        /// </summary>
        public static string CodeGenerator_TextTemplate {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("CodeGenerator_TextTemplate", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unknown code generator..
        /// </summary>
        public static string CodeGenerator_Unkown {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("CodeGenerator_Unkown", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Code:.
        /// </summary>
        public static string CodeHeader {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("CodeHeader", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Comment:.
        /// </summary>
        public static string CommentHeader {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("CommentHeader", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error:.
        /// </summary>
        public static string Error {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("Error", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error loading the ResX Manager extension: {0}.&amp....
        /// </summary>
        public static string ExtensionLoadingError {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("ExtensionLoadingError", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to ResX Resource Manager loaded.&amp;#13;&amp;#10;Hom....
        /// </summary>
        public static string IntroMessage {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("IntroMessage", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Key:.
        /// </summary>
        public static string KeyHeader {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("KeyHeader", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Move to resource.
        /// </summary>
        public static string MoveToResource {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("MoveToResource", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Open in ResX Manager.
        /// </summary>
        public static string OpenInResXManager {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("OpenInResXManager", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The project has no resource file for the language ....
        /// </summary>
        public static string ProjectHasNoResourceFile {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("ProjectHasNoResourceFile", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Some files in your project are not writable. Make ....
        /// </summary>
        public static string ProjectHasReadOnlyFiles {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("ProjectHasReadOnlyFiles", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Resource:.
        /// </summary>
        public static string ResourceHeader {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("ResourceHeader", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error loading resource files: {0}. &amp;#13;&amp;#....
        /// </summary>
        public static string ResourceLoadingError {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("ResourceLoadingError", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        public static System.Byte[] Resources_Designer_t4 {
            get {
                object obj = ResourceManager.GetObject("Resources_Designer_t4", resourceCulture);
                return ((System.Byte[])(obj));
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        public static System.Byte[] Resources_Designer_tt {
            get {
                object obj = ResourceManager.GetObject("Resources_Designer_tt", resourceCulture);
                return ((System.Byte[])(obj));
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to ResX Resource Manager.
        /// </summary>
        /// <remarks>
        /// @Invariant
        /// </remarks>
        public static string ToolWindowTitle {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("ToolWindowTitle", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Value:.
        /// </summary>
        public static string ValueHeader {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("ValueHeader", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Version: {0}.
        /// </summary>
        public static string Version {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("Version", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Warning:.
        /// </summary>
        public static string Warning {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("Warning", resourceCulture) ?? string.Empty;
            }
        }
    }

    /// <summary>
    /// Keys of all available strings in the applications resx-resources.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    public enum StringResourceKey
    {
        /// <summary>
        ///   Looks up a localized string similar to Assembly location: {0}.
        /// </summary>
        AssemblyLocation,
        /// <summary>
        ///   Looks up a localized string similar to Can not create tool window..
        /// </summary>
        CanNotCreateWindow,
        /// <summary>
        ///   Looks up a localized string similar to Code generator.
        /// </summary>
        CodeGenerator_CommandGroup,
        /// <summary>
        ///   Looks up a localized string similar to Custom tool (internal access).
        /// </summary>
        CodeGenerator_CommandInternal,
        /// <summary>
        ///   Looks up a localized string similar to Custom tool (public access).
        /// </summary>
        CodeGenerator_CommandPublic,
        /// <summary>
        ///   Looks up a localized string similar to Text template.
        /// </summary>
        CodeGenerator_CommandTextTemplate,
        /// <summary>
        ///   Looks up a localized string similar to Custom tool code generator, internal access..
        /// </summary>
        CodeGenerator_Internal,
        /// <summary>
        ///   Looks up a localized string similar to Custom tool code generator, public access..
        /// </summary>
        CodeGenerator_Public,
        /// <summary>
        ///   Looks up a localized string similar to TextTemplate code generator..
        /// </summary>
        CodeGenerator_TextTemplate,
        /// <summary>
        ///   Looks up a localized string similar to Unknown code generator..
        /// </summary>
        CodeGenerator_Unkown,
        /// <summary>
        ///   Looks up a localized string similar to Code:.
        /// </summary>
        CodeHeader,
        /// <summary>
        ///   Looks up a localized string similar to Comment:.
        /// </summary>
        CommentHeader,
        /// <summary>
        ///   Looks up a localized string similar to Error:.
        /// </summary>
        Error,
        /// <summary>
        ///   Looks up a localized string similar to Error loading the ResX Manager extension: {0}.&amp....
        /// </summary>
        ExtensionLoadingError,
        /// <summary>
        ///   Looks up a localized string similar to ResX Resource Manager loaded.&amp;#13;&amp;#10;Hom....
        /// </summary>
        IntroMessage,
        /// <summary>
        ///   Looks up a localized string similar to Key:.
        /// </summary>
        KeyHeader,
        /// <summary>
        ///   Looks up a localized string similar to Move to resource.
        /// </summary>
        MoveToResource,
        /// <summary>
        ///   Looks up a localized string similar to Open in ResX Manager.
        /// </summary>
        OpenInResXManager,
        /// <summary>
        ///   Looks up a localized string similar to The project has no resource file for the language ....
        /// </summary>
        ProjectHasNoResourceFile,
        /// <summary>
        ///   Looks up a localized string similar to Some files in your project are not writable. Make ....
        /// </summary>
        ProjectHasReadOnlyFiles,
        /// <summary>
        ///   Looks up a localized string similar to Resource:.
        /// </summary>
        ResourceHeader,
        /// <summary>
        ///   Looks up a localized string similar to Error loading resource files: {0}. &amp;#13;&amp;#....
        /// </summary>
        ResourceLoadingError,
        /// <summary>
        ///   Looks up a localized string similar to ResX Resource Manager.
        /// </summary>
        /// <remarks>
        /// @Invariant
        /// </remarks>
        ToolWindowTitle,
        /// <summary>
        ///   Looks up a localized string similar to Value:.
        /// </summary>
        ValueHeader,
        /// <summary>
        ///   Looks up a localized string similar to Version: {0}.
        /// </summary>
        Version,
        /// <summary>
        ///   Looks up a localized string similar to Warning:.
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Specifies a localized description for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
    public sealed class LocalizedDescriptionAttribute : System.ComponentModel.DescriptionAttribute
    {
        private readonly StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedDescriptionAttribute"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedDescriptionAttribute(StringResourceKey resourceKey)
        {
            _resourceKey = resourceKey;
        }

        /// <summary>
        /// Gets the localized description from the resource id stored in this attribute.
        /// </summary>
        public override string Description
        {
            get
            {
                return Resources.ResourceManager.GetString(_resourceKey.ToString());
            }
        }
    }

    /// <summary>
    /// Specifies a localized display name for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
    public sealed class LocalizedDisplayNameAttribute : System.ComponentModel.DisplayNameAttribute
    {
        private readonly StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedDisplayNameAttribute"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedDisplayNameAttribute(StringResourceKey resourceKey)
        {
            _resourceKey = resourceKey;
        }

        /// <summary>
        /// Gets the localized display name from the resource id stored in this attribute.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return Resources.ResourceManager.GetString(_resourceKey.ToString());
            }
        }
    }

    /// <summary>
    /// Specifies a localized display name for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
    public sealed class LocalizedCategoryAttribute : System.ComponentModel.CategoryAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedCategoryAttribute"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedCategoryAttribute(StringResourceKey resourceKey)
            : base(resourceKey.ToString())
        {
        }

        /// <summary>
        /// Gets the localized category name from the resource id stored in this attribute.
        /// </summary>
        protected override string GetLocalizedString(string value)
        {
            return Resources.ResourceManager.GetString(value);
        }
    }

    /// <summary>
    /// Specifies a localized display name for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public sealed class LocalizedTextAttribute : global::TomsToolbox.Desktop.TextAttribute
    {
        private readonly StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedTextAttribute"/> class.
        /// </summary>
        /// <param name="key">Any user defined key to specify the usage of this text.</param>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedTextAttribute(object key, StringResourceKey resourceKey)
            : base(key)
        {
            _resourceKey = resourceKey;
        }

        /// <summary>
        /// Gets the localized text from the resource id stored in this attribute.
        /// </summary>
        public override string Text
        {
            get
            {
                return Resources.ResourceManager.GetString(_resourceKey.ToString());
            }
        }
    }



}

