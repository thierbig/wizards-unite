// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientFtueVideoFromAsset.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientFtueVideoFromAsset.proto</summary>
  public static partial class ClientFtueVideoFromAssetReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientFtueVideoFromAsset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientFtueVideoFromAssetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRGdHVlVmlkZW9Gcm9tQXNz",
            "ZXQucHJvdG8SFFdVUHJvdG9zLkRhdGEuQ2xpZW50IlkKGENsaWVudEZ0dWVW",
            "aWRlb0Zyb21Bc3NldBIZChFhc3NldF9uYW1lX2Zvcm1hdBgBIAEoCRIiChpm",
            "YWxsYmFja19hc3NldF9uYW1lX2Zvcm1hdBgCIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientFtueVideoFromAsset), global::WUProtos.Data.Client.ClientFtueVideoFromAsset.Parser, new[]{ "AssetNameFormat", "FallbackAssetNameFormat" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientFtueVideoFromAsset : pb::IMessage<ClientFtueVideoFromAsset> {
    private static readonly pb::MessageParser<ClientFtueVideoFromAsset> _parser = new pb::MessageParser<ClientFtueVideoFromAsset>(() => new ClientFtueVideoFromAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientFtueVideoFromAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientFtueVideoFromAssetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientFtueVideoFromAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientFtueVideoFromAsset(ClientFtueVideoFromAsset other) : this() {
      assetNameFormat_ = other.assetNameFormat_;
      fallbackAssetNameFormat_ = other.fallbackAssetNameFormat_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientFtueVideoFromAsset Clone() {
      return new ClientFtueVideoFromAsset(this);
    }

    /// <summary>Field number for the "asset_name_format" field.</summary>
    public const int AssetNameFormatFieldNumber = 1;
    private string assetNameFormat_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AssetNameFormat {
      get { return assetNameFormat_; }
      set {
        assetNameFormat_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fallback_asset_name_format" field.</summary>
    public const int FallbackAssetNameFormatFieldNumber = 2;
    private string fallbackAssetNameFormat_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FallbackAssetNameFormat {
      get { return fallbackAssetNameFormat_; }
      set {
        fallbackAssetNameFormat_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientFtueVideoFromAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientFtueVideoFromAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AssetNameFormat != other.AssetNameFormat) return false;
      if (FallbackAssetNameFormat != other.FallbackAssetNameFormat) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AssetNameFormat.Length != 0) hash ^= AssetNameFormat.GetHashCode();
      if (FallbackAssetNameFormat.Length != 0) hash ^= FallbackAssetNameFormat.GetHashCode();
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
      if (AssetNameFormat.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AssetNameFormat);
      }
      if (FallbackAssetNameFormat.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FallbackAssetNameFormat);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AssetNameFormat.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AssetNameFormat);
      }
      if (FallbackAssetNameFormat.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FallbackAssetNameFormat);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientFtueVideoFromAsset other) {
      if (other == null) {
        return;
      }
      if (other.AssetNameFormat.Length != 0) {
        AssetNameFormat = other.AssetNameFormat;
      }
      if (other.FallbackAssetNameFormat.Length != 0) {
        FallbackAssetNameFormat = other.FallbackAssetNameFormat;
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
            AssetNameFormat = input.ReadString();
            break;
          }
          case 18: {
            FallbackAssetNameFormat = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
