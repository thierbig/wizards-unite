// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/InstantFinishBrewingResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/InstantFinishBrewingResponse.proto</summary>
  public static partial class InstantFinishBrewingResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/InstantFinishBrewingResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InstantFinishBrewingResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9JbnN0YW50RmluaXNo",
            "QnJld2luZ1Jlc3BvbnNlLnByb3RvEh1XVVByb3Rvcy5OZXR3b3JraW5nLlJl",
            "c3BvbnNlcyL3AQocSW5zdGFudEZpbmlzaEJyZXdpbmdSZXNwb25zZRJmCgZy",
            "ZXN1bHQYASABKA4yVi5XVVByb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5J",
            "bnN0YW50RmluaXNoQnJld2luZ1Jlc3BvbnNlLkluc3RhbnRGaW5pc2hCcmV3",
            "aW5nUmVzdWx0Im8KGkluc3RhbnRGaW5pc2hCcmV3aW5nUmVzdWx0EgsKB1VO",
            "S05PV04QABILCgdTVUNDRVNTEAESGgoWSU5TVUZGSUNJRU5UX1JFU09VUkNF",
            "UxACEhsKF0VNUFRZX0NBVUxEUk9OX1NFTEVDVEVEEANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.InstantFinishBrewingResponse), global::WUProtos.Networking.Responses.InstantFinishBrewingResponse.Parser, new[]{ "Result" }, null, new[]{ typeof(global::WUProtos.Networking.Responses.InstantFinishBrewingResponse.Types.InstantFinishBrewingResult) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InstantFinishBrewingResponse : pb::IMessage<InstantFinishBrewingResponse> {
    private static readonly pb::MessageParser<InstantFinishBrewingResponse> _parser = new pb::MessageParser<InstantFinishBrewingResponse>(() => new InstantFinishBrewingResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InstantFinishBrewingResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.InstantFinishBrewingResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InstantFinishBrewingResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InstantFinishBrewingResponse(InstantFinishBrewingResponse other) : this() {
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InstantFinishBrewingResponse Clone() {
      return new InstantFinishBrewingResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::WUProtos.Networking.Responses.InstantFinishBrewingResponse.Types.InstantFinishBrewingResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Responses.InstantFinishBrewingResponse.Types.InstantFinishBrewingResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InstantFinishBrewingResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InstantFinishBrewingResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
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
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InstantFinishBrewingResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
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
            Result = (global::WUProtos.Networking.Responses.InstantFinishBrewingResponse.Types.InstantFinishBrewingResult) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the InstantFinishBrewingResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum InstantFinishBrewingResult {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("INSUFFICIENT_RESOURCES")] InsufficientResources = 2,
        [pbr::OriginalName("EMPTY_CAULDRON_SELECTED")] EmptyCauldronSelected = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code