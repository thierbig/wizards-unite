// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/FeatureFlag.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/FeatureFlag.proto</summary>
  public static partial class FeatureFlagReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/FeatureFlag.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeatureFlagReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9XVVByb3Rvcy9EYXRhL0ZlYXR1cmVGbGFnLnByb3RvEg1XVVByb3Rvcy5E",
            "YXRhIoEBCgtGZWF0dXJlRmxhZxIMCgJpZBgBIAEoCUgAEhQKCmZlYXR1cmVf",
            "aWQYAiABKAlIABIOCgRidmFsGAMgASgISAASDgoEbHZhbBgEIAEoA0gAEg4K",
            "BHN2YWwYBSABKAlIABIOCgRmdmFsGAYgASgCSABCDgoMRGVmYXVsdFZhbHVl",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.FeatureFlag), global::WUProtos.Data.FeatureFlag.Parser, new[]{ "Id", "FeatureId", "Bval", "Lval", "Sval", "Fval" }, new[]{ "DefaultValue" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FeatureFlag : pb::IMessage<FeatureFlag> {
    private static readonly pb::MessageParser<FeatureFlag> _parser = new pb::MessageParser<FeatureFlag>(() => new FeatureFlag());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FeatureFlag> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.FeatureFlagReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeatureFlag() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeatureFlag(FeatureFlag other) : this() {
      switch (other.DefaultValueCase) {
        case DefaultValueOneofCase.Id:
          Id = other.Id;
          break;
        case DefaultValueOneofCase.FeatureId:
          FeatureId = other.FeatureId;
          break;
        case DefaultValueOneofCase.Bval:
          Bval = other.Bval;
          break;
        case DefaultValueOneofCase.Lval:
          Lval = other.Lval;
          break;
        case DefaultValueOneofCase.Sval:
          Sval = other.Sval;
          break;
        case DefaultValueOneofCase.Fval:
          Fval = other.Fval;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeatureFlag Clone() {
      return new FeatureFlag(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return defaultValueCase_ == DefaultValueOneofCase.Id ? (string) defaultValue_ : ""; }
      set {
        defaultValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        defaultValueCase_ = DefaultValueOneofCase.Id;
      }
    }

    /// <summary>Field number for the "feature_id" field.</summary>
    public const int FeatureIdFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FeatureId {
      get { return defaultValueCase_ == DefaultValueOneofCase.FeatureId ? (string) defaultValue_ : ""; }
      set {
        defaultValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        defaultValueCase_ = DefaultValueOneofCase.FeatureId;
      }
    }

    /// <summary>Field number for the "bval" field.</summary>
    public const int BvalFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Bval {
      get { return defaultValueCase_ == DefaultValueOneofCase.Bval ? (bool) defaultValue_ : false; }
      set {
        defaultValue_ = value;
        defaultValueCase_ = DefaultValueOneofCase.Bval;
      }
    }

    /// <summary>Field number for the "lval" field.</summary>
    public const int LvalFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Lval {
      get { return defaultValueCase_ == DefaultValueOneofCase.Lval ? (long) defaultValue_ : 0L; }
      set {
        defaultValue_ = value;
        defaultValueCase_ = DefaultValueOneofCase.Lval;
      }
    }

    /// <summary>Field number for the "sval" field.</summary>
    public const int SvalFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Sval {
      get { return defaultValueCase_ == DefaultValueOneofCase.Sval ? (string) defaultValue_ : ""; }
      set {
        defaultValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        defaultValueCase_ = DefaultValueOneofCase.Sval;
      }
    }

    /// <summary>Field number for the "fval" field.</summary>
    public const int FvalFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Fval {
      get { return defaultValueCase_ == DefaultValueOneofCase.Fval ? (float) defaultValue_ : 0F; }
      set {
        defaultValue_ = value;
        defaultValueCase_ = DefaultValueOneofCase.Fval;
      }
    }

    private object defaultValue_;
    /// <summary>Enum of possible cases for the "DefaultValue" oneof.</summary>
    public enum DefaultValueOneofCase {
      None = 0,
      Id = 1,
      FeatureId = 2,
      Bval = 3,
      Lval = 4,
      Sval = 5,
      Fval = 6,
    }
    private DefaultValueOneofCase defaultValueCase_ = DefaultValueOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DefaultValueOneofCase DefaultValueCase {
      get { return defaultValueCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearDefaultValue() {
      defaultValueCase_ = DefaultValueOneofCase.None;
      defaultValue_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FeatureFlag);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FeatureFlag other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (FeatureId != other.FeatureId) return false;
      if (Bval != other.Bval) return false;
      if (Lval != other.Lval) return false;
      if (Sval != other.Sval) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Fval, other.Fval)) return false;
      if (DefaultValueCase != other.DefaultValueCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (defaultValueCase_ == DefaultValueOneofCase.Id) hash ^= Id.GetHashCode();
      if (defaultValueCase_ == DefaultValueOneofCase.FeatureId) hash ^= FeatureId.GetHashCode();
      if (defaultValueCase_ == DefaultValueOneofCase.Bval) hash ^= Bval.GetHashCode();
      if (defaultValueCase_ == DefaultValueOneofCase.Lval) hash ^= Lval.GetHashCode();
      if (defaultValueCase_ == DefaultValueOneofCase.Sval) hash ^= Sval.GetHashCode();
      if (defaultValueCase_ == DefaultValueOneofCase.Fval) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Fval);
      hash ^= (int) defaultValueCase_;
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
      if (defaultValueCase_ == DefaultValueOneofCase.Id) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (defaultValueCase_ == DefaultValueOneofCase.FeatureId) {
        output.WriteRawTag(18);
        output.WriteString(FeatureId);
      }
      if (defaultValueCase_ == DefaultValueOneofCase.Bval) {
        output.WriteRawTag(24);
        output.WriteBool(Bval);
      }
      if (defaultValueCase_ == DefaultValueOneofCase.Lval) {
        output.WriteRawTag(32);
        output.WriteInt64(Lval);
      }
      if (defaultValueCase_ == DefaultValueOneofCase.Sval) {
        output.WriteRawTag(42);
        output.WriteString(Sval);
      }
      if (defaultValueCase_ == DefaultValueOneofCase.Fval) {
        output.WriteRawTag(53);
        output.WriteFloat(Fval);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (defaultValueCase_ == DefaultValueOneofCase.Id) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (defaultValueCase_ == DefaultValueOneofCase.FeatureId) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FeatureId);
      }
      if (defaultValueCase_ == DefaultValueOneofCase.Bval) {
        size += 1 + 1;
      }
      if (defaultValueCase_ == DefaultValueOneofCase.Lval) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Lval);
      }
      if (defaultValueCase_ == DefaultValueOneofCase.Sval) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Sval);
      }
      if (defaultValueCase_ == DefaultValueOneofCase.Fval) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FeatureFlag other) {
      if (other == null) {
        return;
      }
      switch (other.DefaultValueCase) {
        case DefaultValueOneofCase.Id:
          Id = other.Id;
          break;
        case DefaultValueOneofCase.FeatureId:
          FeatureId = other.FeatureId;
          break;
        case DefaultValueOneofCase.Bval:
          Bval = other.Bval;
          break;
        case DefaultValueOneofCase.Lval:
          Lval = other.Lval;
          break;
        case DefaultValueOneofCase.Sval:
          Sval = other.Sval;
          break;
        case DefaultValueOneofCase.Fval:
          Fval = other.Fval;
          break;
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
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            FeatureId = input.ReadString();
            break;
          }
          case 24: {
            Bval = input.ReadBool();
            break;
          }
          case 32: {
            Lval = input.ReadInt64();
            break;
          }
          case 42: {
            Sval = input.ReadString();
            break;
          }
          case 53: {
            Fval = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
