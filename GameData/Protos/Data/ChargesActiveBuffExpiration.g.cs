// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/ChargesActiveBuffExpiration.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/ChargesActiveBuffExpiration.proto</summary>
  public static partial class ChargesActiveBuffExpirationReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/ChargesActiveBuffExpiration.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChargesActiveBuffExpirationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9XVVByb3Rvcy9EYXRhL0NoYXJnZXNBY3RpdmVCdWZmRXhwaXJhdGlvbi5w",
            "cm90bxINV1VQcm90b3MuRGF0YSJOChtDaGFyZ2VzQWN0aXZlQnVmZkV4cGly",
            "YXRpb24SFAoMZW5jb3VudGVyX2lkGAEgASgMEhkKEXJlbWFpbmluZ19jaGFy",
            "Z2VzGAIgASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.ChargesActiveBuffExpiration), global::WUProtos.Data.ChargesActiveBuffExpiration.Parser, new[]{ "EncounterId", "RemainingCharges" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChargesActiveBuffExpiration : pb::IMessage<ChargesActiveBuffExpiration> {
    private static readonly pb::MessageParser<ChargesActiveBuffExpiration> _parser = new pb::MessageParser<ChargesActiveBuffExpiration>(() => new ChargesActiveBuffExpiration());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChargesActiveBuffExpiration> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.ChargesActiveBuffExpirationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChargesActiveBuffExpiration() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChargesActiveBuffExpiration(ChargesActiveBuffExpiration other) : this() {
      encounterId_ = other.encounterId_;
      remainingCharges_ = other.remainingCharges_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChargesActiveBuffExpiration Clone() {
      return new ChargesActiveBuffExpiration(this);
    }

    /// <summary>Field number for the "encounter_id" field.</summary>
    public const int EncounterIdFieldNumber = 1;
    private pb::ByteString encounterId_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString EncounterId {
      get { return encounterId_; }
      set {
        encounterId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "remaining_charges" field.</summary>
    public const int RemainingChargesFieldNumber = 2;
    private int remainingCharges_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RemainingCharges {
      get { return remainingCharges_; }
      set {
        remainingCharges_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChargesActiveBuffExpiration);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChargesActiveBuffExpiration other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EncounterId != other.EncounterId) return false;
      if (RemainingCharges != other.RemainingCharges) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EncounterId.Length != 0) hash ^= EncounterId.GetHashCode();
      if (RemainingCharges != 0) hash ^= RemainingCharges.GetHashCode();
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
      if (EncounterId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(EncounterId);
      }
      if (RemainingCharges != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(RemainingCharges);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EncounterId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(EncounterId);
      }
      if (RemainingCharges != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RemainingCharges);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChargesActiveBuffExpiration other) {
      if (other == null) {
        return;
      }
      if (other.EncounterId.Length != 0) {
        EncounterId = other.EncounterId;
      }
      if (other.RemainingCharges != 0) {
        RemainingCharges = other.RemainingCharges;
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
            EncounterId = input.ReadBytes();
            break;
          }
          case 16: {
            RemainingCharges = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
