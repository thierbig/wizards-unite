// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientStorePack.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientStorePack.proto</summary>
  public static partial class ClientStorePackReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientStorePack.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientStorePackReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRTdG9yZVBhY2sucHJvdG8S",
            "FFdVUHJvdG9zLkRhdGEuQ2xpZW50GiNXVVByb3Rvcy9EYXRhL1N0b3JlUGFj",
            "a0NvbmZpZy5wcm90byLRAQoPQ2xpZW50U3RvcmVQYWNrEgoKAmlkGAEgASgJ",
            "EhoKEnNob3dfaW5faW5saW5lX2J1eRgCIAEoCBIMCgRuYW1lGAMgASgJEjkK",
            "EXN0b3JlX3BhY2tfY29uZmlnGAQgAygLMh4uV1VQcm90b3MuRGF0YS5TdG9y",
            "ZVBhY2tDb25maWcSDgoGc2t1X2lkGAUgASgJEh4KFm92ZXJyaWRlX3RpdGxl",
            "X2xvY19rZXkYBiABKAkSHQoVbWF4X3Jld2FyZF9pdGVtX2NvdW50GAcgASgF",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.StorePackConfigReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientStorePack), global::WUProtos.Data.Client.ClientStorePack.Parser, new[]{ "Id", "ShowInInlineBuy", "Name", "StorePackConfig", "SkuId", "OverrideTitleLocKey", "MaxRewardItemCount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientStorePack : pb::IMessage<ClientStorePack> {
    private static readonly pb::MessageParser<ClientStorePack> _parser = new pb::MessageParser<ClientStorePack>(() => new ClientStorePack());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientStorePack> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientStorePackReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientStorePack() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientStorePack(ClientStorePack other) : this() {
      id_ = other.id_;
      showInInlineBuy_ = other.showInInlineBuy_;
      name_ = other.name_;
      storePackConfig_ = other.storePackConfig_.Clone();
      skuId_ = other.skuId_;
      overrideTitleLocKey_ = other.overrideTitleLocKey_;
      maxRewardItemCount_ = other.maxRewardItemCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientStorePack Clone() {
      return new ClientStorePack(this);
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

    /// <summary>Field number for the "show_in_inline_buy" field.</summary>
    public const int ShowInInlineBuyFieldNumber = 2;
    private bool showInInlineBuy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ShowInInlineBuy {
      get { return showInInlineBuy_; }
      set {
        showInInlineBuy_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "store_pack_config" field.</summary>
    public const int StorePackConfigFieldNumber = 4;
    private static readonly pb::FieldCodec<global::WUProtos.Data.StorePackConfig> _repeated_storePackConfig_codec
        = pb::FieldCodec.ForMessage(34, global::WUProtos.Data.StorePackConfig.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.StorePackConfig> storePackConfig_ = new pbc::RepeatedField<global::WUProtos.Data.StorePackConfig>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.StorePackConfig> StorePackConfig {
      get { return storePackConfig_; }
    }

    /// <summary>Field number for the "sku_id" field.</summary>
    public const int SkuIdFieldNumber = 5;
    private string skuId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SkuId {
      get { return skuId_; }
      set {
        skuId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "override_title_loc_key" field.</summary>
    public const int OverrideTitleLocKeyFieldNumber = 6;
    private string overrideTitleLocKey_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OverrideTitleLocKey {
      get { return overrideTitleLocKey_; }
      set {
        overrideTitleLocKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "max_reward_item_count" field.</summary>
    public const int MaxRewardItemCountFieldNumber = 7;
    private int maxRewardItemCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxRewardItemCount {
      get { return maxRewardItemCount_; }
      set {
        maxRewardItemCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientStorePack);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientStorePack other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (ShowInInlineBuy != other.ShowInInlineBuy) return false;
      if (Name != other.Name) return false;
      if(!storePackConfig_.Equals(other.storePackConfig_)) return false;
      if (SkuId != other.SkuId) return false;
      if (OverrideTitleLocKey != other.OverrideTitleLocKey) return false;
      if (MaxRewardItemCount != other.MaxRewardItemCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (ShowInInlineBuy != false) hash ^= ShowInInlineBuy.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= storePackConfig_.GetHashCode();
      if (SkuId.Length != 0) hash ^= SkuId.GetHashCode();
      if (OverrideTitleLocKey.Length != 0) hash ^= OverrideTitleLocKey.GetHashCode();
      if (MaxRewardItemCount != 0) hash ^= MaxRewardItemCount.GetHashCode();
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
      if (ShowInInlineBuy != false) {
        output.WriteRawTag(16);
        output.WriteBool(ShowInInlineBuy);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      storePackConfig_.WriteTo(output, _repeated_storePackConfig_codec);
      if (SkuId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(SkuId);
      }
      if (OverrideTitleLocKey.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(OverrideTitleLocKey);
      }
      if (MaxRewardItemCount != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(MaxRewardItemCount);
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
      if (ShowInInlineBuy != false) {
        size += 1 + 1;
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += storePackConfig_.CalculateSize(_repeated_storePackConfig_codec);
      if (SkuId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SkuId);
      }
      if (OverrideTitleLocKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OverrideTitleLocKey);
      }
      if (MaxRewardItemCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxRewardItemCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientStorePack other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.ShowInInlineBuy != false) {
        ShowInInlineBuy = other.ShowInInlineBuy;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      storePackConfig_.Add(other.storePackConfig_);
      if (other.SkuId.Length != 0) {
        SkuId = other.SkuId;
      }
      if (other.OverrideTitleLocKey.Length != 0) {
        OverrideTitleLocKey = other.OverrideTitleLocKey;
      }
      if (other.MaxRewardItemCount != 0) {
        MaxRewardItemCount = other.MaxRewardItemCount;
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
          case 16: {
            ShowInInlineBuy = input.ReadBool();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            storePackConfig_.AddEntriesFrom(input, _repeated_storePackConfig_codec);
            break;
          }
          case 42: {
            SkuId = input.ReadString();
            break;
          }
          case 50: {
            OverrideTitleLocKey = input.ReadString();
            break;
          }
          case 56: {
            MaxRewardItemCount = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
