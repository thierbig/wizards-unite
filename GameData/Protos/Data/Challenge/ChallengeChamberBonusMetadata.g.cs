// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Challenge/ChallengeChamberBonusMetadata.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Challenge {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Challenge/ChallengeChamberBonusMetadata.proto</summary>
  public static partial class ChallengeChamberBonusMetadataReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Challenge/ChallengeChamberBonusMetadata.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChallengeChamberBonusMetadataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjtXVVByb3Rvcy9EYXRhL0NoYWxsZW5nZS9DaGFsbGVuZ2VDaGFtYmVyQm9u",
            "dXNNZXRhZGF0YS5wcm90bxIXV1VQcm90b3MuRGF0YS5DaGFsbGVuZ2UiQAod",
            "Q2hhbGxlbmdlQ2hhbWJlckJvbnVzTWV0YWRhdGESHwoXY2hhbWJlcl90ZW1w",
            "bGF0ZV9nbXRfaWQYASABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Challenge.ChallengeChamberBonusMetadata), global::WUProtos.Data.Challenge.ChallengeChamberBonusMetadata.Parser, new[]{ "ChamberTemplateGmtId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChallengeChamberBonusMetadata : pb::IMessage<ChallengeChamberBonusMetadata> {
    private static readonly pb::MessageParser<ChallengeChamberBonusMetadata> _parser = new pb::MessageParser<ChallengeChamberBonusMetadata>(() => new ChallengeChamberBonusMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChallengeChamberBonusMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Challenge.ChallengeChamberBonusMetadataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChallengeChamberBonusMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChallengeChamberBonusMetadata(ChallengeChamberBonusMetadata other) : this() {
      chamberTemplateGmtId_ = other.chamberTemplateGmtId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChallengeChamberBonusMetadata Clone() {
      return new ChallengeChamberBonusMetadata(this);
    }

    /// <summary>Field number for the "chamber_template_gmt_id" field.</summary>
    public const int ChamberTemplateGmtIdFieldNumber = 1;
    private string chamberTemplateGmtId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ChamberTemplateGmtId {
      get { return chamberTemplateGmtId_; }
      set {
        chamberTemplateGmtId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChallengeChamberBonusMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChallengeChamberBonusMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChamberTemplateGmtId != other.ChamberTemplateGmtId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ChamberTemplateGmtId.Length != 0) hash ^= ChamberTemplateGmtId.GetHashCode();
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
      if (ChamberTemplateGmtId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ChamberTemplateGmtId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ChamberTemplateGmtId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ChamberTemplateGmtId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChallengeChamberBonusMetadata other) {
      if (other == null) {
        return;
      }
      if (other.ChamberTemplateGmtId.Length != 0) {
        ChamberTemplateGmtId = other.ChamberTemplateGmtId;
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
            ChamberTemplateGmtId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
