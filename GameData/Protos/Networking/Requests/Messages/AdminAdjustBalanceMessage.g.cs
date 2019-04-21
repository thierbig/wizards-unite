// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/AdminAdjustBalanceMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/AdminAdjustBalanceMessage.proto</summary>
  public static partial class AdminAdjustBalanceMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/AdminAdjustBalanceMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdminAdjustBalanceMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVXVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0FkbWlu",
            "QWRqdXN0QmFsYW5jZU1lc3NhZ2UucHJvdG8SJVdVUHJvdG9zLk5ldHdvcmtp",
            "bmcuUmVxdWVzdHMuTWVzc2FnZXMiaQoZQWRtaW5BZGp1c3RCYWxhbmNlTWVz",
            "c2FnZRIRCglwbGF5ZXJfaWQYASABKAkSEgoKYWRqdXN0bWVudBgCIAEoBRIV",
            "Cg1jdXJyZW5jeV90eXBlGAMgASgJEg4KBnJlYXNvbhgEIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.AdminAdjustBalanceMessage), global::WUProtos.Networking.Requests.Messages.AdminAdjustBalanceMessage.Parser, new[]{ "PlayerId", "Adjustment", "CurrencyType", "Reason" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AdminAdjustBalanceMessage : pb::IMessage<AdminAdjustBalanceMessage> {
    private static readonly pb::MessageParser<AdminAdjustBalanceMessage> _parser = new pb::MessageParser<AdminAdjustBalanceMessage>(() => new AdminAdjustBalanceMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdminAdjustBalanceMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.AdminAdjustBalanceMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdminAdjustBalanceMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdminAdjustBalanceMessage(AdminAdjustBalanceMessage other) : this() {
      playerId_ = other.playerId_;
      adjustment_ = other.adjustment_;
      currencyType_ = other.currencyType_;
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdminAdjustBalanceMessage Clone() {
      return new AdminAdjustBalanceMessage(this);
    }

    /// <summary>Field number for the "player_id" field.</summary>
    public const int PlayerIdFieldNumber = 1;
    private string playerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PlayerId {
      get { return playerId_; }
      set {
        playerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "adjustment" field.</summary>
    public const int AdjustmentFieldNumber = 2;
    private int adjustment_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Adjustment {
      get { return adjustment_; }
      set {
        adjustment_ = value;
      }
    }

    /// <summary>Field number for the "currency_type" field.</summary>
    public const int CurrencyTypeFieldNumber = 3;
    private string currencyType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CurrencyType {
      get { return currencyType_; }
      set {
        currencyType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 4;
    private string reason_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Reason {
      get { return reason_; }
      set {
        reason_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdminAdjustBalanceMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdminAdjustBalanceMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerId != other.PlayerId) return false;
      if (Adjustment != other.Adjustment) return false;
      if (CurrencyType != other.CurrencyType) return false;
      if (Reason != other.Reason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerId.Length != 0) hash ^= PlayerId.GetHashCode();
      if (Adjustment != 0) hash ^= Adjustment.GetHashCode();
      if (CurrencyType.Length != 0) hash ^= CurrencyType.GetHashCode();
      if (Reason.Length != 0) hash ^= Reason.GetHashCode();
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
      if (PlayerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PlayerId);
      }
      if (Adjustment != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Adjustment);
      }
      if (CurrencyType.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CurrencyType);
      }
      if (Reason.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Reason);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlayerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PlayerId);
      }
      if (Adjustment != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Adjustment);
      }
      if (CurrencyType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CurrencyType);
      }
      if (Reason.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdminAdjustBalanceMessage other) {
      if (other == null) {
        return;
      }
      if (other.PlayerId.Length != 0) {
        PlayerId = other.PlayerId;
      }
      if (other.Adjustment != 0) {
        Adjustment = other.Adjustment;
      }
      if (other.CurrencyType.Length != 0) {
        CurrencyType = other.CurrencyType;
      }
      if (other.Reason.Length != 0) {
        Reason = other.Reason;
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
            PlayerId = input.ReadString();
            break;
          }
          case 16: {
            Adjustment = input.ReadInt32();
            break;
          }
          case 26: {
            CurrencyType = input.ReadString();
            break;
          }
          case 34: {
            Reason = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
