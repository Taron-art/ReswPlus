﻿// File generated automatically by ReswPlus. https://github.com/DotNetPlus/ReswPlus
using System;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Data;

namespace ReswPlusUWPSampleExternalLibrary.Strings{
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ReswPlus.SourceGenerator", "1.0.0.0")]
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public static class Resources {
    private static _ReswPlus_AutoGenerated.ResourceStringProvider _resourceStringProvider;
    static Resources()
    {
      _resourceStringProvider = new _ReswPlus_AutoGenerated.ResourceStringProvider("ReswPlusUWPSampleExternalLibrary/Resources");
    }

    /// <summary>
    ///   Returns the specified string resource for the specified culture or current UI culture.
    /// </summary>
    public static string GetString(string key) => _resourceStringProvider.GetString(key);

    #region ExternalString
    /// <summary>
    ///   Looks up a localized string similar to: This string is from an external library
    /// </summary>
    public static string ExternalString
    {
      get
      {
        return _resourceStringProvider.GetString("ExternalString");
      }
    }
    #endregion
  }

  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ReswPlus.SourceGenerator", "1.0.0.0")]
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [MarkupExtensionReturnType(ReturnType = typeof(string))]
  public partial class ResourcesExtension : MarkupExtension
  {
    public enum KeyEnum
    {
      _Undefined = 0,
      ExternalString,
    }

    private static _ReswPlus_AutoGenerated.ResourceStringProvider _resourceStringProvider;
    static ResourcesExtension()
    {
      _resourceStringProvider = new _ReswPlus_AutoGenerated.ResourceStringProvider("ReswPlusUWPSampleExternalLibrary/Resources");
    }
    public KeyEnum Key { get; set;}
    public IValueConverter Converter { get; set;}
    public object ConverterParameter { get; set;}
    protected override object ProvideValue()
    {
      var value = Key is KeyEnum._Undefined ? string.Empty : _resourceStringProvider.GetString(Key.ToString());
      return Converter is null ? value : Converter.Convert(value, typeof(String), ConverterParameter, null);
    }
  }
} //ReswPlusUWPSampleExternalLibrary.Strings
