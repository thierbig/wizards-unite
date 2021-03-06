// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/ClaimChamberRewardsResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/ClaimChamberRewardsResponse.proto</summary>
  public static partial class ClaimChamberRewardsResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/ClaimChamberRewardsResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClaimChamberRewardsResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9XVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9DbGFpbUNoYW1iZXJS",
            "ZXdhcmRzUmVzcG9uc2UucHJvdG8SHVdVUHJvdG9zLk5ldHdvcmtpbmcuUmVz",
            "cG9uc2VzGidXVVByb3Rvcy9FbnVtcy9DaGFsbGVuZ2VScGNTdGF0dXMucHJv",
            "dG8aIFdVUHJvdG9zL0RhdGEvQ2hhbWJlclN0YXRlLnByb3RvGi9XVVByb3Rv",
            "cy9EYXRhL0NsaWVudC9DbGllbnRQbGF5ZXJTbmFwc2hvdC5wcm90byLCAQob",
            "Q2xhaW1DaGFtYmVyUmV3YXJkc1Jlc3BvbnNlEjIKBnN0YXR1cxgBIAEoDjIi",
            "LldVUHJvdG9zLkVudW1zLkNoYWxsZW5nZVJwY1N0YXR1cxIqCgVzdGF0ZRgC",
            "IAEoCzIbLldVUHJvdG9zLkRhdGEuQ2hhbWJlclN0YXRlEkMKD3BsYXllcl9z",
            "bmFwc2hvdBgDIAEoCzIqLldVUHJvdG9zLkRhdGEuQ2xpZW50LkNsaWVudFBs",
            "YXllclNuYXBzaG90YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Enums.ChallengeRpcStatusReflection.Descriptor, global::WUProtos.Data.ChamberStateReflection.Descriptor, global::WUProtos.Data.Client.ClientPlayerSnapshotReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.ClaimChamberRewardsResponse), global::WUProtos.Networking.Responses.ClaimChamberRewardsResponse.Parser, new[]{ "Status", "State", "PlayerSnapshot" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClaimChamberRewardsResponse : pb::IMessage<ClaimChamberRewardsResponse> {
    private static readonly pb::MessageParser<ClaimChamberRewardsResponse> _parser = new pb::MessageParser<ClaimChamberRewardsResponse>(() => new ClaimChamberRewardsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClaimChamberRewardsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.ClaimChamberRewardsResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClaimChamberRewardsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClaimChamberRewardsResponse(ClaimChamberRewardsResponse other) : this() {
      status_ = other.status_;
      state_ = other.state_ != null ? other.state_.Clone() : null;
      playerSnapshot_ = other.playerSnapshot_ != null ? other.playerSnapshot_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClaimChamberRewardsResponse Clone() {
      return new ClaimChamberRewardsResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::WUProtos.Enums.ChallengeRpcStatus status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Enums.ChallengeRpcStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 2;
    private global::WUProtos.Data.ChamberState state_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.ChamberState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "player_snapshot" field.</summary>
    public const int PlayerSnapshotFieldNumber = 3;
    private global::WUProtos.Data.Client.ClientPlayerSnapshot playerSnapshot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Client.ClientPlayerSnapshot PlayerSnapshot {
      get { return playerSnapshot_; }
      set {
        playerSnapshot_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClaimChamberRewardsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClaimChamberRewardsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (!object.Equals(State, other.State)) return false;
      if (!object.Equals(PlayerSnapshot, other.PlayerSnapshot)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (state_ != null) hash ^= State.GetHashCode();
      if (playerSnapshot_ != null) hash ^= PlayerSnapshot.GetHashCode();
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
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (state_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(State);
      }
      if (playerSnapshot_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PlayerSnapshot);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (state_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(State);
      }
      if (playerSnapshot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerSnapshot);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClaimChamberRewardsResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.state_ != null) {
        if (state_ == null) {
          State = new global::WUProtos.Data.ChamberState();
        }
        State.MergeFrom(other.State);
      }
      if (other.playerSnapshot_ != null) {
        if (playerSnapshot_ == null) {
          PlayerSnapshot = new global::WUProtos.Data.Client.ClientPlayerSnapshot();
        }
        PlayerSnapshot.MergeFrom(other.PlayerSnapshot);
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
            Status = (global::WUProtos.Enums.ChallengeRpcStatus) input.ReadEnum();
            break;
          }
          case 18: {
            if (state_ == null) {
              State = new global::WUProtos.Data.ChamberState();
            }
            input.ReadMessage(State);
            break;
          }
          case 26: {
            if (playerSnapshot_ == null) {
              PlayerSnapshot = new global::WUProtos.Data.Client.ClientPlayerSnapshot();
            }
            input.ReadMessage(PlayerSnapshot);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
