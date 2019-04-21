// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Buff/TimeBuffDuration.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Buff {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Buff/TimeBuffDuration.proto</summary>
  public static partial class TimeBuffDurationReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Buff/TimeBuffDuration.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TimeBuffDurationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilXVVByb3Rvcy9EYXRhL0J1ZmYvVGltZUJ1ZmZEdXJhdGlvbi5wcm90bxIS",
            "V1VQcm90b3MuRGF0YS5CdWZmIjgKEFRpbWVCdWZmRHVyYXRpb24SDwoHdGlt",
            "ZV9tcxgBIAEoAxITCgtpc19vdmVycmlkZRgCIAEoCGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Buff.TimeBuffDuration), global::WUProtos.Data.Buff.TimeBuffDuration.Parser, new[]{ "TimeMs", "IsOverride" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TimeBuffDuration : pb::IMessage<TimeBuffDuration> {
    private static readonly pb::MessageParser<TimeBuffDuration> _parser = new pb::MessageParser<TimeBuffDuration>(() => new TimeBuffDuration());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TimeBuffDuration> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Buff.TimeBuffDurationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeBuffDuration() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeBuffDuration(TimeBuffDuration other) : this() {
      timeMs_ = other.timeMs_;
      isOverride_ = other.isOverride_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeBuffDuration Clone() {
      return new TimeBuffDuration(this);
    }

    /// <summary>Field number for the "time_ms" field.</summary>
    public const int TimeMsFieldNumber = 1;
    private long timeMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TimeMs {
      get { return timeMs_; }
      set {
        timeMs_ = value;
      }
    }

    /// <summary>Field number for the "is_override" field.</summary>
    public const int IsOverrideFieldNumber = 2;
    private bool isOverride_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsOverride {
      get { return isOverride_; }
      set {
        isOverride_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TimeBuffDuration);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TimeBuffDuration other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TimeMs != other.TimeMs) return false;
      if (IsOverride != other.IsOverride) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TimeMs != 0L) hash ^= TimeMs.GetHashCode();
      if (IsOverride != false) hash ^= IsOverride.GetHashCode();
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
      if (TimeMs != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(TimeMs);
      }
      if (IsOverride != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsOverride);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TimeMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TimeMs);
      }
      if (IsOverride != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TimeBuffDuration other) {
      if (other == null) {
        return;
      }
      if (other.TimeMs != 0L) {
        TimeMs = other.TimeMs;
      }
      if (other.IsOverride != false) {
        IsOverride = other.IsOverride;
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
            TimeMs = input.ReadInt64();
            break;
          }
          case 16: {
            IsOverride = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
