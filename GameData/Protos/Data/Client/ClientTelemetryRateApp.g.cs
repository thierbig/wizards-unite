// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientTelemetryRateApp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientTelemetryRateApp.proto</summary>
  public static partial class ClientTelemetryRateAppReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientTelemetryRateApp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientTelemetryRateAppReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRUZWxlbWV0cnlSYXRlQXBw",
            "LnByb3RvEhRXVVByb3Rvcy5EYXRhLkNsaWVudCJfChZDbGllbnRUZWxlbWV0",
            "cnlSYXRlQXBwEhsKE2hhdmluZ19mdW5fcmVzcG9uc2UYASABKAgSEAoIcGxh",
            "dGZvcm0YAiABKAkSFgoOY2xpZW50X3ZlcnNpb24YAyABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientTelemetryRateApp), global::WUProtos.Data.Client.ClientTelemetryRateApp.Parser, new[]{ "HavingFunResponse", "Platform", "ClientVersion" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientTelemetryRateApp : pb::IMessage<ClientTelemetryRateApp> {
    private static readonly pb::MessageParser<ClientTelemetryRateApp> _parser = new pb::MessageParser<ClientTelemetryRateApp>(() => new ClientTelemetryRateApp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientTelemetryRateApp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientTelemetryRateAppReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryRateApp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryRateApp(ClientTelemetryRateApp other) : this() {
      havingFunResponse_ = other.havingFunResponse_;
      platform_ = other.platform_;
      clientVersion_ = other.clientVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryRateApp Clone() {
      return new ClientTelemetryRateApp(this);
    }

    /// <summary>Field number for the "having_fun_response" field.</summary>
    public const int HavingFunResponseFieldNumber = 1;
    private bool havingFunResponse_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HavingFunResponse {
      get { return havingFunResponse_; }
      set {
        havingFunResponse_ = value;
      }
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 2;
    private string platform_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Platform {
      get { return platform_; }
      set {
        platform_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_version" field.</summary>
    public const int ClientVersionFieldNumber = 3;
    private string clientVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClientVersion {
      get { return clientVersion_; }
      set {
        clientVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientTelemetryRateApp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientTelemetryRateApp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HavingFunResponse != other.HavingFunResponse) return false;
      if (Platform != other.Platform) return false;
      if (ClientVersion != other.ClientVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HavingFunResponse != false) hash ^= HavingFunResponse.GetHashCode();
      if (Platform.Length != 0) hash ^= Platform.GetHashCode();
      if (ClientVersion.Length != 0) hash ^= ClientVersion.GetHashCode();
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
      if (HavingFunResponse != false) {
        output.WriteRawTag(8);
        output.WriteBool(HavingFunResponse);
      }
      if (Platform.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Platform);
      }
      if (ClientVersion.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ClientVersion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HavingFunResponse != false) {
        size += 1 + 1;
      }
      if (Platform.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Platform);
      }
      if (ClientVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientTelemetryRateApp other) {
      if (other == null) {
        return;
      }
      if (other.HavingFunResponse != false) {
        HavingFunResponse = other.HavingFunResponse;
      }
      if (other.Platform.Length != 0) {
        Platform = other.Platform;
      }
      if (other.ClientVersion.Length != 0) {
        ClientVersion = other.ClientVersion;
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
            HavingFunResponse = input.ReadBool();
            break;
          }
          case 18: {
            Platform = input.ReadString();
            break;
          }
          case 26: {
            ClientVersion = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code