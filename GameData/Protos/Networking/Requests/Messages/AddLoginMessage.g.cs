// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/AddLoginMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/AddLoginMessage.proto</summary>
  public static partial class AddLoginMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/AddLoginMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AddLoginMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjtXVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0FkZExv",
            "Z2luTWVzc2FnZS5wcm90bxIlV1VQcm90b3MuTmV0d29ya2luZy5SZXF1ZXN0",
            "cy5NZXNzYWdlcxolV1VQcm90b3MvRW51bXMvSWRlbnRpdHlQcm92aWRlci5w",
            "cm90byJlCg9BZGRMb2dpbk1lc3NhZ2USOwoRaWRlbnRpdHlfcHJvdmlkZXIY",
            "ASABKA4yIC5XVVByb3Rvcy5FbnVtcy5JZGVudGl0eVByb3ZpZGVyEhUKDWlu",
            "bmVyX21lc3NhZ2UYAiABKAxiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Enums.IdentityProviderReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.AddLoginMessage), global::WUProtos.Networking.Requests.Messages.AddLoginMessage.Parser, new[]{ "IdentityProvider", "InnerMessage" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AddLoginMessage : pb::IMessage<AddLoginMessage> {
    private static readonly pb::MessageParser<AddLoginMessage> _parser = new pb::MessageParser<AddLoginMessage>(() => new AddLoginMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddLoginMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.AddLoginMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddLoginMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddLoginMessage(AddLoginMessage other) : this() {
      identityProvider_ = other.identityProvider_;
      innerMessage_ = other.innerMessage_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddLoginMessage Clone() {
      return new AddLoginMessage(this);
    }

    /// <summary>Field number for the "identity_provider" field.</summary>
    public const int IdentityProviderFieldNumber = 1;
    private global::WUProtos.Enums.IdentityProvider identityProvider_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Enums.IdentityProvider IdentityProvider {
      get { return identityProvider_; }
      set {
        identityProvider_ = value;
      }
    }

    /// <summary>Field number for the "inner_message" field.</summary>
    public const int InnerMessageFieldNumber = 2;
    private pb::ByteString innerMessage_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString InnerMessage {
      get { return innerMessage_; }
      set {
        innerMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddLoginMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddLoginMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IdentityProvider != other.IdentityProvider) return false;
      if (InnerMessage != other.InnerMessage) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IdentityProvider != 0) hash ^= IdentityProvider.GetHashCode();
      if (InnerMessage.Length != 0) hash ^= InnerMessage.GetHashCode();
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
      if (IdentityProvider != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) IdentityProvider);
      }
      if (InnerMessage.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(InnerMessage);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IdentityProvider != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) IdentityProvider);
      }
      if (InnerMessage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(InnerMessage);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddLoginMessage other) {
      if (other == null) {
        return;
      }
      if (other.IdentityProvider != 0) {
        IdentityProvider = other.IdentityProvider;
      }
      if (other.InnerMessage.Length != 0) {
        InnerMessage = other.InnerMessage;
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
            IdentityProvider = (global::WUProtos.Enums.IdentityProvider) input.ReadEnum();
            break;
          }
          case 18: {
            InnerMessage = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
