// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Profession/ProfessionNodeLevel.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Profession {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Profession/ProfessionNodeLevel.proto</summary>
  public static partial class ProfessionNodeLevelReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Profession/ProfessionNodeLevel.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProfessionNodeLevelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJXVVByb3Rvcy9EYXRhL1Byb2Zlc3Npb24vUHJvZmVzc2lvbk5vZGVMZXZl",
            "bC5wcm90bxIYV1VQcm90b3MuRGF0YS5Qcm9mZXNzaW9uGiBXVVByb3Rvcy9E",
            "YXRhL1JlcXVpcmVtZW50cy5wcm90bxonV1VQcm90b3MvRGF0YS9Mb290L0xv",
            "b3RDb2xsZWN0aW9uLnByb3RvIo4CChNQcm9mZXNzaW9uTm9kZUxldmVsEhMK",
            "C2J1ZmZfZ210X2lkGAEgASgJEjEKDHByZXJlcXVpc2l0ZRgCIAEoCzIbLldV",
            "UHJvdG9zLkRhdGEuUmVxdWlyZW1lbnRzEjAKBGNvc3QYAyABKAsyIi5XVVBy",
            "b3Rvcy5EYXRhLkxvb3QuTG9vdENvbGxlY3Rpb24SFQoNbWFwX2FiaWxpdGll",
            "cxgEIAMoCRITCgtyYW5rX3BvaW50cxgFIAEoDSJRCgdQdXJwb3NlEggKBG5v",
            "bmUQABIICgRidWZmEAESGQoVbGVhcm5fbmV3X21hcF9hYmlsaXR5EAISFwoT",
            "dXBncmFkZV9tYXBfYWJpbGl0eRADYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.RequirementsReflection.Descriptor, global::WUProtos.Data.Loot.LootCollectionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Profession.ProfessionNodeLevel), global::WUProtos.Data.Profession.ProfessionNodeLevel.Parser, new[]{ "BuffGmtId", "Prerequisite", "Cost", "MapAbilities", "RankPoints" }, null, new[]{ typeof(global::WUProtos.Data.Profession.ProfessionNodeLevel.Types.Purpose) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProfessionNodeLevel : pb::IMessage<ProfessionNodeLevel> {
    private static readonly pb::MessageParser<ProfessionNodeLevel> _parser = new pb::MessageParser<ProfessionNodeLevel>(() => new ProfessionNodeLevel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProfessionNodeLevel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Profession.ProfessionNodeLevelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionNodeLevel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionNodeLevel(ProfessionNodeLevel other) : this() {
      buffGmtId_ = other.buffGmtId_;
      prerequisite_ = other.prerequisite_ != null ? other.prerequisite_.Clone() : null;
      cost_ = other.cost_ != null ? other.cost_.Clone() : null;
      mapAbilities_ = other.mapAbilities_.Clone();
      rankPoints_ = other.rankPoints_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionNodeLevel Clone() {
      return new ProfessionNodeLevel(this);
    }

    /// <summary>Field number for the "buff_gmt_id" field.</summary>
    public const int BuffGmtIdFieldNumber = 1;
    private string buffGmtId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BuffGmtId {
      get { return buffGmtId_; }
      set {
        buffGmtId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "prerequisite" field.</summary>
    public const int PrerequisiteFieldNumber = 2;
    private global::WUProtos.Data.Requirements prerequisite_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Requirements Prerequisite {
      get { return prerequisite_; }
      set {
        prerequisite_ = value;
      }
    }

    /// <summary>Field number for the "cost" field.</summary>
    public const int CostFieldNumber = 3;
    private global::WUProtos.Data.Loot.LootCollection cost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Loot.LootCollection Cost {
      get { return cost_; }
      set {
        cost_ = value;
      }
    }

    /// <summary>Field number for the "map_abilities" field.</summary>
    public const int MapAbilitiesFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_mapAbilities_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> mapAbilities_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> MapAbilities {
      get { return mapAbilities_; }
    }

    /// <summary>Field number for the "rank_points" field.</summary>
    public const int RankPointsFieldNumber = 5;
    private uint rankPoints_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint RankPoints {
      get { return rankPoints_; }
      set {
        rankPoints_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProfessionNodeLevel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProfessionNodeLevel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BuffGmtId != other.BuffGmtId) return false;
      if (!object.Equals(Prerequisite, other.Prerequisite)) return false;
      if (!object.Equals(Cost, other.Cost)) return false;
      if(!mapAbilities_.Equals(other.mapAbilities_)) return false;
      if (RankPoints != other.RankPoints) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BuffGmtId.Length != 0) hash ^= BuffGmtId.GetHashCode();
      if (prerequisite_ != null) hash ^= Prerequisite.GetHashCode();
      if (cost_ != null) hash ^= Cost.GetHashCode();
      hash ^= mapAbilities_.GetHashCode();
      if (RankPoints != 0) hash ^= RankPoints.GetHashCode();
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
      if (BuffGmtId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BuffGmtId);
      }
      if (prerequisite_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Prerequisite);
      }
      if (cost_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Cost);
      }
      mapAbilities_.WriteTo(output, _repeated_mapAbilities_codec);
      if (RankPoints != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(RankPoints);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BuffGmtId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BuffGmtId);
      }
      if (prerequisite_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Prerequisite);
      }
      if (cost_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Cost);
      }
      size += mapAbilities_.CalculateSize(_repeated_mapAbilities_codec);
      if (RankPoints != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RankPoints);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProfessionNodeLevel other) {
      if (other == null) {
        return;
      }
      if (other.BuffGmtId.Length != 0) {
        BuffGmtId = other.BuffGmtId;
      }
      if (other.prerequisite_ != null) {
        if (prerequisite_ == null) {
          Prerequisite = new global::WUProtos.Data.Requirements();
        }
        Prerequisite.MergeFrom(other.Prerequisite);
      }
      if (other.cost_ != null) {
        if (cost_ == null) {
          Cost = new global::WUProtos.Data.Loot.LootCollection();
        }
        Cost.MergeFrom(other.Cost);
      }
      mapAbilities_.Add(other.mapAbilities_);
      if (other.RankPoints != 0) {
        RankPoints = other.RankPoints;
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
            BuffGmtId = input.ReadString();
            break;
          }
          case 18: {
            if (prerequisite_ == null) {
              Prerequisite = new global::WUProtos.Data.Requirements();
            }
            input.ReadMessage(Prerequisite);
            break;
          }
          case 26: {
            if (cost_ == null) {
              Cost = new global::WUProtos.Data.Loot.LootCollection();
            }
            input.ReadMessage(Cost);
            break;
          }
          case 34: {
            mapAbilities_.AddEntriesFrom(input, _repeated_mapAbilities_codec);
            break;
          }
          case 40: {
            RankPoints = input.ReadUInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ProfessionNodeLevel message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Purpose {
        [pbr::OriginalName("none")] None = 0,
        [pbr::OriginalName("buff")] Buff = 1,
        [pbr::OriginalName("learn_new_map_ability")] LearnNewMapAbility = 2,
        [pbr::OriginalName("upgrade_map_ability")] UpgradeMapAbility = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
