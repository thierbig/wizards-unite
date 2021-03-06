// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientTelemetryProfessionNodeSelected.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientTelemetryProfessionNodeSelected.proto</summary>
  public static partial class ClientTelemetryProfessionNodeSelectedReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientTelemetryProfessionNodeSelected.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientTelemetryProfessionNodeSelectedReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRUZWxlbWV0cnlQcm9mZXNz",
            "aW9uTm9kZVNlbGVjdGVkLnByb3RvEhRXVVByb3Rvcy5EYXRhLkNsaWVudBo8",
            "V1VQcm90b3MvRGF0YS9DbGllbnQvQ2xpZW50VGVsZW1ldHJ5UHJvZmVzc2lv",
            "blByb2dyZXNzLnByb3RvIsYBCiVDbGllbnRUZWxlbWV0cnlQcm9mZXNzaW9u",
            "Tm9kZVNlbGVjdGVkEhQKDHBsYXllcl9sZXZlbBgBIAEoBRIgChhhY3RpdmVf",
            "cHJvZmVzc2lvbl9nbXRfaWQYAiABKAkSVAoTcHJvZmVzc2lvbl9wcm9ncmVz",
            "cxgDIAMoCzI3LldVUHJvdG9zLkRhdGEuQ2xpZW50LkNsaWVudFRlbGVtZXRy",
            "eVByb2Zlc3Npb25Qcm9ncmVzcxIPCgdub2RlX2lkGAQgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Client.ClientTelemetryProfessionProgressReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientTelemetryProfessionNodeSelected), global::WUProtos.Data.Client.ClientTelemetryProfessionNodeSelected.Parser, new[]{ "PlayerLevel", "ActiveProfessionGmtId", "ProfessionProgress", "NodeId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientTelemetryProfessionNodeSelected : pb::IMessage<ClientTelemetryProfessionNodeSelected> {
    private static readonly pb::MessageParser<ClientTelemetryProfessionNodeSelected> _parser = new pb::MessageParser<ClientTelemetryProfessionNodeSelected>(() => new ClientTelemetryProfessionNodeSelected());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientTelemetryProfessionNodeSelected> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientTelemetryProfessionNodeSelectedReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryProfessionNodeSelected() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryProfessionNodeSelected(ClientTelemetryProfessionNodeSelected other) : this() {
      playerLevel_ = other.playerLevel_;
      activeProfessionGmtId_ = other.activeProfessionGmtId_;
      professionProgress_ = other.professionProgress_.Clone();
      nodeId_ = other.nodeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryProfessionNodeSelected Clone() {
      return new ClientTelemetryProfessionNodeSelected(this);
    }

    /// <summary>Field number for the "player_level" field.</summary>
    public const int PlayerLevelFieldNumber = 1;
    private int playerLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PlayerLevel {
      get { return playerLevel_; }
      set {
        playerLevel_ = value;
      }
    }

    /// <summary>Field number for the "active_profession_gmt_id" field.</summary>
    public const int ActiveProfessionGmtIdFieldNumber = 2;
    private string activeProfessionGmtId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ActiveProfessionGmtId {
      get { return activeProfessionGmtId_; }
      set {
        activeProfessionGmtId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "profession_progress" field.</summary>
    public const int ProfessionProgressFieldNumber = 3;
    private static readonly pb::FieldCodec<global::WUProtos.Data.Client.ClientTelemetryProfessionProgress> _repeated_professionProgress_codec
        = pb::FieldCodec.ForMessage(26, global::WUProtos.Data.Client.ClientTelemetryProfessionProgress.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.Client.ClientTelemetryProfessionProgress> professionProgress_ = new pbc::RepeatedField<global::WUProtos.Data.Client.ClientTelemetryProfessionProgress>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.Client.ClientTelemetryProfessionProgress> ProfessionProgress {
      get { return professionProgress_; }
    }

    /// <summary>Field number for the "node_id" field.</summary>
    public const int NodeIdFieldNumber = 4;
    private string nodeId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NodeId {
      get { return nodeId_; }
      set {
        nodeId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientTelemetryProfessionNodeSelected);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientTelemetryProfessionNodeSelected other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerLevel != other.PlayerLevel) return false;
      if (ActiveProfessionGmtId != other.ActiveProfessionGmtId) return false;
      if(!professionProgress_.Equals(other.professionProgress_)) return false;
      if (NodeId != other.NodeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerLevel != 0) hash ^= PlayerLevel.GetHashCode();
      if (ActiveProfessionGmtId.Length != 0) hash ^= ActiveProfessionGmtId.GetHashCode();
      hash ^= professionProgress_.GetHashCode();
      if (NodeId.Length != 0) hash ^= NodeId.GetHashCode();
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
      if (PlayerLevel != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PlayerLevel);
      }
      if (ActiveProfessionGmtId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ActiveProfessionGmtId);
      }
      professionProgress_.WriteTo(output, _repeated_professionProgress_codec);
      if (NodeId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(NodeId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlayerLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PlayerLevel);
      }
      if (ActiveProfessionGmtId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ActiveProfessionGmtId);
      }
      size += professionProgress_.CalculateSize(_repeated_professionProgress_codec);
      if (NodeId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NodeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientTelemetryProfessionNodeSelected other) {
      if (other == null) {
        return;
      }
      if (other.PlayerLevel != 0) {
        PlayerLevel = other.PlayerLevel;
      }
      if (other.ActiveProfessionGmtId.Length != 0) {
        ActiveProfessionGmtId = other.ActiveProfessionGmtId;
      }
      professionProgress_.Add(other.professionProgress_);
      if (other.NodeId.Length != 0) {
        NodeId = other.NodeId;
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
            PlayerLevel = input.ReadInt32();
            break;
          }
          case 18: {
            ActiveProfessionGmtId = input.ReadString();
            break;
          }
          case 26: {
            professionProgress_.AddEntriesFrom(input, _repeated_professionProgress_codec);
            break;
          }
          case 34: {
            NodeId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
