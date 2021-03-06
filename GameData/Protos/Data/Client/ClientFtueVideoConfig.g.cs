// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientFtueVideoConfig.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientFtueVideoConfig.proto</summary>
  public static partial class ClientFtueVideoConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientFtueVideoConfig.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientFtueVideoConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRGdHVlVmlkZW9Db25maWcu",
            "cHJvdG8SFFdVUHJvdG9zLkRhdGEuQ2xpZW50GjxXVVByb3Rvcy9EYXRhL0Ns",
            "aWVudC9DbGllbnRGdHVlVmlkZW9GYWxsYmFja0RlZmluaXRpb24ucHJvdG8a",
            "OFdVUHJvdG9zL0RhdGEvQ2xpZW50L0NsaWVudEZ0dWVWaWRlb05hbWVEZWZp",
            "bml0aW9uLnByb3RvItgBChVDbGllbnRGdHVlVmlkZW9Db25maWcSTgoLZnJv",
            "bV9hc3NldHMYASABKAsyNy5XVVByb3Rvcy5EYXRhLkNsaWVudC5DbGllbnRG",
            "dHVlVmlkZW9GYWxsYmFja0RlZmluaXRpb25IABJHCghmcm9tX3VybBgCIAEo",
            "CzIzLldVUHJvdG9zLkRhdGEuQ2xpZW50LkNsaWVudEZ0dWVWaWRlb05hbWVE",
            "ZWZpbml0aW9uSAASFwoPcXVhbGl0eV9idWNrZXRzGAMgAygJQg0KC1ZpZGVv",
            "U291cmNlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Client.ClientFtueVideoFallbackDefinitionReflection.Descriptor, global::WUProtos.Data.Client.ClientFtueVideoNameDefinitionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientFtueVideoConfig), global::WUProtos.Data.Client.ClientFtueVideoConfig.Parser, new[]{ "FromAssets", "FromUrl", "QualityBuckets" }, new[]{ "VideoSource" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientFtueVideoConfig : pb::IMessage<ClientFtueVideoConfig> {
    private static readonly pb::MessageParser<ClientFtueVideoConfig> _parser = new pb::MessageParser<ClientFtueVideoConfig>(() => new ClientFtueVideoConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientFtueVideoConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientFtueVideoConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientFtueVideoConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientFtueVideoConfig(ClientFtueVideoConfig other) : this() {
      qualityBuckets_ = other.qualityBuckets_.Clone();
      switch (other.VideoSourceCase) {
        case VideoSourceOneofCase.FromAssets:
          FromAssets = other.FromAssets.Clone();
          break;
        case VideoSourceOneofCase.FromUrl:
          FromUrl = other.FromUrl.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientFtueVideoConfig Clone() {
      return new ClientFtueVideoConfig(this);
    }

    /// <summary>Field number for the "from_assets" field.</summary>
    public const int FromAssetsFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Client.ClientFtueVideoFallbackDefinition FromAssets {
      get { return videoSourceCase_ == VideoSourceOneofCase.FromAssets ? (global::WUProtos.Data.Client.ClientFtueVideoFallbackDefinition) videoSource_ : null; }
      set {
        videoSource_ = value;
        videoSourceCase_ = value == null ? VideoSourceOneofCase.None : VideoSourceOneofCase.FromAssets;
      }
    }

    /// <summary>Field number for the "from_url" field.</summary>
    public const int FromUrlFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Client.ClientFtueVideoNameDefinition FromUrl {
      get { return videoSourceCase_ == VideoSourceOneofCase.FromUrl ? (global::WUProtos.Data.Client.ClientFtueVideoNameDefinition) videoSource_ : null; }
      set {
        videoSource_ = value;
        videoSourceCase_ = value == null ? VideoSourceOneofCase.None : VideoSourceOneofCase.FromUrl;
      }
    }

    /// <summary>Field number for the "quality_buckets" field.</summary>
    public const int QualityBucketsFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_qualityBuckets_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> qualityBuckets_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> QualityBuckets {
      get { return qualityBuckets_; }
    }

    private object videoSource_;
    /// <summary>Enum of possible cases for the "VideoSource" oneof.</summary>
    public enum VideoSourceOneofCase {
      None = 0,
      FromAssets = 1,
      FromUrl = 2,
    }
    private VideoSourceOneofCase videoSourceCase_ = VideoSourceOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VideoSourceOneofCase VideoSourceCase {
      get { return videoSourceCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearVideoSource() {
      videoSourceCase_ = VideoSourceOneofCase.None;
      videoSource_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientFtueVideoConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientFtueVideoConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(FromAssets, other.FromAssets)) return false;
      if (!object.Equals(FromUrl, other.FromUrl)) return false;
      if(!qualityBuckets_.Equals(other.qualityBuckets_)) return false;
      if (VideoSourceCase != other.VideoSourceCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (videoSourceCase_ == VideoSourceOneofCase.FromAssets) hash ^= FromAssets.GetHashCode();
      if (videoSourceCase_ == VideoSourceOneofCase.FromUrl) hash ^= FromUrl.GetHashCode();
      hash ^= qualityBuckets_.GetHashCode();
      hash ^= (int) videoSourceCase_;
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
      if (videoSourceCase_ == VideoSourceOneofCase.FromAssets) {
        output.WriteRawTag(10);
        output.WriteMessage(FromAssets);
      }
      if (videoSourceCase_ == VideoSourceOneofCase.FromUrl) {
        output.WriteRawTag(18);
        output.WriteMessage(FromUrl);
      }
      qualityBuckets_.WriteTo(output, _repeated_qualityBuckets_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (videoSourceCase_ == VideoSourceOneofCase.FromAssets) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FromAssets);
      }
      if (videoSourceCase_ == VideoSourceOneofCase.FromUrl) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FromUrl);
      }
      size += qualityBuckets_.CalculateSize(_repeated_qualityBuckets_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientFtueVideoConfig other) {
      if (other == null) {
        return;
      }
      qualityBuckets_.Add(other.qualityBuckets_);
      switch (other.VideoSourceCase) {
        case VideoSourceOneofCase.FromAssets:
          if (FromAssets == null) {
            FromAssets = new global::WUProtos.Data.Client.ClientFtueVideoFallbackDefinition();
          }
          FromAssets.MergeFrom(other.FromAssets);
          break;
        case VideoSourceOneofCase.FromUrl:
          if (FromUrl == null) {
            FromUrl = new global::WUProtos.Data.Client.ClientFtueVideoNameDefinition();
          }
          FromUrl.MergeFrom(other.FromUrl);
          break;
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
            global::WUProtos.Data.Client.ClientFtueVideoFallbackDefinition subBuilder = new global::WUProtos.Data.Client.ClientFtueVideoFallbackDefinition();
            if (videoSourceCase_ == VideoSourceOneofCase.FromAssets) {
              subBuilder.MergeFrom(FromAssets);
            }
            input.ReadMessage(subBuilder);
            FromAssets = subBuilder;
            break;
          }
          case 18: {
            global::WUProtos.Data.Client.ClientFtueVideoNameDefinition subBuilder = new global::WUProtos.Data.Client.ClientFtueVideoNameDefinition();
            if (videoSourceCase_ == VideoSourceOneofCase.FromUrl) {
              subBuilder.MergeFrom(FromUrl);
            }
            input.ReadMessage(subBuilder);
            FromUrl = subBuilder;
            break;
          }
          case 26: {
            qualityBuckets_.AddEntriesFrom(input, _repeated_qualityBuckets_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
