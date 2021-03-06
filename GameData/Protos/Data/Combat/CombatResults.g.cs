// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Combat/CombatResults.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Combat {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Combat/CombatResults.proto</summary>
  public static partial class CombatResultsReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Combat/CombatResults.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CombatResultsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihXVVByb3Rvcy9EYXRhL0NvbWJhdC9Db21iYXRSZXN1bHRzLnByb3RvEhRX",
            "VVByb3Rvcy5EYXRhLkNvbWJhdBopV1VQcm90b3MvRGF0YS9UZW1wQ2xpZW50",
            "U3RhdHNIZWxwZXIucHJvdG8i4AIKDUNvbWJhdFJlc3VsdHMSGwoTY3VycmVu",
            "dF9zdGF0ZV9pbmRleBgBIAEoAxIUCgxjdXJyZW50X2NyaXQYAiABKAgSGAoQ",
            "bmV4dF9zdGF0ZV9pbmRleBgDIAEoAxIRCgluZXh0X2NyaXQYBCABKAgSGAoQ",
            "aHBfY3VycmVudF9lbmVteRgFIAEoAxIZChFocF9jdXJyZW50X3BsYXllchgG",
            "IAEoAxINCgVsZXZlbBgHIAEoBRIUCgxlbmVteV9kb2RnZXMYCCABKAgSFQoN",
            "cGxheWVyX2RvZGdlcxgJIAEoCBITCgtlbmVyZ3lfY29zdBgKIAEoAxIhChlp",
            "bml0aWFsX2hwX2N1cnJlbnRfcGxheWVyGAsgASgDEkYKGHRlbXBfY2xpZW50",
            "X3N0YXRzX2hlbHBlchhkIAEoCzIkLldVUHJvdG9zLkRhdGEuVGVtcENsaWVu",
            "dFN0YXRzSGVscGVyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.TempClientStatsHelperReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Combat.CombatResults), global::WUProtos.Data.Combat.CombatResults.Parser, new[]{ "CurrentStateIndex", "CurrentCrit", "NextStateIndex", "NextCrit", "HpCurrentEnemy", "HpCurrentPlayer", "Level", "EnemyDodges", "PlayerDodges", "EnergyCost", "InitialHpCurrentPlayer", "TempClientStatsHelper" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CombatResults : pb::IMessage<CombatResults> {
    private static readonly pb::MessageParser<CombatResults> _parser = new pb::MessageParser<CombatResults>(() => new CombatResults());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CombatResults> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Combat.CombatResultsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CombatResults() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CombatResults(CombatResults other) : this() {
      currentStateIndex_ = other.currentStateIndex_;
      currentCrit_ = other.currentCrit_;
      nextStateIndex_ = other.nextStateIndex_;
      nextCrit_ = other.nextCrit_;
      hpCurrentEnemy_ = other.hpCurrentEnemy_;
      hpCurrentPlayer_ = other.hpCurrentPlayer_;
      level_ = other.level_;
      enemyDodges_ = other.enemyDodges_;
      playerDodges_ = other.playerDodges_;
      energyCost_ = other.energyCost_;
      initialHpCurrentPlayer_ = other.initialHpCurrentPlayer_;
      tempClientStatsHelper_ = other.tempClientStatsHelper_ != null ? other.tempClientStatsHelper_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CombatResults Clone() {
      return new CombatResults(this);
    }

    /// <summary>Field number for the "current_state_index" field.</summary>
    public const int CurrentStateIndexFieldNumber = 1;
    private long currentStateIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CurrentStateIndex {
      get { return currentStateIndex_; }
      set {
        currentStateIndex_ = value;
      }
    }

    /// <summary>Field number for the "current_crit" field.</summary>
    public const int CurrentCritFieldNumber = 2;
    private bool currentCrit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool CurrentCrit {
      get { return currentCrit_; }
      set {
        currentCrit_ = value;
      }
    }

    /// <summary>Field number for the "next_state_index" field.</summary>
    public const int NextStateIndexFieldNumber = 3;
    private long nextStateIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long NextStateIndex {
      get { return nextStateIndex_; }
      set {
        nextStateIndex_ = value;
      }
    }

    /// <summary>Field number for the "next_crit" field.</summary>
    public const int NextCritFieldNumber = 4;
    private bool nextCrit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool NextCrit {
      get { return nextCrit_; }
      set {
        nextCrit_ = value;
      }
    }

    /// <summary>Field number for the "hp_current_enemy" field.</summary>
    public const int HpCurrentEnemyFieldNumber = 5;
    private long hpCurrentEnemy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long HpCurrentEnemy {
      get { return hpCurrentEnemy_; }
      set {
        hpCurrentEnemy_ = value;
      }
    }

    /// <summary>Field number for the "hp_current_player" field.</summary>
    public const int HpCurrentPlayerFieldNumber = 6;
    private long hpCurrentPlayer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long HpCurrentPlayer {
      get { return hpCurrentPlayer_; }
      set {
        hpCurrentPlayer_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 7;
    private int level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "enemy_dodges" field.</summary>
    public const int EnemyDodgesFieldNumber = 8;
    private bool enemyDodges_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EnemyDodges {
      get { return enemyDodges_; }
      set {
        enemyDodges_ = value;
      }
    }

    /// <summary>Field number for the "player_dodges" field.</summary>
    public const int PlayerDodgesFieldNumber = 9;
    private bool playerDodges_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool PlayerDodges {
      get { return playerDodges_; }
      set {
        playerDodges_ = value;
      }
    }

    /// <summary>Field number for the "energy_cost" field.</summary>
    public const int EnergyCostFieldNumber = 10;
    private long energyCost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long EnergyCost {
      get { return energyCost_; }
      set {
        energyCost_ = value;
      }
    }

    /// <summary>Field number for the "initial_hp_current_player" field.</summary>
    public const int InitialHpCurrentPlayerFieldNumber = 11;
    private long initialHpCurrentPlayer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long InitialHpCurrentPlayer {
      get { return initialHpCurrentPlayer_; }
      set {
        initialHpCurrentPlayer_ = value;
      }
    }

    /// <summary>Field number for the "temp_client_stats_helper" field.</summary>
    public const int TempClientStatsHelperFieldNumber = 100;
    private global::WUProtos.Data.TempClientStatsHelper tempClientStatsHelper_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.TempClientStatsHelper TempClientStatsHelper {
      get { return tempClientStatsHelper_; }
      set {
        tempClientStatsHelper_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CombatResults);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CombatResults other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurrentStateIndex != other.CurrentStateIndex) return false;
      if (CurrentCrit != other.CurrentCrit) return false;
      if (NextStateIndex != other.NextStateIndex) return false;
      if (NextCrit != other.NextCrit) return false;
      if (HpCurrentEnemy != other.HpCurrentEnemy) return false;
      if (HpCurrentPlayer != other.HpCurrentPlayer) return false;
      if (Level != other.Level) return false;
      if (EnemyDodges != other.EnemyDodges) return false;
      if (PlayerDodges != other.PlayerDodges) return false;
      if (EnergyCost != other.EnergyCost) return false;
      if (InitialHpCurrentPlayer != other.InitialHpCurrentPlayer) return false;
      if (!object.Equals(TempClientStatsHelper, other.TempClientStatsHelper)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CurrentStateIndex != 0L) hash ^= CurrentStateIndex.GetHashCode();
      if (CurrentCrit != false) hash ^= CurrentCrit.GetHashCode();
      if (NextStateIndex != 0L) hash ^= NextStateIndex.GetHashCode();
      if (NextCrit != false) hash ^= NextCrit.GetHashCode();
      if (HpCurrentEnemy != 0L) hash ^= HpCurrentEnemy.GetHashCode();
      if (HpCurrentPlayer != 0L) hash ^= HpCurrentPlayer.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (EnemyDodges != false) hash ^= EnemyDodges.GetHashCode();
      if (PlayerDodges != false) hash ^= PlayerDodges.GetHashCode();
      if (EnergyCost != 0L) hash ^= EnergyCost.GetHashCode();
      if (InitialHpCurrentPlayer != 0L) hash ^= InitialHpCurrentPlayer.GetHashCode();
      if (tempClientStatsHelper_ != null) hash ^= TempClientStatsHelper.GetHashCode();
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
      if (CurrentStateIndex != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(CurrentStateIndex);
      }
      if (CurrentCrit != false) {
        output.WriteRawTag(16);
        output.WriteBool(CurrentCrit);
      }
      if (NextStateIndex != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(NextStateIndex);
      }
      if (NextCrit != false) {
        output.WriteRawTag(32);
        output.WriteBool(NextCrit);
      }
      if (HpCurrentEnemy != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(HpCurrentEnemy);
      }
      if (HpCurrentPlayer != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(HpCurrentPlayer);
      }
      if (Level != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Level);
      }
      if (EnemyDodges != false) {
        output.WriteRawTag(64);
        output.WriteBool(EnemyDodges);
      }
      if (PlayerDodges != false) {
        output.WriteRawTag(72);
        output.WriteBool(PlayerDodges);
      }
      if (EnergyCost != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(EnergyCost);
      }
      if (InitialHpCurrentPlayer != 0L) {
        output.WriteRawTag(88);
        output.WriteInt64(InitialHpCurrentPlayer);
      }
      if (tempClientStatsHelper_ != null) {
        output.WriteRawTag(162, 6);
        output.WriteMessage(TempClientStatsHelper);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CurrentStateIndex != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CurrentStateIndex);
      }
      if (CurrentCrit != false) {
        size += 1 + 1;
      }
      if (NextStateIndex != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextStateIndex);
      }
      if (NextCrit != false) {
        size += 1 + 1;
      }
      if (HpCurrentEnemy != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(HpCurrentEnemy);
      }
      if (HpCurrentPlayer != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(HpCurrentPlayer);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      if (EnemyDodges != false) {
        size += 1 + 1;
      }
      if (PlayerDodges != false) {
        size += 1 + 1;
      }
      if (EnergyCost != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(EnergyCost);
      }
      if (InitialHpCurrentPlayer != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(InitialHpCurrentPlayer);
      }
      if (tempClientStatsHelper_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(TempClientStatsHelper);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CombatResults other) {
      if (other == null) {
        return;
      }
      if (other.CurrentStateIndex != 0L) {
        CurrentStateIndex = other.CurrentStateIndex;
      }
      if (other.CurrentCrit != false) {
        CurrentCrit = other.CurrentCrit;
      }
      if (other.NextStateIndex != 0L) {
        NextStateIndex = other.NextStateIndex;
      }
      if (other.NextCrit != false) {
        NextCrit = other.NextCrit;
      }
      if (other.HpCurrentEnemy != 0L) {
        HpCurrentEnemy = other.HpCurrentEnemy;
      }
      if (other.HpCurrentPlayer != 0L) {
        HpCurrentPlayer = other.HpCurrentPlayer;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.EnemyDodges != false) {
        EnemyDodges = other.EnemyDodges;
      }
      if (other.PlayerDodges != false) {
        PlayerDodges = other.PlayerDodges;
      }
      if (other.EnergyCost != 0L) {
        EnergyCost = other.EnergyCost;
      }
      if (other.InitialHpCurrentPlayer != 0L) {
        InitialHpCurrentPlayer = other.InitialHpCurrentPlayer;
      }
      if (other.tempClientStatsHelper_ != null) {
        if (tempClientStatsHelper_ == null) {
          TempClientStatsHelper = new global::WUProtos.Data.TempClientStatsHelper();
        }
        TempClientStatsHelper.MergeFrom(other.TempClientStatsHelper);
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
            CurrentStateIndex = input.ReadInt64();
            break;
          }
          case 16: {
            CurrentCrit = input.ReadBool();
            break;
          }
          case 24: {
            NextStateIndex = input.ReadInt64();
            break;
          }
          case 32: {
            NextCrit = input.ReadBool();
            break;
          }
          case 40: {
            HpCurrentEnemy = input.ReadInt64();
            break;
          }
          case 48: {
            HpCurrentPlayer = input.ReadInt64();
            break;
          }
          case 56: {
            Level = input.ReadInt32();
            break;
          }
          case 64: {
            EnemyDodges = input.ReadBool();
            break;
          }
          case 72: {
            PlayerDodges = input.ReadBool();
            break;
          }
          case 80: {
            EnergyCost = input.ReadInt64();
            break;
          }
          case 88: {
            InitialHpCurrentPlayer = input.ReadInt64();
            break;
          }
          case 802: {
            if (tempClientStatsHelper_ == null) {
              TempClientStatsHelper = new global::WUProtos.Data.TempClientStatsHelper();
            }
            input.ReadMessage(TempClientStatsHelper);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
