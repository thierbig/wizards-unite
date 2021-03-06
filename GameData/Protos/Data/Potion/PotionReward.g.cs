// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Potion/PotionReward.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Potion {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Potion/PotionReward.proto</summary>
  public static partial class PotionRewardReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Potion/PotionReward.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PotionRewardReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidXVVByb3Rvcy9EYXRhL1BvdGlvbi9Qb3Rpb25SZXdhcmQucHJvdG8SFFdV",
            "UHJvdG9zLkRhdGEuUG90aW9uIlAKDFBvdGlvblJld2FyZBIUCgx0aW1lX3Rv",
            "X2JyZXcYAiABKAMSEwoLY2F1bGRyb25faWQYAyABKAMSFQoNcmVjaXBlX2dt",
            "dF9pZBgEIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Potion.PotionReward), global::WUProtos.Data.Potion.PotionReward.Parser, new[]{ "TimeToBrew", "CauldronId", "RecipeGmtId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PotionReward : pb::IMessage<PotionReward> {
    private static readonly pb::MessageParser<PotionReward> _parser = new pb::MessageParser<PotionReward>(() => new PotionReward());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PotionReward> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Potion.PotionRewardReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PotionReward() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PotionReward(PotionReward other) : this() {
      timeToBrew_ = other.timeToBrew_;
      cauldronId_ = other.cauldronId_;
      recipeGmtId_ = other.recipeGmtId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PotionReward Clone() {
      return new PotionReward(this);
    }

    /// <summary>Field number for the "time_to_brew" field.</summary>
    public const int TimeToBrewFieldNumber = 2;
    private long timeToBrew_;
    /// <summary>
    ///WUProtos.Data.Loot.LootCollection rewards = 1;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TimeToBrew {
      get { return timeToBrew_; }
      set {
        timeToBrew_ = value;
      }
    }

    /// <summary>Field number for the "cauldron_id" field.</summary>
    public const int CauldronIdFieldNumber = 3;
    private long cauldronId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CauldronId {
      get { return cauldronId_; }
      set {
        cauldronId_ = value;
      }
    }

    /// <summary>Field number for the "recipe_gmt_id" field.</summary>
    public const int RecipeGmtIdFieldNumber = 4;
    private string recipeGmtId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RecipeGmtId {
      get { return recipeGmtId_; }
      set {
        recipeGmtId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PotionReward);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PotionReward other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TimeToBrew != other.TimeToBrew) return false;
      if (CauldronId != other.CauldronId) return false;
      if (RecipeGmtId != other.RecipeGmtId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TimeToBrew != 0L) hash ^= TimeToBrew.GetHashCode();
      if (CauldronId != 0L) hash ^= CauldronId.GetHashCode();
      if (RecipeGmtId.Length != 0) hash ^= RecipeGmtId.GetHashCode();
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
      if (TimeToBrew != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(TimeToBrew);
      }
      if (CauldronId != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(CauldronId);
      }
      if (RecipeGmtId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(RecipeGmtId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TimeToBrew != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TimeToBrew);
      }
      if (CauldronId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CauldronId);
      }
      if (RecipeGmtId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RecipeGmtId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PotionReward other) {
      if (other == null) {
        return;
      }
      if (other.TimeToBrew != 0L) {
        TimeToBrew = other.TimeToBrew;
      }
      if (other.CauldronId != 0L) {
        CauldronId = other.CauldronId;
      }
      if (other.RecipeGmtId.Length != 0) {
        RecipeGmtId = other.RecipeGmtId;
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
          case 16: {
            TimeToBrew = input.ReadInt64();
            break;
          }
          case 24: {
            CauldronId = input.ReadInt64();
            break;
          }
          case 34: {
            RecipeGmtId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
