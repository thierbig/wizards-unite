// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/ClientConfigurationResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/ClientConfigurationResponse.proto</summary>
  public static partial class ClientConfigurationResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/ClientConfigurationResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientConfigurationResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9XVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9DbGllbnRDb25maWd1",
            "cmF0aW9uUmVzcG9uc2UucHJvdG8SHVdVUHJvdG9zLk5ldHdvcmtpbmcuUmVz",
            "cG9uc2VzGiZXVVByb3Rvcy9EYXRhL1NoYXJlZFF1YWxpdHlMZXZlbC5wcm90",
            "byLMAQobQ2xpZW50Q29uZmlndXJhdGlvblJlc3BvbnNlEhQKDGZvcmNlX3Vw",
            "ZGF0ZRgBIAEoCBISCgpzZXJ2ZXJfdXJpGAIgASgJEhUKDWFjdHVhbF9lbnZf",
            "aWQYAyABKAkSGAoQbWFuaWZlc3RfdmVyc2lvbhgEIAEoCRI4Cg1xdWFsaXR5",
            "X2xldmVsGAUgASgLMiEuV1VQcm90b3MuRGF0YS5TaGFyZWRRdWFsaXR5TGV2",
            "ZWwSGAoQZm9yY2VfdXBkYXRlX3VybBgGIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.SharedQualityLevelReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.ClientConfigurationResponse), global::WUProtos.Networking.Responses.ClientConfigurationResponse.Parser, new[]{ "ForceUpdate", "ServerUri", "ActualEnvId", "ManifestVersion", "QualityLevel", "ForceUpdateUrl" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientConfigurationResponse : pb::IMessage<ClientConfigurationResponse> {
    private static readonly pb::MessageParser<ClientConfigurationResponse> _parser = new pb::MessageParser<ClientConfigurationResponse>(() => new ClientConfigurationResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientConfigurationResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.ClientConfigurationResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientConfigurationResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientConfigurationResponse(ClientConfigurationResponse other) : this() {
      forceUpdate_ = other.forceUpdate_;
      serverUri_ = other.serverUri_;
      actualEnvId_ = other.actualEnvId_;
      manifestVersion_ = other.manifestVersion_;
      qualityLevel_ = other.qualityLevel_ != null ? other.qualityLevel_.Clone() : null;
      forceUpdateUrl_ = other.forceUpdateUrl_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientConfigurationResponse Clone() {
      return new ClientConfigurationResponse(this);
    }

    /// <summary>Field number for the "force_update" field.</summary>
    public const int ForceUpdateFieldNumber = 1;
    private bool forceUpdate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ForceUpdate {
      get { return forceUpdate_; }
      set {
        forceUpdate_ = value;
      }
    }

    /// <summary>Field number for the "server_uri" field.</summary>
    public const int ServerUriFieldNumber = 2;
    private string serverUri_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ServerUri {
      get { return serverUri_; }
      set {
        serverUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "actual_env_id" field.</summary>
    public const int ActualEnvIdFieldNumber = 3;
    private string actualEnvId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ActualEnvId {
      get { return actualEnvId_; }
      set {
        actualEnvId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "manifest_version" field.</summary>
    public const int ManifestVersionFieldNumber = 4;
    private string manifestVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ManifestVersion {
      get { return manifestVersion_; }
      set {
        manifestVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "quality_level" field.</summary>
    public const int QualityLevelFieldNumber = 5;
    private global::WUProtos.Data.SharedQualityLevel qualityLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.SharedQualityLevel QualityLevel {
      get { return qualityLevel_; }
      set {
        qualityLevel_ = value;
      }
    }

    /// <summary>Field number for the "force_update_url" field.</summary>
    public const int ForceUpdateUrlFieldNumber = 6;
    private string forceUpdateUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ForceUpdateUrl {
      get { return forceUpdateUrl_; }
      set {
        forceUpdateUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientConfigurationResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientConfigurationResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ForceUpdate != other.ForceUpdate) return false;
      if (ServerUri != other.ServerUri) return false;
      if (ActualEnvId != other.ActualEnvId) return false;
      if (ManifestVersion != other.ManifestVersion) return false;
      if (!object.Equals(QualityLevel, other.QualityLevel)) return false;
      if (ForceUpdateUrl != other.ForceUpdateUrl) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ForceUpdate != false) hash ^= ForceUpdate.GetHashCode();
      if (ServerUri.Length != 0) hash ^= ServerUri.GetHashCode();
      if (ActualEnvId.Length != 0) hash ^= ActualEnvId.GetHashCode();
      if (ManifestVersion.Length != 0) hash ^= ManifestVersion.GetHashCode();
      if (qualityLevel_ != null) hash ^= QualityLevel.GetHashCode();
      if (ForceUpdateUrl.Length != 0) hash ^= ForceUpdateUrl.GetHashCode();
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
      if (ForceUpdate != false) {
        output.WriteRawTag(8);
        output.WriteBool(ForceUpdate);
      }
      if (ServerUri.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ServerUri);
      }
      if (ActualEnvId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ActualEnvId);
      }
      if (ManifestVersion.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ManifestVersion);
      }
      if (qualityLevel_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(QualityLevel);
      }
      if (ForceUpdateUrl.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ForceUpdateUrl);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ForceUpdate != false) {
        size += 1 + 1;
      }
      if (ServerUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServerUri);
      }
      if (ActualEnvId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ActualEnvId);
      }
      if (ManifestVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ManifestVersion);
      }
      if (qualityLevel_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(QualityLevel);
      }
      if (ForceUpdateUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ForceUpdateUrl);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientConfigurationResponse other) {
      if (other == null) {
        return;
      }
      if (other.ForceUpdate != false) {
        ForceUpdate = other.ForceUpdate;
      }
      if (other.ServerUri.Length != 0) {
        ServerUri = other.ServerUri;
      }
      if (other.ActualEnvId.Length != 0) {
        ActualEnvId = other.ActualEnvId;
      }
      if (other.ManifestVersion.Length != 0) {
        ManifestVersion = other.ManifestVersion;
      }
      if (other.qualityLevel_ != null) {
        if (qualityLevel_ == null) {
          QualityLevel = new global::WUProtos.Data.SharedQualityLevel();
        }
        QualityLevel.MergeFrom(other.QualityLevel);
      }
      if (other.ForceUpdateUrl.Length != 0) {
        ForceUpdateUrl = other.ForceUpdateUrl;
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
            ForceUpdate = input.ReadBool();
            break;
          }
          case 18: {
            ServerUri = input.ReadString();
            break;
          }
          case 26: {
            ActualEnvId = input.ReadString();
            break;
          }
          case 34: {
            ManifestVersion = input.ReadString();
            break;
          }
          case 42: {
            if (qualityLevel_ == null) {
              QualityLevel = new global::WUProtos.Data.SharedQualityLevel();
            }
            input.ReadMessage(QualityLevel);
            break;
          }
          case 50: {
            ForceUpdateUrl = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
