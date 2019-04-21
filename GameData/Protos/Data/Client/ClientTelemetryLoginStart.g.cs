// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientTelemetryLoginStart.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientTelemetryLoginStart.proto</summary>
  public static partial class ClientTelemetryLoginStartReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientTelemetryLoginStart.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientTelemetryLoginStartReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRUZWxlbWV0cnlMb2dpblN0",
            "YXJ0LnByb3RvEhRXVVByb3Rvcy5EYXRhLkNsaWVudCI1ChlDbGllbnRUZWxl",
            "bWV0cnlMb2dpblN0YXJ0EhgKEGF1dGhfcHJvdmlkZXJfaWQYASABKAliBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientTelemetryLoginStart), global::WUProtos.Data.Client.ClientTelemetryLoginStart.Parser, new[]{ "AuthProviderId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientTelemetryLoginStart : pb::IMessage<ClientTelemetryLoginStart> {
    private static readonly pb::MessageParser<ClientTelemetryLoginStart> _parser = new pb::MessageParser<ClientTelemetryLoginStart>(() => new ClientTelemetryLoginStart());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientTelemetryLoginStart> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientTelemetryLoginStartReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryLoginStart() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryLoginStart(ClientTelemetryLoginStart other) : this() {
      authProviderId_ = other.authProviderId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryLoginStart Clone() {
      return new ClientTelemetryLoginStart(this);
    }

    /// <summary>Field number for the "auth_provider_id" field.</summary>
    public const int AuthProviderIdFieldNumber = 1;
    private string authProviderId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AuthProviderId {
      get { return authProviderId_; }
      set {
        authProviderId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientTelemetryLoginStart);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientTelemetryLoginStart other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AuthProviderId != other.AuthProviderId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AuthProviderId.Length != 0) hash ^= AuthProviderId.GetHashCode();
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
      if (AuthProviderId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AuthProviderId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AuthProviderId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AuthProviderId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientTelemetryLoginStart other) {
      if (other == null) {
        return;
      }
      if (other.AuthProviderId.Length != 0) {
        AuthProviderId = other.AuthProviderId;
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
            AuthProviderId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
