// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientStoreConfig.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientStoreConfig.proto</summary>
  public static partial class ClientStoreConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientStoreConfig.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientStoreConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRTdG9yZUNvbmZpZy5wcm90",
            "bxIUV1VQcm90b3MuRGF0YS5DbGllbnQaIVdVUHJvdG9zL0RhdGEvU3RvcmVD",
            "YXRlZ29yeS5wcm90bxofV1VQcm90b3MvRGF0YS9TdG9yZVJhcml0eS5wcm90",
            "byKxAQoRQ2xpZW50U3RvcmVDb25maWcSCgoCaWQYASABKAkSNgoQc3RvcmVf",
            "Y2F0ZWdvcmllcxgCIAMoCzIcLldVUHJvdG9zLkRhdGEuU3RvcmVDYXRlZ29y",
            "eRIyCg5zdG9yZV9yYXJpdGllcxgDIAMoCzIaLldVUHJvdG9zLkRhdGEuU3Rv",
            "cmVSYXJpdHkSJAocZGVmYXVsdF9zdG9yZV9wYWNrX2ljb25fcGF0aBgEIAEo",
            "CWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.StoreCategoryReflection.Descriptor, global::WUProtos.Data.StoreRarityReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientStoreConfig), global::WUProtos.Data.Client.ClientStoreConfig.Parser, new[]{ "Id", "StoreCategories", "StoreRarities", "DefaultStorePackIconPath" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientStoreConfig : pb::IMessage<ClientStoreConfig> {
    private static readonly pb::MessageParser<ClientStoreConfig> _parser = new pb::MessageParser<ClientStoreConfig>(() => new ClientStoreConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientStoreConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientStoreConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientStoreConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientStoreConfig(ClientStoreConfig other) : this() {
      id_ = other.id_;
      storeCategories_ = other.storeCategories_.Clone();
      storeRarities_ = other.storeRarities_.Clone();
      defaultStorePackIconPath_ = other.defaultStorePackIconPath_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientStoreConfig Clone() {
      return new ClientStoreConfig(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "store_categories" field.</summary>
    public const int StoreCategoriesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::WUProtos.Data.StoreCategory> _repeated_storeCategories_codec
        = pb::FieldCodec.ForMessage(18, global::WUProtos.Data.StoreCategory.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.StoreCategory> storeCategories_ = new pbc::RepeatedField<global::WUProtos.Data.StoreCategory>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.StoreCategory> StoreCategories {
      get { return storeCategories_; }
    }

    /// <summary>Field number for the "store_rarities" field.</summary>
    public const int StoreRaritiesFieldNumber = 3;
    private static readonly pb::FieldCodec<global::WUProtos.Data.StoreRarity> _repeated_storeRarities_codec
        = pb::FieldCodec.ForMessage(26, global::WUProtos.Data.StoreRarity.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.StoreRarity> storeRarities_ = new pbc::RepeatedField<global::WUProtos.Data.StoreRarity>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.StoreRarity> StoreRarities {
      get { return storeRarities_; }
    }

    /// <summary>Field number for the "default_store_pack_icon_path" field.</summary>
    public const int DefaultStorePackIconPathFieldNumber = 4;
    private string defaultStorePackIconPath_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DefaultStorePackIconPath {
      get { return defaultStorePackIconPath_; }
      set {
        defaultStorePackIconPath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientStoreConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientStoreConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if(!storeCategories_.Equals(other.storeCategories_)) return false;
      if(!storeRarities_.Equals(other.storeRarities_)) return false;
      if (DefaultStorePackIconPath != other.DefaultStorePackIconPath) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      hash ^= storeCategories_.GetHashCode();
      hash ^= storeRarities_.GetHashCode();
      if (DefaultStorePackIconPath.Length != 0) hash ^= DefaultStorePackIconPath.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      storeCategories_.WriteTo(output, _repeated_storeCategories_codec);
      storeRarities_.WriteTo(output, _repeated_storeRarities_codec);
      if (DefaultStorePackIconPath.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DefaultStorePackIconPath);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      size += storeCategories_.CalculateSize(_repeated_storeCategories_codec);
      size += storeRarities_.CalculateSize(_repeated_storeRarities_codec);
      if (DefaultStorePackIconPath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DefaultStorePackIconPath);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientStoreConfig other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      storeCategories_.Add(other.storeCategories_);
      storeRarities_.Add(other.storeRarities_);
      if (other.DefaultStorePackIconPath.Length != 0) {
        DefaultStorePackIconPath = other.DefaultStorePackIconPath;
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            storeCategories_.AddEntriesFrom(input, _repeated_storeCategories_codec);
            break;
          }
          case 26: {
            storeRarities_.AddEntriesFrom(input, _repeated_storeRarities_codec);
            break;
          }
          case 34: {
            DefaultStorePackIconPath = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
