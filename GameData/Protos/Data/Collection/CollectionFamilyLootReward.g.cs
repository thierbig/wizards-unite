// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Collection/CollectionFamilyLootReward.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Collection {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Collection/CollectionFamilyLootReward.proto</summary>
  public static partial class CollectionFamilyLootRewardReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Collection/CollectionFamilyLootReward.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CollectionFamilyLootRewardReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjlXVVByb3Rvcy9EYXRhL0NvbGxlY3Rpb24vQ29sbGVjdGlvbkZhbWlseUxv",
            "b3RSZXdhcmQucHJvdG8SGFdVUHJvdG9zLkRhdGEuQ29sbGVjdGlvbiI/ChpD",
            "b2xsZWN0aW9uRmFtaWx5TG9vdFJld2FyZBIRCglmYW1pbHlfaWQYASABKAkS",
            "DgoGYW1vdW50GAIgASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Collection.CollectionFamilyLootReward), global::WUProtos.Data.Collection.CollectionFamilyLootReward.Parser, new[]{ "FamilyId", "Amount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CollectionFamilyLootReward : pb::IMessage<CollectionFamilyLootReward> {
    private static readonly pb::MessageParser<CollectionFamilyLootReward> _parser = new pb::MessageParser<CollectionFamilyLootReward>(() => new CollectionFamilyLootReward());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CollectionFamilyLootReward> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Collection.CollectionFamilyLootRewardReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CollectionFamilyLootReward() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CollectionFamilyLootReward(CollectionFamilyLootReward other) : this() {
      familyId_ = other.familyId_;
      amount_ = other.amount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CollectionFamilyLootReward Clone() {
      return new CollectionFamilyLootReward(this);
    }

    /// <summary>Field number for the "family_id" field.</summary>
    public const int FamilyIdFieldNumber = 1;
    private string familyId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FamilyId {
      get { return familyId_; }
      set {
        familyId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 2;
    private int amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CollectionFamilyLootReward);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CollectionFamilyLootReward other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FamilyId != other.FamilyId) return false;
      if (Amount != other.Amount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FamilyId.Length != 0) hash ^= FamilyId.GetHashCode();
      if (Amount != 0) hash ^= Amount.GetHashCode();
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
      if (FamilyId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FamilyId);
      }
      if (Amount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Amount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FamilyId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FamilyId);
      }
      if (Amount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Amount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CollectionFamilyLootReward other) {
      if (other == null) {
        return;
      }
      if (other.FamilyId.Length != 0) {
        FamilyId = other.FamilyId;
      }
      if (other.Amount != 0) {
        Amount = other.Amount;
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
            FamilyId = input.ReadString();
            break;
          }
          case 16: {
            Amount = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code