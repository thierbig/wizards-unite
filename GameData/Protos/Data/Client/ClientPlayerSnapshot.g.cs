// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientPlayerSnapshot.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientPlayerSnapshot.proto</summary>
  public static partial class ClientPlayerSnapshotReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientPlayerSnapshot.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientPlayerSnapshotReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9XVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRQbGF5ZXJTbmFwc2hvdC5w",
            "cm90bxIUV1VQcm90b3MuRGF0YS5DbGllbnQaI1dVUHJvdG9zL0RhdGEvQnVm",
            "Zi9BY3RpdmVCdWZmLnByb3RvIkUKFENsaWVudFBsYXllclNuYXBzaG90Ei0K",
            "BWJ1ZmZzGAIgAygLMh4uV1VQcm90b3MuRGF0YS5CdWZmLkFjdGl2ZUJ1ZmZi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Buff.ActiveBuffReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientPlayerSnapshot), global::WUProtos.Data.Client.ClientPlayerSnapshot.Parser, new[]{ "Buffs" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientPlayerSnapshot : pb::IMessage<ClientPlayerSnapshot> {
    private static readonly pb::MessageParser<ClientPlayerSnapshot> _parser = new pb::MessageParser<ClientPlayerSnapshot>(() => new ClientPlayerSnapshot());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientPlayerSnapshot> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientPlayerSnapshotReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientPlayerSnapshot() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientPlayerSnapshot(ClientPlayerSnapshot other) : this() {
      buffs_ = other.buffs_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientPlayerSnapshot Clone() {
      return new ClientPlayerSnapshot(this);
    }

    /// <summary>Field number for the "buffs" field.</summary>
    public const int BuffsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::WUProtos.Data.Buff.ActiveBuff> _repeated_buffs_codec
        = pb::FieldCodec.ForMessage(18, global::WUProtos.Data.Buff.ActiveBuff.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.Buff.ActiveBuff> buffs_ = new pbc::RepeatedField<global::WUProtos.Data.Buff.ActiveBuff>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.Buff.ActiveBuff> Buffs {
      get { return buffs_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientPlayerSnapshot);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientPlayerSnapshot other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!buffs_.Equals(other.buffs_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= buffs_.GetHashCode();
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
      buffs_.WriteTo(output, _repeated_buffs_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += buffs_.CalculateSize(_repeated_buffs_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientPlayerSnapshot other) {
      if (other == null) {
        return;
      }
      buffs_.Add(other.buffs_);
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
          case 18: {
            buffs_.AddEntriesFrom(input, _repeated_buffs_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
