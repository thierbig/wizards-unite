// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/SetPlayerFlagToDefaultResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/SetPlayerFlagToDefaultResponse.proto</summary>
  public static partial class SetPlayerFlagToDefaultResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/SetPlayerFlagToDefaultResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetPlayerFlagToDefaultResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9TZXRQbGF5ZXJGbGFn",
            "VG9EZWZhdWx0UmVzcG9uc2UucHJvdG8SHVdVUHJvdG9zLk5ldHdvcmtpbmcu",
            "UmVzcG9uc2VzIjYKHlNldFBsYXllckZsYWdUb0RlZmF1bHRSZXNwb25zZRIU",
            "CgxkaWRfc2V0X2ZsYWcYASABKAhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.SetPlayerFlagToDefaultResponse), global::WUProtos.Networking.Responses.SetPlayerFlagToDefaultResponse.Parser, new[]{ "DidSetFlag" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SetPlayerFlagToDefaultResponse : pb::IMessage<SetPlayerFlagToDefaultResponse> {
    private static readonly pb::MessageParser<SetPlayerFlagToDefaultResponse> _parser = new pb::MessageParser<SetPlayerFlagToDefaultResponse>(() => new SetPlayerFlagToDefaultResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetPlayerFlagToDefaultResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.SetPlayerFlagToDefaultResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetPlayerFlagToDefaultResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetPlayerFlagToDefaultResponse(SetPlayerFlagToDefaultResponse other) : this() {
      didSetFlag_ = other.didSetFlag_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetPlayerFlagToDefaultResponse Clone() {
      return new SetPlayerFlagToDefaultResponse(this);
    }

    /// <summary>Field number for the "did_set_flag" field.</summary>
    public const int DidSetFlagFieldNumber = 1;
    private bool didSetFlag_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DidSetFlag {
      get { return didSetFlag_; }
      set {
        didSetFlag_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetPlayerFlagToDefaultResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetPlayerFlagToDefaultResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DidSetFlag != other.DidSetFlag) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DidSetFlag != false) hash ^= DidSetFlag.GetHashCode();
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
      if (DidSetFlag != false) {
        output.WriteRawTag(8);
        output.WriteBool(DidSetFlag);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DidSetFlag != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetPlayerFlagToDefaultResponse other) {
      if (other == null) {
        return;
      }
      if (other.DidSetFlag != false) {
        DidSetFlag = other.DidSetFlag;
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
            DidSetFlag = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code