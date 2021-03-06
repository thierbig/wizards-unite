// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Token/GcmToken.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Token {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Token/GcmToken.proto</summary>
  public static partial class GcmTokenReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Token/GcmToken.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GcmTokenReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJXVVByb3Rvcy9EYXRhL1Rva2VuL0djbVRva2VuLnByb3RvEhNXVVByb3Rv",
            "cy5EYXRhLlRva2VuIiMKCEdjbVRva2VuEhcKD3JlZ2lzdHJhdGlvbl9pZBgB",
            "IAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Token.GcmToken), global::WUProtos.Data.Token.GcmToken.Parser, new[]{ "RegistrationId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GcmToken : pb::IMessage<GcmToken> {
    private static readonly pb::MessageParser<GcmToken> _parser = new pb::MessageParser<GcmToken>(() => new GcmToken());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GcmToken> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Token.GcmTokenReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GcmToken() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GcmToken(GcmToken other) : this() {
      registrationId_ = other.registrationId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GcmToken Clone() {
      return new GcmToken(this);
    }

    /// <summary>Field number for the "registration_id" field.</summary>
    public const int RegistrationIdFieldNumber = 1;
    private string registrationId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RegistrationId {
      get { return registrationId_; }
      set {
        registrationId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GcmToken);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GcmToken other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RegistrationId != other.RegistrationId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RegistrationId.Length != 0) hash ^= RegistrationId.GetHashCode();
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
      if (RegistrationId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RegistrationId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RegistrationId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RegistrationId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GcmToken other) {
      if (other == null) {
        return;
      }
      if (other.RegistrationId.Length != 0) {
        RegistrationId = other.RegistrationId;
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
            RegistrationId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
