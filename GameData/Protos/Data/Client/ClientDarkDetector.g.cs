// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientDarkDetector.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientDarkDetector.proto</summary>
  public static partial class ClientDarkDetectorReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientDarkDetector.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientDarkDetectorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1XVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnREYXJrRGV0ZWN0b3IucHJv",
            "dG8SFFdVUHJvdG9zLkRhdGEuQ2xpZW50IocBChJDbGllbnREYXJrRGV0ZWN0",
            "b3ISHAoUZGFya19kZXRlY3Rvcl9nbXRfaWQYASABKAkSEwoLZW5kX3RpbWVf",
            "bXMYAiABKAMSGwoTZGVwbG95aW5nX3BsYXllcl9pZBgDIAEoCRIhChlkZXBs",
            "b3lpbmdfcGxheWVyX25pY2tuYW1lGAQgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientDarkDetector), global::WUProtos.Data.Client.ClientDarkDetector.Parser, new[]{ "DarkDetectorGmtId", "EndTimeMs", "DeployingPlayerId", "DeployingPlayerNickname" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientDarkDetector : pb::IMessage<ClientDarkDetector> {
    private static readonly pb::MessageParser<ClientDarkDetector> _parser = new pb::MessageParser<ClientDarkDetector>(() => new ClientDarkDetector());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientDarkDetector> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientDarkDetectorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientDarkDetector() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientDarkDetector(ClientDarkDetector other) : this() {
      darkDetectorGmtId_ = other.darkDetectorGmtId_;
      endTimeMs_ = other.endTimeMs_;
      deployingPlayerId_ = other.deployingPlayerId_;
      deployingPlayerNickname_ = other.deployingPlayerNickname_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientDarkDetector Clone() {
      return new ClientDarkDetector(this);
    }

    /// <summary>Field number for the "dark_detector_gmt_id" field.</summary>
    public const int DarkDetectorGmtIdFieldNumber = 1;
    private string darkDetectorGmtId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DarkDetectorGmtId {
      get { return darkDetectorGmtId_; }
      set {
        darkDetectorGmtId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "end_time_ms" field.</summary>
    public const int EndTimeMsFieldNumber = 2;
    private long endTimeMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long EndTimeMs {
      get { return endTimeMs_; }
      set {
        endTimeMs_ = value;
      }
    }

    /// <summary>Field number for the "deploying_player_id" field.</summary>
    public const int DeployingPlayerIdFieldNumber = 3;
    private string deployingPlayerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeployingPlayerId {
      get { return deployingPlayerId_; }
      set {
        deployingPlayerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "deploying_player_nickname" field.</summary>
    public const int DeployingPlayerNicknameFieldNumber = 4;
    private string deployingPlayerNickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeployingPlayerNickname {
      get { return deployingPlayerNickname_; }
      set {
        deployingPlayerNickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientDarkDetector);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientDarkDetector other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DarkDetectorGmtId != other.DarkDetectorGmtId) return false;
      if (EndTimeMs != other.EndTimeMs) return false;
      if (DeployingPlayerId != other.DeployingPlayerId) return false;
      if (DeployingPlayerNickname != other.DeployingPlayerNickname) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DarkDetectorGmtId.Length != 0) hash ^= DarkDetectorGmtId.GetHashCode();
      if (EndTimeMs != 0L) hash ^= EndTimeMs.GetHashCode();
      if (DeployingPlayerId.Length != 0) hash ^= DeployingPlayerId.GetHashCode();
      if (DeployingPlayerNickname.Length != 0) hash ^= DeployingPlayerNickname.GetHashCode();
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
      if (DarkDetectorGmtId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DarkDetectorGmtId);
      }
      if (EndTimeMs != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(EndTimeMs);
      }
      if (DeployingPlayerId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DeployingPlayerId);
      }
      if (DeployingPlayerNickname.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DeployingPlayerNickname);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DarkDetectorGmtId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DarkDetectorGmtId);
      }
      if (EndTimeMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(EndTimeMs);
      }
      if (DeployingPlayerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeployingPlayerId);
      }
      if (DeployingPlayerNickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeployingPlayerNickname);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientDarkDetector other) {
      if (other == null) {
        return;
      }
      if (other.DarkDetectorGmtId.Length != 0) {
        DarkDetectorGmtId = other.DarkDetectorGmtId;
      }
      if (other.EndTimeMs != 0L) {
        EndTimeMs = other.EndTimeMs;
      }
      if (other.DeployingPlayerId.Length != 0) {
        DeployingPlayerId = other.DeployingPlayerId;
      }
      if (other.DeployingPlayerNickname.Length != 0) {
        DeployingPlayerNickname = other.DeployingPlayerNickname;
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
            DarkDetectorGmtId = input.ReadString();
            break;
          }
          case 16: {
            EndTimeMs = input.ReadInt64();
            break;
          }
          case 26: {
            DeployingPlayerId = input.ReadString();
            break;
          }
          case 34: {
            DeployingPlayerNickname = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
