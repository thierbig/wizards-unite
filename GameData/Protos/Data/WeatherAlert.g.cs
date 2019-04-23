// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/WeatherAlert.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/WeatherAlert.proto</summary>
  public static partial class WeatherAlertReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/WeatherAlert.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WeatherAlertReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBXVVByb3Rvcy9EYXRhL1dlYXRoZXJBbGVydC5wcm90bxINV1VQcm90b3Mu",
            "RGF0YSKNAQoMV2VhdGhlckFsZXJ0EjYKCHNldmVyaXR5GAEgASgOMiQuV1VQ",
            "cm90b3MuRGF0YS5XZWF0aGVyQWxlcnQuU2V2ZXJpdHkSFAoMd2Fybl93ZWF0",
            "aGVyGAIgASgIIi8KCFNldmVyaXR5EggKBE5PTkUQABIMCghNT0RFUkFURRAB",
            "EgsKB0VYVFJFTUUQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.WeatherAlert), global::WUProtos.Data.WeatherAlert.Parser, new[]{ "Severity", "WarnWeather" }, null, new[]{ typeof(global::WUProtos.Data.WeatherAlert.Types.Severity) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WeatherAlert : pb::IMessage<WeatherAlert> {
    private static readonly pb::MessageParser<WeatherAlert> _parser = new pb::MessageParser<WeatherAlert>(() => new WeatherAlert());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WeatherAlert> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.WeatherAlertReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WeatherAlert() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WeatherAlert(WeatherAlert other) : this() {
      severity_ = other.severity_;
      warnWeather_ = other.warnWeather_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WeatherAlert Clone() {
      return new WeatherAlert(this);
    }

    /// <summary>Field number for the "severity" field.</summary>
    public const int SeverityFieldNumber = 1;
    private global::WUProtos.Data.WeatherAlert.Types.Severity severity_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.WeatherAlert.Types.Severity Severity {
      get { return severity_; }
      set {
        severity_ = value;
      }
    }

    /// <summary>Field number for the "warn_weather" field.</summary>
    public const int WarnWeatherFieldNumber = 2;
    private bool warnWeather_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool WarnWeather {
      get { return warnWeather_; }
      set {
        warnWeather_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WeatherAlert);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WeatherAlert other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Severity != other.Severity) return false;
      if (WarnWeather != other.WarnWeather) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Severity != 0) hash ^= Severity.GetHashCode();
      if (WarnWeather != false) hash ^= WarnWeather.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Severity != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Severity);
      }
      if (WarnWeather != false) {
        output.WriteRawTag(16);
        output.WriteBool(WarnWeather);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Severity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Severity);
      }
      if (WarnWeather != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WeatherAlert other) {
      if (other == null) {
        return;
      }
      if (other.Severity != 0) {
        Severity = other.Severity;
      }
      if (other.WarnWeather != false) {
        WarnWeather = other.WarnWeather;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Severity = (global::WUProtos.Data.WeatherAlert.Types.Severity) input.ReadEnum();
            break;
          }
          case 16: {
            WarnWeather = input.ReadBool();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the WeatherAlert message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Severity {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("MODERATE")] Moderate = 1,
        [pbr::OriginalName("EXTREME")] Extreme = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code