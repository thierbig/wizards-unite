// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/LeaveChamberResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/LeaveChamberResponse.proto</summary>
  public static partial class LeaveChamberResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/LeaveChamberResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LeaveChamberResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjhXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9MZWF2ZUNoYW1iZXJS",
            "ZXNwb25zZS5wcm90bxIdV1VQcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMa",
            "J1dVUHJvdG9zL0VudW1zL0NoYWxsZW5nZVJwY1N0YXR1cy5wcm90byJzChRM",
            "ZWF2ZUNoYW1iZXJSZXNwb25zZRIyCgZzdGF0dXMYASABKA4yIi5XVVByb3Rv",
            "cy5FbnVtcy5DaGFsbGVuZ2VScGNTdGF0dXMSEgoKcGFydG5lcl9pZBgCIAEo",
            "CRITCgtmb3J0cmVzc19pZBgDIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Enums.ChallengeRpcStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.LeaveChamberResponse), global::WUProtos.Networking.Responses.LeaveChamberResponse.Parser, new[]{ "Status", "PartnerId", "FortressId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LeaveChamberResponse : pb::IMessage<LeaveChamberResponse> {
    private static readonly pb::MessageParser<LeaveChamberResponse> _parser = new pb::MessageParser<LeaveChamberResponse>(() => new LeaveChamberResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LeaveChamberResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.LeaveChamberResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LeaveChamberResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LeaveChamberResponse(LeaveChamberResponse other) : this() {
      status_ = other.status_;
      partnerId_ = other.partnerId_;
      fortressId_ = other.fortressId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LeaveChamberResponse Clone() {
      return new LeaveChamberResponse(this);
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

    /// <summary>Field number for the "partner_id" field.</summary>
    public const int PartnerIdFieldNumber = 2;
    private string partnerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PartnerId {
      get { return partnerId_; }
      set {
        partnerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fortress_id" field.</summary>
    public const int FortressIdFieldNumber = 3;
    private string fortressId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FortressId {
      get { return fortressId_; }
      set {
        fortressId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LeaveChamberResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LeaveChamberResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (PartnerId != other.PartnerId) return false;
      if (FortressId != other.FortressId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (PartnerId.Length != 0) hash ^= PartnerId.GetHashCode();
      if (FortressId.Length != 0) hash ^= FortressId.GetHashCode();
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
      if (PartnerId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PartnerId);
      }
      if (FortressId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(FortressId);
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
      if (PartnerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PartnerId);
      }
      if (FortressId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FortressId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LeaveChamberResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.PartnerId.Length != 0) {
        PartnerId = other.PartnerId;
      }
      if (other.FortressId.Length != 0) {
        FortressId = other.FortressId;
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
            PartnerId = input.ReadString();
            break;
          }
          case 26: {
            FortressId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
