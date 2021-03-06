// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/DisplayWeather.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/DisplayWeather.proto</summary>
  public static partial class DisplayWeatherReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/DisplayWeather.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DisplayWeatherReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJXVVByb3Rvcy9EYXRhL0Rpc3BsYXlXZWF0aGVyLnByb3RvEg1XVVByb3Rv",
            "cy5EYXRhIvYDCg5EaXNwbGF5V2VhdGhlchI/CgtjbG91ZF9sZXZlbBgBIAEo",
            "DjIqLldVUHJvdG9zLkRhdGEuRGlzcGxheVdlYXRoZXIuRGlzcGxheUxldmVs",
            "Ej4KCnJhaW5fbGV2ZWwYAiABKA4yKi5XVVByb3Rvcy5EYXRhLkRpc3BsYXlX",
            "ZWF0aGVyLkRpc3BsYXlMZXZlbBI+Cgp3aW5kX2xldmVsGAMgASgOMiouV1VQ",
            "cm90b3MuRGF0YS5EaXNwbGF5V2VhdGhlci5EaXNwbGF5TGV2ZWwSPgoKc25v",
            "d19sZXZlbBgEIAEoDjIqLldVUHJvdG9zLkRhdGEuRGlzcGxheVdlYXRoZXIu",
            "RGlzcGxheUxldmVsEj0KCWZvZ19sZXZlbBgFIAEoDjIqLldVUHJvdG9zLkRh",
            "dGEuRGlzcGxheVdlYXRoZXIuRGlzcGxheUxldmVsEhYKDndpbmRfZGlyZWN0",
            "aW9uGAYgASgFEkgKFHNwZWNpYWxfZWZmZWN0X2xldmVsGAcgASgOMiouV1VQ",
            "cm90b3MuRGF0YS5EaXNwbGF5V2VhdGhlci5EaXNwbGF5TGV2ZWwiQgoMRGlz",
            "cGxheUxldmVsEgsKB0xFVkVMXzAQABILCgdMRVZFTF8xEAESCwoHTEVWRUxf",
            "MhACEgsKB0xFVkVMXzMQA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.DisplayWeather), global::WUProtos.Data.DisplayWeather.Parser, new[]{ "CloudLevel", "RainLevel", "WindLevel", "SnowLevel", "FogLevel", "WindDirection", "SpecialEffectLevel" }, null, new[]{ typeof(global::WUProtos.Data.DisplayWeather.Types.DisplayLevel) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DisplayWeather : pb::IMessage<DisplayWeather> {
    private static readonly pb::MessageParser<DisplayWeather> _parser = new pb::MessageParser<DisplayWeather>(() => new DisplayWeather());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DisplayWeather> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.DisplayWeatherReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DisplayWeather() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DisplayWeather(DisplayWeather other) : this() {
      cloudLevel_ = other.cloudLevel_;
      rainLevel_ = other.rainLevel_;
      windLevel_ = other.windLevel_;
      snowLevel_ = other.snowLevel_;
      fogLevel_ = other.fogLevel_;
      windDirection_ = other.windDirection_;
      specialEffectLevel_ = other.specialEffectLevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DisplayWeather Clone() {
      return new DisplayWeather(this);
    }

    /// <summary>Field number for the "cloud_level" field.</summary>
    public const int CloudLevelFieldNumber = 1;
    private global::WUProtos.Data.DisplayWeather.Types.DisplayLevel cloudLevel_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.DisplayWeather.Types.DisplayLevel CloudLevel {
      get { return cloudLevel_; }
      set {
        cloudLevel_ = value;
      }
    }

    /// <summary>Field number for the "rain_level" field.</summary>
    public const int RainLevelFieldNumber = 2;
    private global::WUProtos.Data.DisplayWeather.Types.DisplayLevel rainLevel_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.DisplayWeather.Types.DisplayLevel RainLevel {
      get { return rainLevel_; }
      set {
        rainLevel_ = value;
      }
    }

    /// <summary>Field number for the "wind_level" field.</summary>
    public const int WindLevelFieldNumber = 3;
    private global::WUProtos.Data.DisplayWeather.Types.DisplayLevel windLevel_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.DisplayWeather.Types.DisplayLevel WindLevel {
      get { return windLevel_; }
      set {
        windLevel_ = value;
      }
    }

    /// <summary>Field number for the "snow_level" field.</summary>
    public const int SnowLevelFieldNumber = 4;
    private global::WUProtos.Data.DisplayWeather.Types.DisplayLevel snowLevel_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.DisplayWeather.Types.DisplayLevel SnowLevel {
      get { return snowLevel_; }
      set {
        snowLevel_ = value;
      }
    }

    /// <summary>Field number for the "fog_level" field.</summary>
    public const int FogLevelFieldNumber = 5;
    private global::WUProtos.Data.DisplayWeather.Types.DisplayLevel fogLevel_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.DisplayWeather.Types.DisplayLevel FogLevel {
      get { return fogLevel_; }
      set {
        fogLevel_ = value;
      }
    }

    /// <summary>Field number for the "wind_direction" field.</summary>
    public const int WindDirectionFieldNumber = 6;
    private int windDirection_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int WindDirection {
      get { return windDirection_; }
      set {
        windDirection_ = value;
      }
    }

    /// <summary>Field number for the "special_effect_level" field.</summary>
    public const int SpecialEffectLevelFieldNumber = 7;
    private global::WUProtos.Data.DisplayWeather.Types.DisplayLevel specialEffectLevel_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.DisplayWeather.Types.DisplayLevel SpecialEffectLevel {
      get { return specialEffectLevel_; }
      set {
        specialEffectLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DisplayWeather);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DisplayWeather other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CloudLevel != other.CloudLevel) return false;
      if (RainLevel != other.RainLevel) return false;
      if (WindLevel != other.WindLevel) return false;
      if (SnowLevel != other.SnowLevel) return false;
      if (FogLevel != other.FogLevel) return false;
      if (WindDirection != other.WindDirection) return false;
      if (SpecialEffectLevel != other.SpecialEffectLevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CloudLevel != 0) hash ^= CloudLevel.GetHashCode();
      if (RainLevel != 0) hash ^= RainLevel.GetHashCode();
      if (WindLevel != 0) hash ^= WindLevel.GetHashCode();
      if (SnowLevel != 0) hash ^= SnowLevel.GetHashCode();
      if (FogLevel != 0) hash ^= FogLevel.GetHashCode();
      if (WindDirection != 0) hash ^= WindDirection.GetHashCode();
      if (SpecialEffectLevel != 0) hash ^= SpecialEffectLevel.GetHashCode();
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
      if (CloudLevel != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) CloudLevel);
      }
      if (RainLevel != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) RainLevel);
      }
      if (WindLevel != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) WindLevel);
      }
      if (SnowLevel != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) SnowLevel);
      }
      if (FogLevel != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) FogLevel);
      }
      if (WindDirection != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(WindDirection);
      }
      if (SpecialEffectLevel != 0) {
        output.WriteRawTag(56);
        output.WriteEnum((int) SpecialEffectLevel);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CloudLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CloudLevel);
      }
      if (RainLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) RainLevel);
      }
      if (WindLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) WindLevel);
      }
      if (SnowLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SnowLevel);
      }
      if (FogLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FogLevel);
      }
      if (WindDirection != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(WindDirection);
      }
      if (SpecialEffectLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SpecialEffectLevel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DisplayWeather other) {
      if (other == null) {
        return;
      }
      if (other.CloudLevel != 0) {
        CloudLevel = other.CloudLevel;
      }
      if (other.RainLevel != 0) {
        RainLevel = other.RainLevel;
      }
      if (other.WindLevel != 0) {
        WindLevel = other.WindLevel;
      }
      if (other.SnowLevel != 0) {
        SnowLevel = other.SnowLevel;
      }
      if (other.FogLevel != 0) {
        FogLevel = other.FogLevel;
      }
      if (other.WindDirection != 0) {
        WindDirection = other.WindDirection;
      }
      if (other.SpecialEffectLevel != 0) {
        SpecialEffectLevel = other.SpecialEffectLevel;
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
            CloudLevel = (global::WUProtos.Data.DisplayWeather.Types.DisplayLevel) input.ReadEnum();
            break;
          }
          case 16: {
            RainLevel = (global::WUProtos.Data.DisplayWeather.Types.DisplayLevel) input.ReadEnum();
            break;
          }
          case 24: {
            WindLevel = (global::WUProtos.Data.DisplayWeather.Types.DisplayLevel) input.ReadEnum();
            break;
          }
          case 32: {
            SnowLevel = (global::WUProtos.Data.DisplayWeather.Types.DisplayLevel) input.ReadEnum();
            break;
          }
          case 40: {
            FogLevel = (global::WUProtos.Data.DisplayWeather.Types.DisplayLevel) input.ReadEnum();
            break;
          }
          case 48: {
            WindDirection = input.ReadInt32();
            break;
          }
          case 56: {
            SpecialEffectLevel = (global::WUProtos.Data.DisplayWeather.Types.DisplayLevel) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the DisplayWeather message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum DisplayLevel {
        [pbr::OriginalName("LEVEL_0")] Level0 = 0,
        [pbr::OriginalName("LEVEL_1")] Level1 = 1,
        [pbr::OriginalName("LEVEL_2")] Level2 = 2,
        [pbr::OriginalName("LEVEL_3")] Level3 = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
