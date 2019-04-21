// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Profession/ProfessionBuffExpiration.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Profession {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Profession/ProfessionBuffExpiration.proto</summary>
  public static partial class ProfessionBuffExpirationReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Profession/ProfessionBuffExpiration.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProfessionBuffExpirationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjdXVVByb3Rvcy9EYXRhL1Byb2Zlc3Npb24vUHJvZmVzc2lvbkJ1ZmZFeHBp",
            "cmF0aW9uLnByb3RvEhhXVVByb3Rvcy5EYXRhLlByb2Zlc3Npb24iNQoYUHJv",
            "ZmVzc2lvbkJ1ZmZFeHBpcmF0aW9uEhkKEXByb2Zlc3Npb25fZ210X2lkGAEg",
            "ASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Profession.ProfessionBuffExpiration), global::WUProtos.Data.Profession.ProfessionBuffExpiration.Parser, new[]{ "ProfessionGmtId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProfessionBuffExpiration : pb::IMessage<ProfessionBuffExpiration> {
    private static readonly pb::MessageParser<ProfessionBuffExpiration> _parser = new pb::MessageParser<ProfessionBuffExpiration>(() => new ProfessionBuffExpiration());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProfessionBuffExpiration> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Profession.ProfessionBuffExpirationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionBuffExpiration() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionBuffExpiration(ProfessionBuffExpiration other) : this() {
      professionGmtId_ = other.professionGmtId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionBuffExpiration Clone() {
      return new ProfessionBuffExpiration(this);
    }

    /// <summary>Field number for the "profession_gmt_id" field.</summary>
    public const int ProfessionGmtIdFieldNumber = 1;
    private string professionGmtId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProfessionGmtId {
      get { return professionGmtId_; }
      set {
        professionGmtId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProfessionBuffExpiration);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProfessionBuffExpiration other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProfessionGmtId != other.ProfessionGmtId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ProfessionGmtId.Length != 0) hash ^= ProfessionGmtId.GetHashCode();
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
      if (ProfessionGmtId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProfessionGmtId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ProfessionGmtId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProfessionGmtId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProfessionBuffExpiration other) {
      if (other == null) {
        return;
      }
      if (other.ProfessionGmtId.Length != 0) {
        ProfessionGmtId = other.ProfessionGmtId;
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
            ProfessionGmtId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
