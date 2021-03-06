// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/GetSignedUrlForPhotoUploadMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/GetSignedUrlForPhotoUploadMessage.proto</summary>
  public static partial class GetSignedUrlForPhotoUploadMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/GetSignedUrlForPhotoUploadMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetSignedUrlForPhotoUploadMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ck1XVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0dldFNp",
            "Z25lZFVybEZvclBob3RvVXBsb2FkTWVzc2FnZS5wcm90bxIlV1VQcm90b3Mu",
            "TmV0d29ya2luZy5SZXF1ZXN0cy5NZXNzYWdlcyJMCiFHZXRTaWduZWRVcmxG",
            "b3JQaG90b1VwbG9hZE1lc3NhZ2USDwoHdXNlcl9pZBgBIAEoCRIWCg5nYW1l",
            "X3VuaXF1ZV9pZBgCIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.GetSignedUrlForPhotoUploadMessage), global::WUProtos.Networking.Requests.Messages.GetSignedUrlForPhotoUploadMessage.Parser, new[]{ "UserId", "GameUniqueId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetSignedUrlForPhotoUploadMessage : pb::IMessage<GetSignedUrlForPhotoUploadMessage> {
    private static readonly pb::MessageParser<GetSignedUrlForPhotoUploadMessage> _parser = new pb::MessageParser<GetSignedUrlForPhotoUploadMessage>(() => new GetSignedUrlForPhotoUploadMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetSignedUrlForPhotoUploadMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.GetSignedUrlForPhotoUploadMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetSignedUrlForPhotoUploadMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetSignedUrlForPhotoUploadMessage(GetSignedUrlForPhotoUploadMessage other) : this() {
      userId_ = other.userId_;
      gameUniqueId_ = other.gameUniqueId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetSignedUrlForPhotoUploadMessage Clone() {
      return new GetSignedUrlForPhotoUploadMessage(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private string userId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "game_unique_id" field.</summary>
    public const int GameUniqueIdFieldNumber = 2;
    private string gameUniqueId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GameUniqueId {
      get { return gameUniqueId_; }
      set {
        gameUniqueId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetSignedUrlForPhotoUploadMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetSignedUrlForPhotoUploadMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if (GameUniqueId != other.GameUniqueId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      if (GameUniqueId.Length != 0) hash ^= GameUniqueId.GetHashCode();
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
      if (UserId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserId);
      }
      if (GameUniqueId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(GameUniqueId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      if (GameUniqueId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GameUniqueId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetSignedUrlForPhotoUploadMessage other) {
      if (other == null) {
        return;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
      if (other.GameUniqueId.Length != 0) {
        GameUniqueId = other.GameUniqueId;
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
            UserId = input.ReadString();
            break;
          }
          case 18: {
            GameUniqueId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
