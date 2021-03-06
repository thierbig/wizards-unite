// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientTelemetryStorePopupOpen.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientTelemetryStorePopupOpen.proto</summary>
  public static partial class ClientTelemetryStorePopupOpenReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientTelemetryStorePopupOpen.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientTelemetryStorePopupOpenReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjhXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRUZWxlbWV0cnlTdG9yZVBv",
            "cHVwT3Blbi5wcm90bxIUV1VQcm90b3MuRGF0YS5DbGllbnQiwgEKHUNsaWVu",
            "dFRlbGVtZXRyeVN0b3JlUG9wdXBPcGVuEg8KB3BhY2tfaWQYASABKAkSGQoR",
            "cGxheWVyX2Nhbl9hZmZvcmQYAiABKAgSFQoNY3VycmVuY3lfdHlwZRgDIAMo",
            "CRIMCgRjb3N0GAQgAygDEhUKDXBsYXllcl93YWxsZXQYBSADKAMSFwoPcmVh",
            "bF9tb25leV9jb3N0GAYgASgBEiAKGHJlYWxfbW9uZXlfY3VycmVuY3lfY29k",
            "ZRgHIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientTelemetryStorePopupOpen), global::WUProtos.Data.Client.ClientTelemetryStorePopupOpen.Parser, new[]{ "PackId", "PlayerCanAfford", "CurrencyType", "Cost", "PlayerWallet", "RealMoneyCost", "RealMoneyCurrencyCode" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientTelemetryStorePopupOpen : pb::IMessage<ClientTelemetryStorePopupOpen> {
    private static readonly pb::MessageParser<ClientTelemetryStorePopupOpen> _parser = new pb::MessageParser<ClientTelemetryStorePopupOpen>(() => new ClientTelemetryStorePopupOpen());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientTelemetryStorePopupOpen> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientTelemetryStorePopupOpenReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryStorePopupOpen() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryStorePopupOpen(ClientTelemetryStorePopupOpen other) : this() {
      packId_ = other.packId_;
      playerCanAfford_ = other.playerCanAfford_;
      currencyType_ = other.currencyType_.Clone();
      cost_ = other.cost_.Clone();
      playerWallet_ = other.playerWallet_.Clone();
      realMoneyCost_ = other.realMoneyCost_;
      realMoneyCurrencyCode_ = other.realMoneyCurrencyCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryStorePopupOpen Clone() {
      return new ClientTelemetryStorePopupOpen(this);
    }

    /// <summary>Field number for the "pack_id" field.</summary>
    public const int PackIdFieldNumber = 1;
    private string packId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PackId {
      get { return packId_; }
      set {
        packId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "player_can_afford" field.</summary>
    public const int PlayerCanAffordFieldNumber = 2;
    private bool playerCanAfford_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool PlayerCanAfford {
      get { return playerCanAfford_; }
      set {
        playerCanAfford_ = value;
      }
    }

    /// <summary>Field number for the "currency_type" field.</summary>
    public const int CurrencyTypeFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_currencyType_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> currencyType_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> CurrencyType {
      get { return currencyType_; }
    }

    /// <summary>Field number for the "cost" field.</summary>
    public const int CostFieldNumber = 4;
    private static readonly pb::FieldCodec<long> _repeated_cost_codec
        = pb::FieldCodec.ForInt64(34);
    private readonly pbc::RepeatedField<long> cost_ = new pbc::RepeatedField<long>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<long> Cost {
      get { return cost_; }
    }

    /// <summary>Field number for the "player_wallet" field.</summary>
    public const int PlayerWalletFieldNumber = 5;
    private static readonly pb::FieldCodec<long> _repeated_playerWallet_codec
        = pb::FieldCodec.ForInt64(42);
    private readonly pbc::RepeatedField<long> playerWallet_ = new pbc::RepeatedField<long>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<long> PlayerWallet {
      get { return playerWallet_; }
    }

    /// <summary>Field number for the "real_money_cost" field.</summary>
    public const int RealMoneyCostFieldNumber = 6;
    private double realMoneyCost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double RealMoneyCost {
      get { return realMoneyCost_; }
      set {
        realMoneyCost_ = value;
      }
    }

    /// <summary>Field number for the "real_money_currency_code" field.</summary>
    public const int RealMoneyCurrencyCodeFieldNumber = 7;
    private string realMoneyCurrencyCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RealMoneyCurrencyCode {
      get { return realMoneyCurrencyCode_; }
      set {
        realMoneyCurrencyCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientTelemetryStorePopupOpen);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientTelemetryStorePopupOpen other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PackId != other.PackId) return false;
      if (PlayerCanAfford != other.PlayerCanAfford) return false;
      if(!currencyType_.Equals(other.currencyType_)) return false;
      if(!cost_.Equals(other.cost_)) return false;
      if(!playerWallet_.Equals(other.playerWallet_)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(RealMoneyCost, other.RealMoneyCost)) return false;
      if (RealMoneyCurrencyCode != other.RealMoneyCurrencyCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PackId.Length != 0) hash ^= PackId.GetHashCode();
      if (PlayerCanAfford != false) hash ^= PlayerCanAfford.GetHashCode();
      hash ^= currencyType_.GetHashCode();
      hash ^= cost_.GetHashCode();
      hash ^= playerWallet_.GetHashCode();
      if (RealMoneyCost != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(RealMoneyCost);
      if (RealMoneyCurrencyCode.Length != 0) hash ^= RealMoneyCurrencyCode.GetHashCode();
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
      if (PackId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PackId);
      }
      if (PlayerCanAfford != false) {
        output.WriteRawTag(16);
        output.WriteBool(PlayerCanAfford);
      }
      currencyType_.WriteTo(output, _repeated_currencyType_codec);
      cost_.WriteTo(output, _repeated_cost_codec);
      playerWallet_.WriteTo(output, _repeated_playerWallet_codec);
      if (RealMoneyCost != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(RealMoneyCost);
      }
      if (RealMoneyCurrencyCode.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(RealMoneyCurrencyCode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PackId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PackId);
      }
      if (PlayerCanAfford != false) {
        size += 1 + 1;
      }
      size += currencyType_.CalculateSize(_repeated_currencyType_codec);
      size += cost_.CalculateSize(_repeated_cost_codec);
      size += playerWallet_.CalculateSize(_repeated_playerWallet_codec);
      if (RealMoneyCost != 0D) {
        size += 1 + 8;
      }
      if (RealMoneyCurrencyCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RealMoneyCurrencyCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientTelemetryStorePopupOpen other) {
      if (other == null) {
        return;
      }
      if (other.PackId.Length != 0) {
        PackId = other.PackId;
      }
      if (other.PlayerCanAfford != false) {
        PlayerCanAfford = other.PlayerCanAfford;
      }
      currencyType_.Add(other.currencyType_);
      cost_.Add(other.cost_);
      playerWallet_.Add(other.playerWallet_);
      if (other.RealMoneyCost != 0D) {
        RealMoneyCost = other.RealMoneyCost;
      }
      if (other.RealMoneyCurrencyCode.Length != 0) {
        RealMoneyCurrencyCode = other.RealMoneyCurrencyCode;
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
            PackId = input.ReadString();
            break;
          }
          case 16: {
            PlayerCanAfford = input.ReadBool();
            break;
          }
          case 26: {
            currencyType_.AddEntriesFrom(input, _repeated_currencyType_codec);
            break;
          }
          case 34:
          case 32: {
            cost_.AddEntriesFrom(input, _repeated_cost_codec);
            break;
          }
          case 42:
          case 40: {
            playerWallet_.AddEntriesFrom(input, _repeated_playerWallet_codec);
            break;
          }
          case 49: {
            RealMoneyCost = input.ReadDouble();
            break;
          }
          case 58: {
            RealMoneyCurrencyCode = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
