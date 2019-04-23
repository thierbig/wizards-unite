// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Combat/CombatEnemyStats.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Combat {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Combat/CombatEnemyStats.proto</summary>
  public static partial class CombatEnemyStatsReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Combat/CombatEnemyStats.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CombatEnemyStatsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitXVVByb3Rvcy9EYXRhL0NvbWJhdC9Db21iYXRFbmVteVN0YXRzLnByb3Rv",
            "EhRXVVByb3Rvcy5EYXRhLkNvbWJhdBonV1VQcm90b3MvRGF0YS9Db21iYXQv",
            "Q29tYmF0R3Jvd3RoLnByb3RvIqMCChBDb21iYXRFbmVteVN0YXRzEj4KBHN0",
            "YXQYAiADKAsyMC5XVVByb3Rvcy5EYXRhLkNvbWJhdC5Db21iYXRFbmVteVN0",
            "YXRzLlN0YXRFbnRyeRJLCgtzdGF0X2dyb3d0aBgDIAMoCzI2LldVUHJvdG9z",
            "LkRhdGEuQ29tYmF0LkNvbWJhdEVuZW15U3RhdHMuU3RhdEdyb3d0aEVudHJ5",
            "GisKCVN0YXRFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAM6AjgB",
            "GlUKD1N0YXRHcm93dGhFbnRyeRILCgNrZXkYASABKAkSMQoFdmFsdWUYAiAB",
            "KAsyIi5XVVByb3Rvcy5EYXRhLkNvbWJhdC5Db21iYXRHcm93dGg6AjgBYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Combat.CombatGrowthReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Combat.CombatEnemyStats), global::WUProtos.Data.Combat.CombatEnemyStats.Parser, new[]{ "Stat", "StatGrowth" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CombatEnemyStats : pb::IMessage<CombatEnemyStats> {
    private static readonly pb::MessageParser<CombatEnemyStats> _parser = new pb::MessageParser<CombatEnemyStats>(() => new CombatEnemyStats());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CombatEnemyStats> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Combat.CombatEnemyStatsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CombatEnemyStats() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CombatEnemyStats(CombatEnemyStats other) : this() {
      stat_ = other.stat_.Clone();
      statGrowth_ = other.statGrowth_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CombatEnemyStats Clone() {
      return new CombatEnemyStats(this);
    }

    /// <summary>Field number for the "stat" field.</summary>
    public const int StatFieldNumber = 2;
    private static readonly pbc::MapField<string, long>.Codec _map_stat_codec
        = new pbc::MapField<string, long>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForInt64(16), 18);
    private readonly pbc::MapField<string, long> stat_ = new pbc::MapField<string, long>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, long> Stat {
      get { return stat_; }
    }

    /// <summary>Field number for the "stat_growth" field.</summary>
    public const int StatGrowthFieldNumber = 3;
    private static readonly pbc::MapField<string, global::WUProtos.Data.Combat.CombatGrowth>.Codec _map_statGrowth_codec
        = new pbc::MapField<string, global::WUProtos.Data.Combat.CombatGrowth>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::WUProtos.Data.Combat.CombatGrowth.Parser), 26);
    private readonly pbc::MapField<string, global::WUProtos.Data.Combat.CombatGrowth> statGrowth_ = new pbc::MapField<string, global::WUProtos.Data.Combat.CombatGrowth>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::WUProtos.Data.Combat.CombatGrowth> StatGrowth {
      get { return statGrowth_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CombatEnemyStats);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CombatEnemyStats other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Stat.Equals(other.Stat)) return false;
      if (!StatGrowth.Equals(other.StatGrowth)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Stat.GetHashCode();
      hash ^= StatGrowth.GetHashCode();
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
      stat_.WriteTo(output, _map_stat_codec);
      statGrowth_.WriteTo(output, _map_statGrowth_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += stat_.CalculateSize(_map_stat_codec);
      size += statGrowth_.CalculateSize(_map_statGrowth_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CombatEnemyStats other) {
      if (other == null) {
        return;
      }
      stat_.Add(other.stat_);
      statGrowth_.Add(other.statGrowth_);
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
          case 18: {
            stat_.AddEntriesFrom(input, _map_stat_codec);
            break;
          }
          case 26: {
            statGrowth_.AddEntriesFrom(input, _map_statGrowth_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code