// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/ProxyResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/ProxyResponse.proto</summary>
  public static partial class ProxyResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/ProxyResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProxyResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9Qcm94eVJlc3BvbnNl",
            "LnByb3RvEh1XVVByb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcyLUAgoNUHJv",
            "eHlSZXNwb25zZRJDCgZzdGF0dXMYASABKA4yMy5XVVByb3Rvcy5OZXR3b3Jr",
            "aW5nLlJlc3BvbnNlcy5Qcm94eVJlc3BvbnNlLlN0YXR1cxIVCg1hc3NpZ25l",
            "ZF9ob3N0GAIgASgJEg8KB3BheWxvYWQYAyABKAwi1QEKBlN0YXR1cxIJCgVV",
            "TlNFVBAAEg0KCUNPTVBMRVRFRBABEhwKGENPTVBMRVRFRF9BTkRfUkVBU1NJ",
            "R05FRBACEhQKEEFDVElPTl9OT1RfRk9VTkQQAxIUChBBU1NJR05NRU5UX0VS",
            "Uk9SEAQSHAoYUFJPWFlfVU5BVVRIT1JJWkVEX0VSUk9SEAUSEgoOSU5URVJO",
            "QUxfRVJST1IQBhIPCgtCQURfUkVRVUVTVBAHEhEKDUFDQ0VTU19ERU5JRUQQ",
            "CBIRCg1USU1FT1VUX0VSUk9SEAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.ProxyResponse), global::WUProtos.Networking.Responses.ProxyResponse.Parser, new[]{ "Status", "AssignedHost", "Payload" }, null, new[]{ typeof(global::WUProtos.Networking.Responses.ProxyResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProxyResponse : pb::IMessage<ProxyResponse> {
    private static readonly pb::MessageParser<ProxyResponse> _parser = new pb::MessageParser<ProxyResponse>(() => new ProxyResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProxyResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.ProxyResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProxyResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProxyResponse(ProxyResponse other) : this() {
      status_ = other.status_;
      assignedHost_ = other.assignedHost_;
      payload_ = other.payload_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProxyResponse Clone() {
      return new ProxyResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::WUProtos.Networking.Responses.ProxyResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Responses.ProxyResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "assigned_host" field.</summary>
    public const int AssignedHostFieldNumber = 2;
    private string assignedHost_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AssignedHost {
      get { return assignedHost_; }
      set {
        assignedHost_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 3;
    private pb::ByteString payload_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Payload {
      get { return payload_; }
      set {
        payload_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProxyResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProxyResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (AssignedHost != other.AssignedHost) return false;
      if (Payload != other.Payload) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (AssignedHost.Length != 0) hash ^= AssignedHost.GetHashCode();
      if (Payload.Length != 0) hash ^= Payload.GetHashCode();
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
      if (AssignedHost.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AssignedHost);
      }
      if (Payload.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Payload);
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
      if (AssignedHost.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AssignedHost);
      }
      if (Payload.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Payload);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProxyResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.AssignedHost.Length != 0) {
        AssignedHost = other.AssignedHost;
      }
      if (other.Payload.Length != 0) {
        Payload = other.Payload;
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
            Status = (global::WUProtos.Networking.Responses.ProxyResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            AssignedHost = input.ReadString();
            break;
          }
          case 26: {
            Payload = input.ReadBytes();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ProxyResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("COMPLETED")] Completed = 1,
        [pbr::OriginalName("COMPLETED_AND_REASSIGNED")] CompletedAndReassigned = 2,
        [pbr::OriginalName("ACTION_NOT_FOUND")] ActionNotFound = 3,
        [pbr::OriginalName("ASSIGNMENT_ERROR")] AssignmentError = 4,
        [pbr::OriginalName("PROXY_UNAUTHORIZED_ERROR")] ProxyUnauthorizedError = 5,
        [pbr::OriginalName("INTERNAL_ERROR")] InternalError = 6,
        [pbr::OriginalName("BAD_REQUEST")] BadRequest = 7,
        [pbr::OriginalName("ACCESS_DENIED")] AccessDenied = 8,
        [pbr::OriginalName("TIMEOUT_ERROR")] TimeoutError = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
