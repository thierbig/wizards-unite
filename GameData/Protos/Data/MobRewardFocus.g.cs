// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/MobRewardFocus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/MobRewardFocus.proto</summary>
  public static partial class MobRewardFocusReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/MobRewardFocus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MobRewardFocusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJXVVByb3Rvcy9EYXRhL01vYlJld2FyZEZvY3VzLnByb3RvEg1XVVByb3Rv",
            "cy5EYXRhGidXVVByb3Rvcy9FbnVtcy9Nb2JSZXdhcmRSZWNpcGllbnQucHJv",
            "dG8iWQoOTW9iUmV3YXJkRm9jdXMSEAoIcXVhbnRpdHkYASABKAUSNQoJcmVj",
            "aXBpZW50GAIgASgOMiIuV1VQcm90b3MuRW51bXMuTW9iUmV3YXJkUmVjaXBp",
            "ZW50YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Enums.MobRewardRecipientReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.MobRewardFocus), global::WUProtos.Data.MobRewardFocus.Parser, new[]{ "Quantity", "Recipient" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MobRewardFocus : pb::IMessage<MobRewardFocus> {
    private static readonly pb::MessageParser<MobRewardFocus> _parser = new pb::MessageParser<MobRewardFocus>(() => new MobRewardFocus());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MobRewardFocus> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.MobRewardFocusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MobRewardFocus() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MobRewardFocus(MobRewardFocus other) : this() {
      quantity_ = other.quantity_;
      recipient_ = other.recipient_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MobRewardFocus Clone() {
      return new MobRewardFocus(this);
    }

    /// <summary>Field number for the "quantity" field.</summary>
    public const int QuantityFieldNumber = 1;
    private int quantity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Quantity {
      get { return quantity_; }
      set {
        quantity_ = value;
      }
    }

    /// <summary>Field number for the "recipient" field.</summary>
    public const int RecipientFieldNumber = 2;
    private global::WUProtos.Enums.MobRewardRecipient recipient_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Enums.MobRewardRecipient Recipient {
      get { return recipient_; }
      set {
        recipient_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MobRewardFocus);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MobRewardFocus other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Quantity != other.Quantity) return false;
      if (Recipient != other.Recipient) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Quantity != 0) hash ^= Quantity.GetHashCode();
      if (Recipient != 0) hash ^= Recipient.GetHashCode();
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
      if (Quantity != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Quantity);
      }
      if (Recipient != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Recipient);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Quantity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Quantity);
      }
      if (Recipient != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Recipient);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MobRewardFocus other) {
      if (other == null) {
        return;
      }
      if (other.Quantity != 0) {
        Quantity = other.Quantity;
      }
      if (other.Recipient != 0) {
        Recipient = other.Recipient;
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
            Quantity = input.ReadInt32();
            break;
          }
          case 16: {
            Recipient = (global::WUProtos.Enums.MobRewardRecipient) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
