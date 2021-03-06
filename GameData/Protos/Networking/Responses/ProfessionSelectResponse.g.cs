// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/ProfessionSelectResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/ProfessionSelectResponse.proto</summary>
  public static partial class ProfessionSelectResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/ProfessionSelectResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProfessionSelectResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9Qcm9mZXNzaW9uU2Vs",
            "ZWN0UmVzcG9uc2UucHJvdG8SHVdVUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9u",
            "c2VzIqgCChhQcm9mZXNzaW9uU2VsZWN0UmVzcG9uc2USTgoGc3RhdHVzGAEg",
            "ASgOMj4uV1VQcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuUHJvZmVzc2lv",
            "blNlbGVjdFJlc3BvbnNlLlN0YXR1cyK7AQoGU3RhdHVzEggKBE5PTkUQABIL",
            "CgdTVUNDRVNTEAESHQoZUFJPRkVTU0lPTl9HTVRfSURfSU5WQUxJRBACEhoK",
            "FlBST0ZFU1NJT05fVU5BVkFJTEFCTEUQAxIJCgVFUlJPUhAEEh0KGVBST0ZF",
            "U1NJT05fQUxSRUFEWV9BQ1RJVkUQBRIWChJFUlJPUl9BRERJTkdfQlVGRlMQ",
            "BhIdChlFUlJPUl9QTEFZRVJfSU5fQ0hBTExFTkdFEAdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.ProfessionSelectResponse), global::WUProtos.Networking.Responses.ProfessionSelectResponse.Parser, new[]{ "Status" }, null, new[]{ typeof(global::WUProtos.Networking.Responses.ProfessionSelectResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProfessionSelectResponse : pb::IMessage<ProfessionSelectResponse> {
    private static readonly pb::MessageParser<ProfessionSelectResponse> _parser = new pb::MessageParser<ProfessionSelectResponse>(() => new ProfessionSelectResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProfessionSelectResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.ProfessionSelectResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionSelectResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionSelectResponse(ProfessionSelectResponse other) : this() {
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionSelectResponse Clone() {
      return new ProfessionSelectResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::WUProtos.Networking.Responses.ProfessionSelectResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Responses.ProfessionSelectResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProfessionSelectResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProfessionSelectResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProfessionSelectResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
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
            Status = (global::WUProtos.Networking.Responses.ProfessionSelectResponse.Types.Status) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ProfessionSelectResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("PROFESSION_GMT_ID_INVALID")] ProfessionGmtIdInvalid = 2,
        [pbr::OriginalName("PROFESSION_UNAVAILABLE")] ProfessionUnavailable = 3,
        [pbr::OriginalName("ERROR")] Error = 4,
        [pbr::OriginalName("PROFESSION_ALREADY_ACTIVE")] ProfessionAlreadyActive = 5,
        [pbr::OriginalName("ERROR_ADDING_BUFFS")] ErrorAddingBuffs = 6,
        [pbr::OriginalName("ERROR_PLAYER_IN_CHALLENGE")] ErrorPlayerInChallenge = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
