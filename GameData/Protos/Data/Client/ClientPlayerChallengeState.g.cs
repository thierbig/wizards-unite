// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientPlayerChallengeState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientPlayerChallengeState.proto</summary>
  public static partial class ClientPlayerChallengeStateReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientPlayerChallengeState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientPlayerChallengeStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRQbGF5ZXJDaGFsbGVuZ2VT",
            "dGF0ZS5wcm90bxIUV1VQcm90b3MuRGF0YS5DbGllbnQaJ1dVUHJvdG9zL0Rh",
            "dGEvQ2xpZW50L0NsaWVudE1hcFBvaS5wcm90byJrChpDbGllbnRQbGF5ZXJD",
            "aGFsbGVuZ2VTdGF0ZRITCgtmb3J0cmVzc19pZBgBIAEoCRI4Cgxmb3J0cmVz",
            "c19wb2kYAiABKAsyIi5XVVByb3Rvcy5EYXRhLkNsaWVudC5DbGllbnRNYXBQ",
            "b2liBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Client.ClientMapPoiReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientPlayerChallengeState), global::WUProtos.Data.Client.ClientPlayerChallengeState.Parser, new[]{ "FortressId", "FortressPoi" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientPlayerChallengeState : pb::IMessage<ClientPlayerChallengeState> {
    private static readonly pb::MessageParser<ClientPlayerChallengeState> _parser = new pb::MessageParser<ClientPlayerChallengeState>(() => new ClientPlayerChallengeState());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientPlayerChallengeState> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientPlayerChallengeStateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientPlayerChallengeState() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientPlayerChallengeState(ClientPlayerChallengeState other) : this() {
      fortressId_ = other.fortressId_;
      fortressPoi_ = other.fortressPoi_ != null ? other.fortressPoi_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientPlayerChallengeState Clone() {
      return new ClientPlayerChallengeState(this);
    }

    /// <summary>Field number for the "fortress_id" field.</summary>
    public const int FortressIdFieldNumber = 1;
    private string fortressId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FortressId {
      get { return fortressId_; }
      set {
        fortressId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fortress_poi" field.</summary>
    public const int FortressPoiFieldNumber = 2;
    private global::WUProtos.Data.Client.ClientMapPoi fortressPoi_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Client.ClientMapPoi FortressPoi {
      get { return fortressPoi_; }
      set {
        fortressPoi_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientPlayerChallengeState);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientPlayerChallengeState other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FortressId != other.FortressId) return false;
      if (!object.Equals(FortressPoi, other.FortressPoi)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FortressId.Length != 0) hash ^= FortressId.GetHashCode();
      if (fortressPoi_ != null) hash ^= FortressPoi.GetHashCode();
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
      if (FortressId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FortressId);
      }
      if (fortressPoi_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(FortressPoi);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FortressId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FortressId);
      }
      if (fortressPoi_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FortressPoi);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientPlayerChallengeState other) {
      if (other == null) {
        return;
      }
      if (other.FortressId.Length != 0) {
        FortressId = other.FortressId;
      }
      if (other.fortressPoi_ != null) {
        if (fortressPoi_ == null) {
          FortressPoi = new global::WUProtos.Data.Client.ClientMapPoi();
        }
        FortressPoi.MergeFrom(other.FortressPoi);
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
            FortressId = input.ReadString();
            break;
          }
          case 18: {
            if (fortressPoi_ == null) {
              FortressPoi = new global::WUProtos.Data.Client.ClientMapPoi();
            }
            input.ReadMessage(FortressPoi);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
