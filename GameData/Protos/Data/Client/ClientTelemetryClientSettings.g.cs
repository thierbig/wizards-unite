// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientTelemetryClientSettings.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientTelemetryClientSettings.proto</summary>
  public static partial class ClientTelemetryClientSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientTelemetryClientSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientTelemetryClientSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjhXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRUZWxlbWV0cnlDbGllbnRT",
            "ZXR0aW5ncy5wcm90bxIUV1VQcm90b3MuRGF0YS5DbGllbnQivQIKHUNsaWVu",
            "dFRlbGVtZXRyeUNsaWVudFNldHRpbmdzEhkKEWlzX3VwbG9hZF9lbmFibGVk",
            "GAEgASgIEiAKGG1heF91cGxvYWRfc2l6ZV9pbl9ieXRlcxgCIAEoAxIeChZ1",
            "cGRhdGVfaW50ZXJ2YWxfaW5fc2VjGAMgASgDEicKH3NldHRpbmdzX3VwZGF0",
            "ZV9pbnRlcnZhbF9pbl9zZWMYBCABKAMSHwoXbWF4X2VudmVsb3BlX3F1ZXVl",
            "X3NpemUYBSABKAMSHAoUc2FtcGxpbmdfcHJvYmFiaWxpdHkYBiABKAESIQoZ",
            "dXNlX3BsYXllcl9iYXNlZF9zYW1wbGluZxgHIAEoCBITCgtwbGF5ZXJfaGFz",
            "aBgIIAEoARIfChdwbGF5ZXJfZXh0ZXJuYWxfb21uaV9pZBgJIAEoCWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientTelemetryClientSettings), global::WUProtos.Data.Client.ClientTelemetryClientSettings.Parser, new[]{ "IsUploadEnabled", "MaxUploadSizeInBytes", "UpdateIntervalInSec", "SettingsUpdateIntervalInSec", "MaxEnvelopeQueueSize", "SamplingProbability", "UsePlayerBasedSampling", "PlayerHash", "PlayerExternalOmniId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientTelemetryClientSettings : pb::IMessage<ClientTelemetryClientSettings> {
    private static readonly pb::MessageParser<ClientTelemetryClientSettings> _parser = new pb::MessageParser<ClientTelemetryClientSettings>(() => new ClientTelemetryClientSettings());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientTelemetryClientSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientTelemetryClientSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryClientSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryClientSettings(ClientTelemetryClientSettings other) : this() {
      isUploadEnabled_ = other.isUploadEnabled_;
      maxUploadSizeInBytes_ = other.maxUploadSizeInBytes_;
      updateIntervalInSec_ = other.updateIntervalInSec_;
      settingsUpdateIntervalInSec_ = other.settingsUpdateIntervalInSec_;
      maxEnvelopeQueueSize_ = other.maxEnvelopeQueueSize_;
      samplingProbability_ = other.samplingProbability_;
      usePlayerBasedSampling_ = other.usePlayerBasedSampling_;
      playerHash_ = other.playerHash_;
      playerExternalOmniId_ = other.playerExternalOmniId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryClientSettings Clone() {
      return new ClientTelemetryClientSettings(this);
    }

    /// <summary>Field number for the "is_upload_enabled" field.</summary>
    public const int IsUploadEnabledFieldNumber = 1;
    private bool isUploadEnabled_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsUploadEnabled {
      get { return isUploadEnabled_; }
      set {
        isUploadEnabled_ = value;
      }
    }

    /// <summary>Field number for the "max_upload_size_in_bytes" field.</summary>
    public const int MaxUploadSizeInBytesFieldNumber = 2;
    private long maxUploadSizeInBytes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long MaxUploadSizeInBytes {
      get { return maxUploadSizeInBytes_; }
      set {
        maxUploadSizeInBytes_ = value;
      }
    }

    /// <summary>Field number for the "update_interval_in_sec" field.</summary>
    public const int UpdateIntervalInSecFieldNumber = 3;
    private long updateIntervalInSec_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long UpdateIntervalInSec {
      get { return updateIntervalInSec_; }
      set {
        updateIntervalInSec_ = value;
      }
    }

    /// <summary>Field number for the "settings_update_interval_in_sec" field.</summary>
    public const int SettingsUpdateIntervalInSecFieldNumber = 4;
    private long settingsUpdateIntervalInSec_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long SettingsUpdateIntervalInSec {
      get { return settingsUpdateIntervalInSec_; }
      set {
        settingsUpdateIntervalInSec_ = value;
      }
    }

    /// <summary>Field number for the "max_envelope_queue_size" field.</summary>
    public const int MaxEnvelopeQueueSizeFieldNumber = 5;
    private long maxEnvelopeQueueSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long MaxEnvelopeQueueSize {
      get { return maxEnvelopeQueueSize_; }
      set {
        maxEnvelopeQueueSize_ = value;
      }
    }

    /// <summary>Field number for the "sampling_probability" field.</summary>
    public const int SamplingProbabilityFieldNumber = 6;
    private double samplingProbability_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double SamplingProbability {
      get { return samplingProbability_; }
      set {
        samplingProbability_ = value;
      }
    }

    /// <summary>Field number for the "use_player_based_sampling" field.</summary>
    public const int UsePlayerBasedSamplingFieldNumber = 7;
    private bool usePlayerBasedSampling_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool UsePlayerBasedSampling {
      get { return usePlayerBasedSampling_; }
      set {
        usePlayerBasedSampling_ = value;
      }
    }

    /// <summary>Field number for the "player_hash" field.</summary>
    public const int PlayerHashFieldNumber = 8;
    private double playerHash_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PlayerHash {
      get { return playerHash_; }
      set {
        playerHash_ = value;
      }
    }

    /// <summary>Field number for the "player_external_omni_id" field.</summary>
    public const int PlayerExternalOmniIdFieldNumber = 9;
    private string playerExternalOmniId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PlayerExternalOmniId {
      get { return playerExternalOmniId_; }
      set {
        playerExternalOmniId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientTelemetryClientSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientTelemetryClientSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsUploadEnabled != other.IsUploadEnabled) return false;
      if (MaxUploadSizeInBytes != other.MaxUploadSizeInBytes) return false;
      if (UpdateIntervalInSec != other.UpdateIntervalInSec) return false;
      if (SettingsUpdateIntervalInSec != other.SettingsUpdateIntervalInSec) return false;
      if (MaxEnvelopeQueueSize != other.MaxEnvelopeQueueSize) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(SamplingProbability, other.SamplingProbability)) return false;
      if (UsePlayerBasedSampling != other.UsePlayerBasedSampling) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PlayerHash, other.PlayerHash)) return false;
      if (PlayerExternalOmniId != other.PlayerExternalOmniId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IsUploadEnabled != false) hash ^= IsUploadEnabled.GetHashCode();
      if (MaxUploadSizeInBytes != 0L) hash ^= MaxUploadSizeInBytes.GetHashCode();
      if (UpdateIntervalInSec != 0L) hash ^= UpdateIntervalInSec.GetHashCode();
      if (SettingsUpdateIntervalInSec != 0L) hash ^= SettingsUpdateIntervalInSec.GetHashCode();
      if (MaxEnvelopeQueueSize != 0L) hash ^= MaxEnvelopeQueueSize.GetHashCode();
      if (SamplingProbability != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(SamplingProbability);
      if (UsePlayerBasedSampling != false) hash ^= UsePlayerBasedSampling.GetHashCode();
      if (PlayerHash != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PlayerHash);
      if (PlayerExternalOmniId.Length != 0) hash ^= PlayerExternalOmniId.GetHashCode();
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
      if (IsUploadEnabled != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsUploadEnabled);
      }
      if (MaxUploadSizeInBytes != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(MaxUploadSizeInBytes);
      }
      if (UpdateIntervalInSec != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(UpdateIntervalInSec);
      }
      if (SettingsUpdateIntervalInSec != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(SettingsUpdateIntervalInSec);
      }
      if (MaxEnvelopeQueueSize != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(MaxEnvelopeQueueSize);
      }
      if (SamplingProbability != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(SamplingProbability);
      }
      if (UsePlayerBasedSampling != false) {
        output.WriteRawTag(56);
        output.WriteBool(UsePlayerBasedSampling);
      }
      if (PlayerHash != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(PlayerHash);
      }
      if (PlayerExternalOmniId.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(PlayerExternalOmniId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IsUploadEnabled != false) {
        size += 1 + 1;
      }
      if (MaxUploadSizeInBytes != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(MaxUploadSizeInBytes);
      }
      if (UpdateIntervalInSec != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UpdateIntervalInSec);
      }
      if (SettingsUpdateIntervalInSec != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SettingsUpdateIntervalInSec);
      }
      if (MaxEnvelopeQueueSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(MaxEnvelopeQueueSize);
      }
      if (SamplingProbability != 0D) {
        size += 1 + 8;
      }
      if (UsePlayerBasedSampling != false) {
        size += 1 + 1;
      }
      if (PlayerHash != 0D) {
        size += 1 + 8;
      }
      if (PlayerExternalOmniId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PlayerExternalOmniId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientTelemetryClientSettings other) {
      if (other == null) {
        return;
      }
      if (other.IsUploadEnabled != false) {
        IsUploadEnabled = other.IsUploadEnabled;
      }
      if (other.MaxUploadSizeInBytes != 0L) {
        MaxUploadSizeInBytes = other.MaxUploadSizeInBytes;
      }
      if (other.UpdateIntervalInSec != 0L) {
        UpdateIntervalInSec = other.UpdateIntervalInSec;
      }
      if (other.SettingsUpdateIntervalInSec != 0L) {
        SettingsUpdateIntervalInSec = other.SettingsUpdateIntervalInSec;
      }
      if (other.MaxEnvelopeQueueSize != 0L) {
        MaxEnvelopeQueueSize = other.MaxEnvelopeQueueSize;
      }
      if (other.SamplingProbability != 0D) {
        SamplingProbability = other.SamplingProbability;
      }
      if (other.UsePlayerBasedSampling != false) {
        UsePlayerBasedSampling = other.UsePlayerBasedSampling;
      }
      if (other.PlayerHash != 0D) {
        PlayerHash = other.PlayerHash;
      }
      if (other.PlayerExternalOmniId.Length != 0) {
        PlayerExternalOmniId = other.PlayerExternalOmniId;
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
            IsUploadEnabled = input.ReadBool();
            break;
          }
          case 16: {
            MaxUploadSizeInBytes = input.ReadInt64();
            break;
          }
          case 24: {
            UpdateIntervalInSec = input.ReadInt64();
            break;
          }
          case 32: {
            SettingsUpdateIntervalInSec = input.ReadInt64();
            break;
          }
          case 40: {
            MaxEnvelopeQueueSize = input.ReadInt64();
            break;
          }
          case 49: {
            SamplingProbability = input.ReadDouble();
            break;
          }
          case 56: {
            UsePlayerBasedSampling = input.ReadBool();
            break;
          }
          case 65: {
            PlayerHash = input.ReadDouble();
            break;
          }
          case 74: {
            PlayerExternalOmniId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
