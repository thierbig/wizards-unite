// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Condition.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Condition.proto</summary>
  public static partial class ConditionReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Condition.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConditionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1XVVByb3Rvcy9EYXRhL0NvbmRpdGlvbi5wcm90bxINV1VQcm90b3MuRGF0",
            "YRogV1VQcm90b3MvRW51bXMvQm9vbExpdGVyYWwucHJvdG8aJVdVUHJvdG9z",
            "L0RhdGEvRW5lbXlUYWdDb25kaXRpb24ucHJvdG8aJVdVUHJvdG9zL0RhdGEv",
            "U3RhdHNUYWdDb25kaXRpb24ucHJvdG8aK1dVUHJvdG9zL0RhdGEvQnVmZi9C",
            "dWZmQ291bnRDb25kaXRpb24ucHJvdG8aLFdVUHJvdG9zL0RhdGEvUnVuZUlu",
            "Q2hhbGxlbmdlQ29uZGl0aW9uLnByb3RvGipXVVByb3Rvcy9EYXRhL1RpbWVS",
            "ZW1haW5pbmdDb25kaXRpb24ucHJvdG8aKFdVUHJvdG9zL0RhdGEvRm9jdXNB",
            "bW91bnRDb25kaXRpb24ucHJvdG8aLFdVUHJvdG9zL0RhdGEvVGVhbUNvbXBv",
            "c2l0aW9uQ29uZGl0aW9uLnByb3RvGiZXVVByb3Rvcy9EYXRhL1RpbWVPZkRh",
            "eUNvbmRpdGlvbi5wcm90bxokV1VQcm90b3MvRGF0YS9XZWF0aGVyQ29uZGl0",
            "aW9uLnByb3RvGilXVVByb3Rvcy9EYXRhL1RlYW1Qcm9wZXJ0eUNvbmRpdGlv",
            "bi5wcm90bxoxV1VQcm90b3MvRGF0YS9FbmVtaWVzRGVmZWF0ZWRDb3VudENv",
            "bmRpdGlvbi5wcm90byKpBgoJQ29uZGl0aW9uEi0KBmFsd2F5cxgBIAEoDjIb",
            "LldVUHJvdG9zLkVudW1zLkJvb2xMaXRlcmFsSAASOgoOZW5lbXlfdGFnX2Nv",
            "bmQYAiABKAsyIC5XVVByb3Rvcy5EYXRhLkVuZW15VGFnQ29uZGl0aW9uSAAS",
            "OgoOc3RhdHNfdGFnX2NvbmQYAyABKAsyIC5XVVByb3Rvcy5EYXRhLlN0YXRz",
            "VGFnQ29uZGl0aW9uSAASQQoPYnVmZl9jb3VudF9jb25kGAQgASgLMiYuV1VQ",
            "cm90b3MuRGF0YS5CdWZmLkJ1ZmZDb3VudENvbmRpdGlvbkgAEkkKFnJ1bmVf",
            "aW5fY2hhbGxlbmdlX2NvbmQYBSABKAsyJy5XVVByb3Rvcy5EYXRhLlJ1bmVJ",
            "bkNoYWxsZW5nZUNvbmRpdGlvbkgAEkQKE3RpbWVfcmVtYWluaW5nX2NvbmQY",
            "BiABKAsyJS5XVVByb3Rvcy5EYXRhLlRpbWVSZW1haW5pbmdDb25kaXRpb25I",
            "ABI/ChBmb2N1c19sZXZlbF9jb25kGAcgASgLMiMuV1VQcm90b3MuRGF0YS5G",
            "b2N1c0Ftb3VudENvbmRpdGlvbkgAEkgKFXRlYW1fY29tcG9zaXRpb25fY29u",
            "ZBgIIAEoCzInLldVUHJvdG9zLkRhdGEuVGVhbUNvbXBvc2l0aW9uQ29uZGl0",
            "aW9uSAASPQoQdGltZV9vZl9kYXlfY29uZBgJIAEoCzIhLldVUHJvdG9zLkRh",
            "dGEuVGltZU9mRGF5Q29uZGl0aW9uSAASNwoMd2VhdGhlcl9jb25kGAogASgL",
            "Mh8uV1VQcm90b3MuRGF0YS5XZWF0aGVyQ29uZGl0aW9uSAASQgoSdGVhbV9w",
            "cm9wZXJ0eV9jb25kGAsgASgLMiQuV1VQcm90b3MuRGF0YS5UZWFtUHJvcGVy",
            "dHlDb25kaXRpb25IABJNChVlbmVtaWVzX2RlZmVhdGVkX2NvbmQYDCABKAsy",
            "LC5XVVByb3Rvcy5EYXRhLkVuZW1pZXNEZWZlYXRlZENvdW50Q29uZGl0aW9u",
            "SABCCwoJQ29uZGl0aW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Enums.BoolLiteralReflection.Descriptor, global::WUProtos.Data.EnemyTagConditionReflection.Descriptor, global::WUProtos.Data.StatsTagConditionReflection.Descriptor, global::WUProtos.Data.Buff.BuffCountConditionReflection.Descriptor, global::WUProtos.Data.RuneInChallengeConditionReflection.Descriptor, global::WUProtos.Data.TimeRemainingConditionReflection.Descriptor, global::WUProtos.Data.FocusAmountConditionReflection.Descriptor, global::WUProtos.Data.TeamCompositionConditionReflection.Descriptor, global::WUProtos.Data.TimeOfDayConditionReflection.Descriptor, global::WUProtos.Data.WeatherConditionReflection.Descriptor, global::WUProtos.Data.TeamPropertyConditionReflection.Descriptor, global::WUProtos.Data.EnemiesDefeatedCountConditionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Condition), global::WUProtos.Data.Condition.Parser, new[]{ "Always", "EnemyTagCond", "StatsTagCond", "BuffCountCond", "RuneInChallengeCond", "TimeRemainingCond", "FocusLevelCond", "TeamCompositionCond", "TimeOfDayCond", "WeatherCond", "TeamPropertyCond", "EnemiesDefeatedCond" }, new[]{ "Condition" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Condition : pb::IMessage<Condition> {
    private static readonly pb::MessageParser<Condition> _parser = new pb::MessageParser<Condition>(() => new Condition());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Condition> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.ConditionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Condition() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Condition(Condition other) : this() {
      switch (other.ConditionCase) {
        case ConditionOneofCase.Always:
          Always = other.Always;
          break;
        case ConditionOneofCase.EnemyTagCond:
          EnemyTagCond = other.EnemyTagCond.Clone();
          break;
        case ConditionOneofCase.StatsTagCond:
          StatsTagCond = other.StatsTagCond.Clone();
          break;
        case ConditionOneofCase.BuffCountCond:
          BuffCountCond = other.BuffCountCond.Clone();
          break;
        case ConditionOneofCase.RuneInChallengeCond:
          RuneInChallengeCond = other.RuneInChallengeCond.Clone();
          break;
        case ConditionOneofCase.TimeRemainingCond:
          TimeRemainingCond = other.TimeRemainingCond.Clone();
          break;
        case ConditionOneofCase.FocusLevelCond:
          FocusLevelCond = other.FocusLevelCond.Clone();
          break;
        case ConditionOneofCase.TeamCompositionCond:
          TeamCompositionCond = other.TeamCompositionCond.Clone();
          break;
        case ConditionOneofCase.TimeOfDayCond:
          TimeOfDayCond = other.TimeOfDayCond.Clone();
          break;
        case ConditionOneofCase.WeatherCond:
          WeatherCond = other.WeatherCond.Clone();
          break;
        case ConditionOneofCase.TeamPropertyCond:
          TeamPropertyCond = other.TeamPropertyCond.Clone();
          break;
        case ConditionOneofCase.EnemiesDefeatedCond:
          EnemiesDefeatedCond = other.EnemiesDefeatedCond.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Condition Clone() {
      return new Condition(this);
    }

    /// <summary>Field number for the "always" field.</summary>
    public const int AlwaysFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Enums.BoolLiteral Always {
      get { return conditionCase_ == ConditionOneofCase.Always ? (global::WUProtos.Enums.BoolLiteral) condition_ : 0; }
      set {
        condition_ = value;
        conditionCase_ = ConditionOneofCase.Always;
      }
    }

    /// <summary>Field number for the "enemy_tag_cond" field.</summary>
    public const int EnemyTagCondFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.EnemyTagCondition EnemyTagCond {
      get { return conditionCase_ == ConditionOneofCase.EnemyTagCond ? (global::WUProtos.Data.EnemyTagCondition) condition_ : null; }
      set {
        condition_ = value;
        conditionCase_ = value == null ? ConditionOneofCase.None : ConditionOneofCase.EnemyTagCond;
      }
    }

    /// <summary>Field number for the "stats_tag_cond" field.</summary>
    public const int StatsTagCondFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.StatsTagCondition StatsTagCond {
      get { return conditionCase_ == ConditionOneofCase.StatsTagCond ? (global::WUProtos.Data.StatsTagCondition) condition_ : null; }
      set {
        condition_ = value;
        conditionCase_ = value == null ? ConditionOneofCase.None : ConditionOneofCase.StatsTagCond;
      }
    }

    /// <summary>Field number for the "buff_count_cond" field.</summary>
    public const int BuffCountCondFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Buff.BuffCountCondition BuffCountCond {
      get { return conditionCase_ == ConditionOneofCase.BuffCountCond ? (global::WUProtos.Data.Buff.BuffCountCondition) condition_ : null; }
      set {
        condition_ = value;
        conditionCase_ = value == null ? ConditionOneofCase.None : ConditionOneofCase.BuffCountCond;
      }
    }

    /// <summary>Field number for the "rune_in_challenge_cond" field.</summary>
    public const int RuneInChallengeCondFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.RuneInChallengeCondition RuneInChallengeCond {
      get { return conditionCase_ == ConditionOneofCase.RuneInChallengeCond ? (global::WUProtos.Data.RuneInChallengeCondition) condition_ : null; }
      set {
        condition_ = value;
        conditionCase_ = value == null ? ConditionOneofCase.None : ConditionOneofCase.RuneInChallengeCond;
      }
    }

    /// <summary>Field number for the "time_remaining_cond" field.</summary>
    public const int TimeRemainingCondFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.TimeRemainingCondition TimeRemainingCond {
      get { return conditionCase_ == ConditionOneofCase.TimeRemainingCond ? (global::WUProtos.Data.TimeRemainingCondition) condition_ : null; }
      set {
        condition_ = value;
        conditionCase_ = value == null ? ConditionOneofCase.None : ConditionOneofCase.TimeRemainingCond;
      }
    }

    /// <summary>Field number for the "focus_level_cond" field.</summary>
    public const int FocusLevelCondFieldNumber = 7;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.FocusAmountCondition FocusLevelCond {
      get { return conditionCase_ == ConditionOneofCase.FocusLevelCond ? (global::WUProtos.Data.FocusAmountCondition) condition_ : null; }
      set {
        condition_ = value;
        conditionCase_ = value == null ? ConditionOneofCase.None : ConditionOneofCase.FocusLevelCond;
      }
    }

    /// <summary>Field number for the "team_composition_cond" field.</summary>
    public const int TeamCompositionCondFieldNumber = 8;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.TeamCompositionCondition TeamCompositionCond {
      get { return conditionCase_ == ConditionOneofCase.TeamCompositionCond ? (global::WUProtos.Data.TeamCompositionCondition) condition_ : null; }
      set {
        condition_ = value;
        conditionCase_ = value == null ? ConditionOneofCase.None : ConditionOneofCase.TeamCompositionCond;
      }
    }

    /// <summary>Field number for the "time_of_day_cond" field.</summary>
    public const int TimeOfDayCondFieldNumber = 9;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.TimeOfDayCondition TimeOfDayCond {
      get { return conditionCase_ == ConditionOneofCase.TimeOfDayCond ? (global::WUProtos.Data.TimeOfDayCondition) condition_ : null; }
      set {
        condition_ = value;
        conditionCase_ = value == null ? ConditionOneofCase.None : ConditionOneofCase.TimeOfDayCond;
      }
    }

    /// <summary>Field number for the "weather_cond" field.</summary>
    public const int WeatherCondFieldNumber = 10;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.WeatherCondition WeatherCond {
      get { return conditionCase_ == ConditionOneofCase.WeatherCond ? (global::WUProtos.Data.WeatherCondition) condition_ : null; }
      set {
        condition_ = value;
        conditionCase_ = value == null ? ConditionOneofCase.None : ConditionOneofCase.WeatherCond;
      }
    }

    /// <summary>Field number for the "team_property_cond" field.</summary>
    public const int TeamPropertyCondFieldNumber = 11;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.TeamPropertyCondition TeamPropertyCond {
      get { return conditionCase_ == ConditionOneofCase.TeamPropertyCond ? (global::WUProtos.Data.TeamPropertyCondition) condition_ : null; }
      set {
        condition_ = value;
        conditionCase_ = value == null ? ConditionOneofCase.None : ConditionOneofCase.TeamPropertyCond;
      }
    }

    /// <summary>Field number for the "enemies_defeated_cond" field.</summary>
    public const int EnemiesDefeatedCondFieldNumber = 12;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.EnemiesDefeatedCountCondition EnemiesDefeatedCond {
      get { return conditionCase_ == ConditionOneofCase.EnemiesDefeatedCond ? (global::WUProtos.Data.EnemiesDefeatedCountCondition) condition_ : null; }
      set {
        condition_ = value;
        conditionCase_ = value == null ? ConditionOneofCase.None : ConditionOneofCase.EnemiesDefeatedCond;
      }
    }

    private object condition_;
    /// <summary>Enum of possible cases for the "Condition" oneof.</summary>
    public enum ConditionOneofCase {
      None = 0,
      Always = 1,
      EnemyTagCond = 2,
      StatsTagCond = 3,
      BuffCountCond = 4,
      RuneInChallengeCond = 5,
      TimeRemainingCond = 6,
      FocusLevelCond = 7,
      TeamCompositionCond = 8,
      TimeOfDayCond = 9,
      WeatherCond = 10,
      TeamPropertyCond = 11,
      EnemiesDefeatedCond = 12,
    }
    private ConditionOneofCase conditionCase_ = ConditionOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConditionOneofCase ConditionCase {
      get { return conditionCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearCondition() {
      conditionCase_ = ConditionOneofCase.None;
      condition_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Condition);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Condition other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Always != other.Always) return false;
      if (!object.Equals(EnemyTagCond, other.EnemyTagCond)) return false;
      if (!object.Equals(StatsTagCond, other.StatsTagCond)) return false;
      if (!object.Equals(BuffCountCond, other.BuffCountCond)) return false;
      if (!object.Equals(RuneInChallengeCond, other.RuneInChallengeCond)) return false;
      if (!object.Equals(TimeRemainingCond, other.TimeRemainingCond)) return false;
      if (!object.Equals(FocusLevelCond, other.FocusLevelCond)) return false;
      if (!object.Equals(TeamCompositionCond, other.TeamCompositionCond)) return false;
      if (!object.Equals(TimeOfDayCond, other.TimeOfDayCond)) return false;
      if (!object.Equals(WeatherCond, other.WeatherCond)) return false;
      if (!object.Equals(TeamPropertyCond, other.TeamPropertyCond)) return false;
      if (!object.Equals(EnemiesDefeatedCond, other.EnemiesDefeatedCond)) return false;
      if (ConditionCase != other.ConditionCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (conditionCase_ == ConditionOneofCase.Always) hash ^= Always.GetHashCode();
      if (conditionCase_ == ConditionOneofCase.EnemyTagCond) hash ^= EnemyTagCond.GetHashCode();
      if (conditionCase_ == ConditionOneofCase.StatsTagCond) hash ^= StatsTagCond.GetHashCode();
      if (conditionCase_ == ConditionOneofCase.BuffCountCond) hash ^= BuffCountCond.GetHashCode();
      if (conditionCase_ == ConditionOneofCase.RuneInChallengeCond) hash ^= RuneInChallengeCond.GetHashCode();
      if (conditionCase_ == ConditionOneofCase.TimeRemainingCond) hash ^= TimeRemainingCond.GetHashCode();
      if (conditionCase_ == ConditionOneofCase.FocusLevelCond) hash ^= FocusLevelCond.GetHashCode();
      if (conditionCase_ == ConditionOneofCase.TeamCompositionCond) hash ^= TeamCompositionCond.GetHashCode();
      if (conditionCase_ == ConditionOneofCase.TimeOfDayCond) hash ^= TimeOfDayCond.GetHashCode();
      if (conditionCase_ == ConditionOneofCase.WeatherCond) hash ^= WeatherCond.GetHashCode();
      if (conditionCase_ == ConditionOneofCase.TeamPropertyCond) hash ^= TeamPropertyCond.GetHashCode();
      if (conditionCase_ == ConditionOneofCase.EnemiesDefeatedCond) hash ^= EnemiesDefeatedCond.GetHashCode();
      hash ^= (int) conditionCase_;
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
      if (conditionCase_ == ConditionOneofCase.Always) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Always);
      }
      if (conditionCase_ == ConditionOneofCase.EnemyTagCond) {
        output.WriteRawTag(18);
        output.WriteMessage(EnemyTagCond);
      }
      if (conditionCase_ == ConditionOneofCase.StatsTagCond) {
        output.WriteRawTag(26);
        output.WriteMessage(StatsTagCond);
      }
      if (conditionCase_ == ConditionOneofCase.BuffCountCond) {
        output.WriteRawTag(34);
        output.WriteMessage(BuffCountCond);
      }
      if (conditionCase_ == ConditionOneofCase.RuneInChallengeCond) {
        output.WriteRawTag(42);
        output.WriteMessage(RuneInChallengeCond);
      }
      if (conditionCase_ == ConditionOneofCase.TimeRemainingCond) {
        output.WriteRawTag(50);
        output.WriteMessage(TimeRemainingCond);
      }
      if (conditionCase_ == ConditionOneofCase.FocusLevelCond) {
        output.WriteRawTag(58);
        output.WriteMessage(FocusLevelCond);
      }
      if (conditionCase_ == ConditionOneofCase.TeamCompositionCond) {
        output.WriteRawTag(66);
        output.WriteMessage(TeamCompositionCond);
      }
      if (conditionCase_ == ConditionOneofCase.TimeOfDayCond) {
        output.WriteRawTag(74);
        output.WriteMessage(TimeOfDayCond);
      }
      if (conditionCase_ == ConditionOneofCase.WeatherCond) {
        output.WriteRawTag(82);
        output.WriteMessage(WeatherCond);
      }
      if (conditionCase_ == ConditionOneofCase.TeamPropertyCond) {
        output.WriteRawTag(90);
        output.WriteMessage(TeamPropertyCond);
      }
      if (conditionCase_ == ConditionOneofCase.EnemiesDefeatedCond) {
        output.WriteRawTag(98);
        output.WriteMessage(EnemiesDefeatedCond);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (conditionCase_ == ConditionOneofCase.Always) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Always);
      }
      if (conditionCase_ == ConditionOneofCase.EnemyTagCond) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EnemyTagCond);
      }
      if (conditionCase_ == ConditionOneofCase.StatsTagCond) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StatsTagCond);
      }
      if (conditionCase_ == ConditionOneofCase.BuffCountCond) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BuffCountCond);
      }
      if (conditionCase_ == ConditionOneofCase.RuneInChallengeCond) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RuneInChallengeCond);
      }
      if (conditionCase_ == ConditionOneofCase.TimeRemainingCond) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TimeRemainingCond);
      }
      if (conditionCase_ == ConditionOneofCase.FocusLevelCond) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FocusLevelCond);
      }
      if (conditionCase_ == ConditionOneofCase.TeamCompositionCond) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TeamCompositionCond);
      }
      if (conditionCase_ == ConditionOneofCase.TimeOfDayCond) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TimeOfDayCond);
      }
      if (conditionCase_ == ConditionOneofCase.WeatherCond) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(WeatherCond);
      }
      if (conditionCase_ == ConditionOneofCase.TeamPropertyCond) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TeamPropertyCond);
      }
      if (conditionCase_ == ConditionOneofCase.EnemiesDefeatedCond) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EnemiesDefeatedCond);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Condition other) {
      if (other == null) {
        return;
      }
      switch (other.ConditionCase) {
        case ConditionOneofCase.Always:
          Always = other.Always;
          break;
        case ConditionOneofCase.EnemyTagCond:
          if (EnemyTagCond == null) {
            EnemyTagCond = new global::WUProtos.Data.EnemyTagCondition();
          }
          EnemyTagCond.MergeFrom(other.EnemyTagCond);
          break;
        case ConditionOneofCase.StatsTagCond:
          if (StatsTagCond == null) {
            StatsTagCond = new global::WUProtos.Data.StatsTagCondition();
          }
          StatsTagCond.MergeFrom(other.StatsTagCond);
          break;
        case ConditionOneofCase.BuffCountCond:
          if (BuffCountCond == null) {
            BuffCountCond = new global::WUProtos.Data.Buff.BuffCountCondition();
          }
          BuffCountCond.MergeFrom(other.BuffCountCond);
          break;
        case ConditionOneofCase.RuneInChallengeCond:
          if (RuneInChallengeCond == null) {
            RuneInChallengeCond = new global::WUProtos.Data.RuneInChallengeCondition();
          }
          RuneInChallengeCond.MergeFrom(other.RuneInChallengeCond);
          break;
        case ConditionOneofCase.TimeRemainingCond:
          if (TimeRemainingCond == null) {
            TimeRemainingCond = new global::WUProtos.Data.TimeRemainingCondition();
          }
          TimeRemainingCond.MergeFrom(other.TimeRemainingCond);
          break;
        case ConditionOneofCase.FocusLevelCond:
          if (FocusLevelCond == null) {
            FocusLevelCond = new global::WUProtos.Data.FocusAmountCondition();
          }
          FocusLevelCond.MergeFrom(other.FocusLevelCond);
          break;
        case ConditionOneofCase.TeamCompositionCond:
          if (TeamCompositionCond == null) {
            TeamCompositionCond = new global::WUProtos.Data.TeamCompositionCondition();
          }
          TeamCompositionCond.MergeFrom(other.TeamCompositionCond);
          break;
        case ConditionOneofCase.TimeOfDayCond:
          if (TimeOfDayCond == null) {
            TimeOfDayCond = new global::WUProtos.Data.TimeOfDayCondition();
          }
          TimeOfDayCond.MergeFrom(other.TimeOfDayCond);
          break;
        case ConditionOneofCase.WeatherCond:
          if (WeatherCond == null) {
            WeatherCond = new global::WUProtos.Data.WeatherCondition();
          }
          WeatherCond.MergeFrom(other.WeatherCond);
          break;
        case ConditionOneofCase.TeamPropertyCond:
          if (TeamPropertyCond == null) {
            TeamPropertyCond = new global::WUProtos.Data.TeamPropertyCondition();
          }
          TeamPropertyCond.MergeFrom(other.TeamPropertyCond);
          break;
        case ConditionOneofCase.EnemiesDefeatedCond:
          if (EnemiesDefeatedCond == null) {
            EnemiesDefeatedCond = new global::WUProtos.Data.EnemiesDefeatedCountCondition();
          }
          EnemiesDefeatedCond.MergeFrom(other.EnemiesDefeatedCond);
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
          case 8: {
            condition_ = input.ReadEnum();
            conditionCase_ = ConditionOneofCase.Always;
            break;
          }
          case 18: {
            global::WUProtos.Data.EnemyTagCondition subBuilder = new global::WUProtos.Data.EnemyTagCondition();
            if (conditionCase_ == ConditionOneofCase.EnemyTagCond) {
              subBuilder.MergeFrom(EnemyTagCond);
            }
            input.ReadMessage(subBuilder);
            EnemyTagCond = subBuilder;
            break;
          }
          case 26: {
            global::WUProtos.Data.StatsTagCondition subBuilder = new global::WUProtos.Data.StatsTagCondition();
            if (conditionCase_ == ConditionOneofCase.StatsTagCond) {
              subBuilder.MergeFrom(StatsTagCond);
            }
            input.ReadMessage(subBuilder);
            StatsTagCond = subBuilder;
            break;
          }
          case 34: {
            global::WUProtos.Data.Buff.BuffCountCondition subBuilder = new global::WUProtos.Data.Buff.BuffCountCondition();
            if (conditionCase_ == ConditionOneofCase.BuffCountCond) {
              subBuilder.MergeFrom(BuffCountCond);
            }
            input.ReadMessage(subBuilder);
            BuffCountCond = subBuilder;
            break;
          }
          case 42: {
            global::WUProtos.Data.RuneInChallengeCondition subBuilder = new global::WUProtos.Data.RuneInChallengeCondition();
            if (conditionCase_ == ConditionOneofCase.RuneInChallengeCond) {
              subBuilder.MergeFrom(RuneInChallengeCond);
            }
            input.ReadMessage(subBuilder);
            RuneInChallengeCond = subBuilder;
            break;
          }
          case 50: {
            global::WUProtos.Data.TimeRemainingCondition subBuilder = new global::WUProtos.Data.TimeRemainingCondition();
            if (conditionCase_ == ConditionOneofCase.TimeRemainingCond) {
              subBuilder.MergeFrom(TimeRemainingCond);
            }
            input.ReadMessage(subBuilder);
            TimeRemainingCond = subBuilder;
            break;
          }
          case 58: {
            global::WUProtos.Data.FocusAmountCondition subBuilder = new global::WUProtos.Data.FocusAmountCondition();
            if (conditionCase_ == ConditionOneofCase.FocusLevelCond) {
              subBuilder.MergeFrom(FocusLevelCond);
            }
            input.ReadMessage(subBuilder);
            FocusLevelCond = subBuilder;
            break;
          }
          case 66: {
            global::WUProtos.Data.TeamCompositionCondition subBuilder = new global::WUProtos.Data.TeamCompositionCondition();
            if (conditionCase_ == ConditionOneofCase.TeamCompositionCond) {
              subBuilder.MergeFrom(TeamCompositionCond);
            }
            input.ReadMessage(subBuilder);
            TeamCompositionCond = subBuilder;
            break;
          }
          case 74: {
            global::WUProtos.Data.TimeOfDayCondition subBuilder = new global::WUProtos.Data.TimeOfDayCondition();
            if (conditionCase_ == ConditionOneofCase.TimeOfDayCond) {
              subBuilder.MergeFrom(TimeOfDayCond);
            }
            input.ReadMessage(subBuilder);
            TimeOfDayCond = subBuilder;
            break;
          }
          case 82: {
            global::WUProtos.Data.WeatherCondition subBuilder = new global::WUProtos.Data.WeatherCondition();
            if (conditionCase_ == ConditionOneofCase.WeatherCond) {
              subBuilder.MergeFrom(WeatherCond);
            }
            input.ReadMessage(subBuilder);
            WeatherCond = subBuilder;
            break;
          }
          case 90: {
            global::WUProtos.Data.TeamPropertyCondition subBuilder = new global::WUProtos.Data.TeamPropertyCondition();
            if (conditionCase_ == ConditionOneofCase.TeamPropertyCond) {
              subBuilder.MergeFrom(TeamPropertyCond);
            }
            input.ReadMessage(subBuilder);
            TeamPropertyCond = subBuilder;
            break;
          }
          case 98: {
            global::WUProtos.Data.EnemiesDefeatedCountCondition subBuilder = new global::WUProtos.Data.EnemiesDefeatedCountCondition();
            if (conditionCase_ == ConditionOneofCase.EnemiesDefeatedCond) {
              subBuilder.MergeFrom(EnemiesDefeatedCond);
            }
            input.ReadMessage(subBuilder);
            EnemiesDefeatedCond = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
