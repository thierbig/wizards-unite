// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/QualityLevel.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/QualityLevel.proto</summary>
  public static partial class QualityLevelReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/QualityLevel.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QualityLevelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBXVVByb3Rvcy9EYXRhL1F1YWxpdHlMZXZlbC5wcm90bxINV1VQcm90b3Mu",
            "RGF0YRomV1VQcm90b3MvRGF0YS9TaGFyZWRRdWFsaXR5TGV2ZWwucHJvdG8i",
            "rgIKDFF1YWxpdHlMZXZlbBIKCgJpZBgBIAEoCRI4Cg1xdWFsaXR5X2xldmVs",
            "GAIgASgLMiEuV1VQcm90b3MuRGF0YS5TaGFyZWRRdWFsaXR5TGV2ZWwiQgoT",
            "QW50aWFsaWFzaW5nU2V0dGluZxIHCgNvZmYQABIKCgZtc2FhMngQAhIKCgZt",
            "c2FhNHgQBBIKCgZtc2FhOHgQCCJfChZSZWFsdGltZVNoYWRvd3NTZXR0aW5n",
            "EggKBG9mZmYQABITCg9yZWFsdGltZV9wbGFuYXIQARImCiJyZWFsdGltZV9w",
            "bGFuYXJfYW5kX3NlbGZfc2hhZG93aW5nEAIiMwoVVGV4dHVyZVF1YWxpdHlT",
            "ZXR0aW5nEgwKCGZ1bGxfcmVzEAASDAoIaGFsZl9yZXMQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.SharedQualityLevelReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.QualityLevel), global::WUProtos.Data.QualityLevel.Parser, new[]{ "Id", "QualityLevel_" }, null, new[]{ typeof(global::WUProtos.Data.QualityLevel.Types.AntialiasingSetting), typeof(global::WUProtos.Data.QualityLevel.Types.RealtimeShadowsSetting), typeof(global::WUProtos.Data.QualityLevel.Types.TextureQualitySetting) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class QualityLevel : pb::IMessage<QualityLevel> {
    private static readonly pb::MessageParser<QualityLevel> _parser = new pb::MessageParser<QualityLevel>(() => new QualityLevel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QualityLevel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.QualityLevelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QualityLevel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QualityLevel(QualityLevel other) : this() {
      id_ = other.id_;
      qualityLevel_ = other.qualityLevel_ != null ? other.qualityLevel_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QualityLevel Clone() {
      return new QualityLevel(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "quality_level" field.</summary>
    public const int QualityLevel_FieldNumber = 2;
    private global::WUProtos.Data.SharedQualityLevel qualityLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.SharedQualityLevel QualityLevel_ {
      get { return qualityLevel_; }
      set {
        qualityLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QualityLevel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QualityLevel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(QualityLevel_, other.QualityLevel_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (qualityLevel_ != null) hash ^= QualityLevel_.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (qualityLevel_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(QualityLevel_);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (qualityLevel_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(QualityLevel_);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QualityLevel other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.qualityLevel_ != null) {
        if (qualityLevel_ == null) {
          QualityLevel_ = new global::WUProtos.Data.SharedQualityLevel();
        }
        QualityLevel_.MergeFrom(other.QualityLevel_);
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
            if (qualityLevel_ == null) {
              QualityLevel_ = new global::WUProtos.Data.SharedQualityLevel();
            }
            input.ReadMessage(QualityLevel_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the QualityLevel message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum AntialiasingSetting {
        [pbr::OriginalName("off")] Off = 0,
        [pbr::OriginalName("msaa2x")] Msaa2X = 2,
        [pbr::OriginalName("msaa4x")] Msaa4X = 4,
        [pbr::OriginalName("msaa8x")] Msaa8X = 8,
      }

      public enum RealtimeShadowsSetting {
        [pbr::OriginalName("offf")] Offf = 0,
        [pbr::OriginalName("realtime_planar")] RealtimePlanar = 1,
        [pbr::OriginalName("realtime_planar_and_self_shadowing")] RealtimePlanarAndSelfShadowing = 2,
      }

      public enum TextureQualitySetting {
        [pbr::OriginalName("full_res")] FullRes = 0,
        [pbr::OriginalName("half_res")] HalfRes = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
