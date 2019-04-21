// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientCombatMoveType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientCombatMoveType.proto</summary>
  public static partial class ClientCombatMoveTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientCombatMoveType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientCombatMoveTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9XVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRDb21iYXRNb3ZlVHlwZS5w",
            "cm90bxIUV1VQcm90b3MuRGF0YS5DbGllbnQaM1dVUHJvdG9zL0RhdGEvQ2xp",
            "ZW50L0NsaWVudENvbWJhdFBsYXllckF0dGFjay5wcm90bxo4V1VQcm90b3Mv",
            "RGF0YS9DbGllbnQvQ2xpZW50Q29tYmF0UGxheWVyQXV0b0FkdmFuY2UucHJv",
            "dG8aM1dVUHJvdG9zL0RhdGEvQ2xpZW50L0NsaWVudENvbWJhdFBsYXllckRl",
            "ZmVuZC5wcm90byLqAgoUQ2xpZW50Q29tYmF0TW92ZVR5cGUSRwoNcGxheWVy",
            "X2F0dGFjaxgBIAEoCzIuLldVUHJvdG9zLkRhdGEuQ2xpZW50LkNsaWVudENv",
            "bWJhdFBsYXllckF0dGFja0gAEkcKDXBsYXllcl9kZWZlbmQYAiABKAsyLi5X",
            "VVByb3Rvcy5EYXRhLkNsaWVudC5DbGllbnRDb21iYXRQbGF5ZXJEZWZlbmRI",
            "ABJSChNwbGF5ZXJfYXV0b19hZHZhbmNlGAMgASgLMjMuV1VQcm90b3MuRGF0",
            "YS5DbGllbnQuQ2xpZW50Q29tYmF0UGxheWVyQXV0b0FkdmFuY2VIABIdChVl",
            "bmVteV9hY3Rpb25fdGltZWxpbmUYBCABKAkSHwoXcGxheWVyX3N1Y2NlZWRf",
            "dGltZWxpbmUYBSABKAkSHgoWcGxheWVyX2ZhaWxlZF90aW1lbGluZRgGIAEo",
            "CUIMCgpDb21iYXRNb3ZlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Client.ClientCombatPlayerAttackReflection.Descriptor, global::WUProtos.Data.Client.ClientCombatPlayerAutoAdvanceReflection.Descriptor, global::WUProtos.Data.Client.ClientCombatPlayerDefendReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientCombatMoveType), global::WUProtos.Data.Client.ClientCombatMoveType.Parser, new[]{ "PlayerAttack", "PlayerDefend", "PlayerAutoAdvance", "EnemyActionTimeline", "PlayerSucceedTimeline", "PlayerFailedTimeline" }, new[]{ "CombatMove" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientCombatMoveType : pb::IMessage<ClientCombatMoveType> {
    private static readonly pb::MessageParser<ClientCombatMoveType> _parser = new pb::MessageParser<ClientCombatMoveType>(() => new ClientCombatMoveType());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientCombatMoveType> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientCombatMoveTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientCombatMoveType() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientCombatMoveType(ClientCombatMoveType other) : this() {
      enemyActionTimeline_ = other.enemyActionTimeline_;
      playerSucceedTimeline_ = other.playerSucceedTimeline_;
      playerFailedTimeline_ = other.playerFailedTimeline_;
      switch (other.CombatMoveCase) {
        case CombatMoveOneofCase.PlayerAttack:
          PlayerAttack = other.PlayerAttack.Clone();
          break;
        case CombatMoveOneofCase.PlayerDefend:
          PlayerDefend = other.PlayerDefend.Clone();
          break;
        case CombatMoveOneofCase.PlayerAutoAdvance:
          PlayerAutoAdvance = other.PlayerAutoAdvance.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientCombatMoveType Clone() {
      return new ClientCombatMoveType(this);
    }

    /// <summary>Field number for the "player_attack" field.</summary>
    public const int PlayerAttackFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Client.ClientCombatPlayerAttack PlayerAttack {
      get { return combatMoveCase_ == CombatMoveOneofCase.PlayerAttack ? (global::WUProtos.Data.Client.ClientCombatPlayerAttack) combatMove_ : null; }
      set {
        combatMove_ = value;
        combatMoveCase_ = value == null ? CombatMoveOneofCase.None : CombatMoveOneofCase.PlayerAttack;
      }
    }

    /// <summary>Field number for the "player_defend" field.</summary>
    public const int PlayerDefendFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Client.ClientCombatPlayerDefend PlayerDefend {
      get { return combatMoveCase_ == CombatMoveOneofCase.PlayerDefend ? (global::WUProtos.Data.Client.ClientCombatPlayerDefend) combatMove_ : null; }
      set {
        combatMove_ = value;
        combatMoveCase_ = value == null ? CombatMoveOneofCase.None : CombatMoveOneofCase.PlayerDefend;
      }
    }

    /// <summary>Field number for the "player_auto_advance" field.</summary>
    public const int PlayerAutoAdvanceFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Client.ClientCombatPlayerAutoAdvance PlayerAutoAdvance {
      get { return combatMoveCase_ == CombatMoveOneofCase.PlayerAutoAdvance ? (global::WUProtos.Data.Client.ClientCombatPlayerAutoAdvance) combatMove_ : null; }
      set {
        combatMove_ = value;
        combatMoveCase_ = value == null ? CombatMoveOneofCase.None : CombatMoveOneofCase.PlayerAutoAdvance;
      }
    }

    /// <summary>Field number for the "enemy_action_timeline" field.</summary>
    public const int EnemyActionTimelineFieldNumber = 4;
    private string enemyActionTimeline_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EnemyActionTimeline {
      get { return enemyActionTimeline_; }
      set {
        enemyActionTimeline_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "player_succeed_timeline" field.</summary>
    public const int PlayerSucceedTimelineFieldNumber = 5;
    private string playerSucceedTimeline_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PlayerSucceedTimeline {
      get { return playerSucceedTimeline_; }
      set {
        playerSucceedTimeline_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "player_failed_timeline" field.</summary>
    public const int PlayerFailedTimelineFieldNumber = 6;
    private string playerFailedTimeline_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PlayerFailedTimeline {
      get { return playerFailedTimeline_; }
      set {
        playerFailedTimeline_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private object combatMove_;
    /// <summary>Enum of possible cases for the "CombatMove" oneof.</summary>
    public enum CombatMoveOneofCase {
      None = 0,
      PlayerAttack = 1,
      PlayerDefend = 2,
      PlayerAutoAdvance = 3,
    }
    private CombatMoveOneofCase combatMoveCase_ = CombatMoveOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CombatMoveOneofCase CombatMoveCase {
      get { return combatMoveCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearCombatMove() {
      combatMoveCase_ = CombatMoveOneofCase.None;
      combatMove_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientCombatMoveType);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientCombatMoveType other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PlayerAttack, other.PlayerAttack)) return false;
      if (!object.Equals(PlayerDefend, other.PlayerDefend)) return false;
      if (!object.Equals(PlayerAutoAdvance, other.PlayerAutoAdvance)) return false;
      if (EnemyActionTimeline != other.EnemyActionTimeline) return false;
      if (PlayerSucceedTimeline != other.PlayerSucceedTimeline) return false;
      if (PlayerFailedTimeline != other.PlayerFailedTimeline) return false;
      if (CombatMoveCase != other.CombatMoveCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (combatMoveCase_ == CombatMoveOneofCase.PlayerAttack) hash ^= PlayerAttack.GetHashCode();
      if (combatMoveCase_ == CombatMoveOneofCase.PlayerDefend) hash ^= PlayerDefend.GetHashCode();
      if (combatMoveCase_ == CombatMoveOneofCase.PlayerAutoAdvance) hash ^= PlayerAutoAdvance.GetHashCode();
      if (EnemyActionTimeline.Length != 0) hash ^= EnemyActionTimeline.GetHashCode();
      if (PlayerSucceedTimeline.Length != 0) hash ^= PlayerSucceedTimeline.GetHashCode();
      if (PlayerFailedTimeline.Length != 0) hash ^= PlayerFailedTimeline.GetHashCode();
      hash ^= (int) combatMoveCase_;
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
      if (combatMoveCase_ == CombatMoveOneofCase.PlayerAttack) {
        output.WriteRawTag(10);
        output.WriteMessage(PlayerAttack);
      }
      if (combatMoveCase_ == CombatMoveOneofCase.PlayerDefend) {
        output.WriteRawTag(18);
        output.WriteMessage(PlayerDefend);
      }
      if (combatMoveCase_ == CombatMoveOneofCase.PlayerAutoAdvance) {
        output.WriteRawTag(26);
        output.WriteMessage(PlayerAutoAdvance);
      }
      if (EnemyActionTimeline.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(EnemyActionTimeline);
      }
      if (PlayerSucceedTimeline.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(PlayerSucceedTimeline);
      }
      if (PlayerFailedTimeline.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(PlayerFailedTimeline);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (combatMoveCase_ == CombatMoveOneofCase.PlayerAttack) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerAttack);
      }
      if (combatMoveCase_ == CombatMoveOneofCase.PlayerDefend) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerDefend);
      }
      if (combatMoveCase_ == CombatMoveOneofCase.PlayerAutoAdvance) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerAutoAdvance);
      }
      if (EnemyActionTimeline.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EnemyActionTimeline);
      }
      if (PlayerSucceedTimeline.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PlayerSucceedTimeline);
      }
      if (PlayerFailedTimeline.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PlayerFailedTimeline);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientCombatMoveType other) {
      if (other == null) {
        return;
      }
      if (other.EnemyActionTimeline.Length != 0) {
        EnemyActionTimeline = other.EnemyActionTimeline;
      }
      if (other.PlayerSucceedTimeline.Length != 0) {
        PlayerSucceedTimeline = other.PlayerSucceedTimeline;
      }
      if (other.PlayerFailedTimeline.Length != 0) {
        PlayerFailedTimeline = other.PlayerFailedTimeline;
      }
      switch (other.CombatMoveCase) {
        case CombatMoveOneofCase.PlayerAttack:
          if (PlayerAttack == null) {
            PlayerAttack = new global::WUProtos.Data.Client.ClientCombatPlayerAttack();
          }
          PlayerAttack.MergeFrom(other.PlayerAttack);
          break;
        case CombatMoveOneofCase.PlayerDefend:
          if (PlayerDefend == null) {
            PlayerDefend = new global::WUProtos.Data.Client.ClientCombatPlayerDefend();
          }
          PlayerDefend.MergeFrom(other.PlayerDefend);
          break;
        case CombatMoveOneofCase.PlayerAutoAdvance:
          if (PlayerAutoAdvance == null) {
            PlayerAutoAdvance = new global::WUProtos.Data.Client.ClientCombatPlayerAutoAdvance();
          }
          PlayerAutoAdvance.MergeFrom(other.PlayerAutoAdvance);
          break;
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
            global::WUProtos.Data.Client.ClientCombatPlayerAttack subBuilder = new global::WUProtos.Data.Client.ClientCombatPlayerAttack();
            if (combatMoveCase_ == CombatMoveOneofCase.PlayerAttack) {
              subBuilder.MergeFrom(PlayerAttack);
            }
            input.ReadMessage(subBuilder);
            PlayerAttack = subBuilder;
            break;
          }
          case 18: {
            global::WUProtos.Data.Client.ClientCombatPlayerDefend subBuilder = new global::WUProtos.Data.Client.ClientCombatPlayerDefend();
            if (combatMoveCase_ == CombatMoveOneofCase.PlayerDefend) {
              subBuilder.MergeFrom(PlayerDefend);
            }
            input.ReadMessage(subBuilder);
            PlayerDefend = subBuilder;
            break;
          }
          case 26: {
            global::WUProtos.Data.Client.ClientCombatPlayerAutoAdvance subBuilder = new global::WUProtos.Data.Client.ClientCombatPlayerAutoAdvance();
            if (combatMoveCase_ == CombatMoveOneofCase.PlayerAutoAdvance) {
              subBuilder.MergeFrom(PlayerAutoAdvance);
            }
            input.ReadMessage(subBuilder);
            PlayerAutoAdvance = subBuilder;
            break;
          }
          case 34: {
            EnemyActionTimeline = input.ReadString();
            break;
          }
          case 42: {
            PlayerSucceedTimeline = input.ReadString();
            break;
          }
          case 50: {
            PlayerFailedTimeline = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
