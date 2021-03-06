// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Potion/PotionIngredientVaultItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Potion {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Potion/PotionIngredientVaultItem.proto</summary>
  public static partial class PotionIngredientVaultItemReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Potion/PotionIngredientVaultItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PotionIngredientVaultItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRXVVByb3Rvcy9EYXRhL1BvdGlvbi9Qb3Rpb25JbmdyZWRpZW50VmF1bHRJ",
            "dGVtLnByb3RvEhRXVVByb3Rvcy5EYXRhLlBvdGlvbhonV1VQcm90b3MvRGF0",
            "YS9Mb290L0xvb3RDb2xsZWN0aW9uLnByb3RvIk0KGVBvdGlvbkluZ3JlZGll",
            "bnRWYXVsdEl0ZW0SMAoEY29zdBgBIAEoCzIiLldVUHJvdG9zLkRhdGEuTG9v",
            "dC5Mb290Q29sbGVjdGlvbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Loot.LootCollectionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Potion.PotionIngredientVaultItem), global::WUProtos.Data.Potion.PotionIngredientVaultItem.Parser, new[]{ "Cost" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PotionIngredientVaultItem : pb::IMessage<PotionIngredientVaultItem> {
    private static readonly pb::MessageParser<PotionIngredientVaultItem> _parser = new pb::MessageParser<PotionIngredientVaultItem>(() => new PotionIngredientVaultItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PotionIngredientVaultItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Potion.PotionIngredientVaultItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PotionIngredientVaultItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PotionIngredientVaultItem(PotionIngredientVaultItem other) : this() {
      cost_ = other.cost_ != null ? other.cost_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PotionIngredientVaultItem Clone() {
      return new PotionIngredientVaultItem(this);
    }

    /// <summary>Field number for the "cost" field.</summary>
    public const int CostFieldNumber = 1;
    private global::WUProtos.Data.Loot.LootCollection cost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Loot.LootCollection Cost {
      get { return cost_; }
      set {
        cost_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PotionIngredientVaultItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PotionIngredientVaultItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Cost, other.Cost)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (cost_ != null) hash ^= Cost.GetHashCode();
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
      if (cost_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Cost);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (cost_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Cost);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PotionIngredientVaultItem other) {
      if (other == null) {
        return;
      }
      if (other.cost_ != null) {
        if (cost_ == null) {
          Cost = new global::WUProtos.Data.Loot.LootCollection();
        }
        Cost.MergeFrom(other.Cost);
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
            if (cost_ == null) {
              Cost = new global::WUProtos.Data.Loot.LootCollection();
            }
            input.ReadMessage(Cost);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
