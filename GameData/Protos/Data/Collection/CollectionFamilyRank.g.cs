// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Collection/CollectionFamilyRank.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Collection {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Collection/CollectionFamilyRank.proto</summary>
  public static partial class CollectionFamilyRankReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Collection/CollectionFamilyRank.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CollectionFamilyRankReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNXVVByb3Rvcy9EYXRhL0NvbGxlY3Rpb24vQ29sbGVjdGlvbkZhbWlseVJh",
            "bmsucHJvdG8SGFdVUHJvdG9zLkRhdGEuQ29sbGVjdGlvbiJ8ChRDb2xsZWN0",
            "aW9uRmFtaWx5UmFuaxIUCgx0b3RhbF94cF9yZXEYASABKAMSEwoLY2hlc3Rf",
            "Y291bnQYAiABKAUSGgoSc21hbGxfbG9vdHRhYmxlX2lkGAMgASgJEh0KFWxl",
            "dmVsX3VwX2xvb3R0YWJsZV9pZBgEIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Collection.CollectionFamilyRank), global::WUProtos.Data.Collection.CollectionFamilyRank.Parser, new[]{ "TotalXpReq", "ChestCount", "SmallLoottableId", "LevelUpLoottableId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CollectionFamilyRank : pb::IMessage<CollectionFamilyRank> {
    private static readonly pb::MessageParser<CollectionFamilyRank> _parser = new pb::MessageParser<CollectionFamilyRank>(() => new CollectionFamilyRank());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CollectionFamilyRank> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Collection.CollectionFamilyRankReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CollectionFamilyRank() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CollectionFamilyRank(CollectionFamilyRank other) : this() {
      totalXpReq_ = other.totalXpReq_;
      chestCount_ = other.chestCount_;
      smallLoottableId_ = other.smallLoottableId_;
      levelUpLoottableId_ = other.levelUpLoottableId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CollectionFamilyRank Clone() {
      return new CollectionFamilyRank(this);
    }

    /// <summary>Field number for the "total_xp_req" field.</summary>
    public const int TotalXpReqFieldNumber = 1;
    private long totalXpReq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TotalXpReq {
      get { return totalXpReq_; }
      set {
        totalXpReq_ = value;
      }
    }

    /// <summary>Field number for the "chest_count" field.</summary>
    public const int ChestCountFieldNumber = 2;
    private int chestCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ChestCount {
      get { return chestCount_; }
      set {
        chestCount_ = value;
      }
    }

    /// <summary>Field number for the "small_loottable_id" field.</summary>
    public const int SmallLoottableIdFieldNumber = 3;
    private string smallLoottableId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SmallLoottableId {
      get { return smallLoottableId_; }
      set {
        smallLoottableId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "level_up_loottable_id" field.</summary>
    public const int LevelUpLoottableIdFieldNumber = 4;
    private string levelUpLoottableId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LevelUpLoottableId {
      get { return levelUpLoottableId_; }
      set {
        levelUpLoottableId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CollectionFamilyRank);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CollectionFamilyRank other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TotalXpReq != other.TotalXpReq) return false;
      if (ChestCount != other.ChestCount) return false;
      if (SmallLoottableId != other.SmallLoottableId) return false;
      if (LevelUpLoottableId != other.LevelUpLoottableId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TotalXpReq != 0L) hash ^= TotalXpReq.GetHashCode();
      if (ChestCount != 0) hash ^= ChestCount.GetHashCode();
      if (SmallLoottableId.Length != 0) hash ^= SmallLoottableId.GetHashCode();
      if (LevelUpLoottableId.Length != 0) hash ^= LevelUpLoottableId.GetHashCode();
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
      if (TotalXpReq != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(TotalXpReq);
      }
      if (ChestCount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ChestCount);
      }
      if (SmallLoottableId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SmallLoottableId);
      }
      if (LevelUpLoottableId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LevelUpLoottableId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TotalXpReq != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TotalXpReq);
      }
      if (ChestCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ChestCount);
      }
      if (SmallLoottableId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SmallLoottableId);
      }
      if (LevelUpLoottableId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LevelUpLoottableId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CollectionFamilyRank other) {
      if (other == null) {
        return;
      }
      if (other.TotalXpReq != 0L) {
        TotalXpReq = other.TotalXpReq;
      }
      if (other.ChestCount != 0) {
        ChestCount = other.ChestCount;
      }
      if (other.SmallLoottableId.Length != 0) {
        SmallLoottableId = other.SmallLoottableId;
      }
      if (other.LevelUpLoottableId.Length != 0) {
        LevelUpLoottableId = other.LevelUpLoottableId;
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
            TotalXpReq = input.ReadInt64();
            break;
          }
          case 16: {
            ChestCount = input.ReadInt32();
            break;
          }
          case 26: {
            SmallLoottableId = input.ReadString();
            break;
          }
          case 34: {
            LevelUpLoottableId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
