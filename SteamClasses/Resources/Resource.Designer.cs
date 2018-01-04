namespace Resources {


  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public class Resource {
        
     private static global::System.Resources.ResourceManager resourceMan;
        
     private static global::System.Globalization.CultureInfo resourceCulture;
        
     [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
     internal Resource() { }
        
        
     [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
     public static global::System.Resources.ResourceManager ResourceManager {
         get {
             if (object.ReferenceEquals(resourceMan, null)) {
                 global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SteamClasses.Resources.Resource", typeof(Resource).Assembly);
                 resourceMan = temp;
             }
             return resourceMan;
         }
     }
        
     [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
     public static global::System.Globalization.CultureInfo Culture {
         get {
             return resourceCulture;
         }
         set {
             resourceCulture = value;
         }
     }

     public static string GetCategory
     {
         get {
             return ResourceManager.GetString("category", resourceCulture);
         }
     }

     public static string GetLanguage
     {
         get {
             return ResourceManager.GetString("language", resourceCulture);
         }
     }

     public static string GetMenu
     {
         get {
             return ResourceManager.GetString("menu", resourceCulture);
         }
     }

     public static string GetTab
     {
         get
         {
             return ResourceManager.GetString("tab", resourceCulture);
         }
     }

      public static string SubmitAge
      {
          get
          {
              return ResourceManager.GetString("submitAge", resourceCulture);
          }
      }

     public static string SubmitAge2
     {
         get
         {
            return ResourceManager.GetString("submitAge2", resourceCulture);
         }
     }
 }
}
