// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/HookQuestTask.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/HookQuestTask.proto</summary>
  public static partial class HookQuestTaskReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/HookQuestTask.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HookQuestTaskReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFXVVByb3Rvcy9EYXRhL0hvb2tRdWVzdFRhc2sucHJvdG8SDVdVUHJvdG9z",
            "LkRhdGEaLFdVUHJvdG9zL0RhdGEvRG9FbmNvdW50ZXJIb29rUXVlc3RUYXNr",
            "LnByb3RvGi5XVVByb3Rvcy9EYXRhL0xvb3QvTG9vdE91dHBvc3RzUXVlc3RU",
            "YXNrLnByb3RvGiZXVVByb3Rvcy9EYXRhL1dpblRyYWNlc1F1ZXN0VGFzay5w",
            "cm90bxo1V1VQcm90b3MvRGF0YS9Db2xsZWN0UG90aW9uSW5ncmVkaWVudHNR",
            "dWVzdFRhc2sucHJvdG8aKFdVUHJvdG9zL0RhdGEvQnJld1BvdGlvbnNRdWVz",
            "dFRhc2sucHJvdG8aKVdVUHJvdG9zL0RhdGEvV2Fsa0Rpc3RhbmNlUXVlc3RU",
            "YXNrLnByb3RvGjNXVVByb3Rvcy9EYXRhL1BsYXlGb3J0cmVzc0NoYWxsZW5n",
            "ZXNRdWVzdFRhc2sucHJvdG8i/QMKDUhvb2tRdWVzdFRhc2sSPwoMZG9fZW5j",
            "b3VudGVyGAEgASgLMicuV1VQcm90b3MuRGF0YS5Eb0VuY291bnRlckhvb2tR",
            "dWVzdFRhc2tIABJCCg1sb290X291dHBvc3RzGAIgASgLMikuV1VQcm90b3Mu",
            "RGF0YS5Mb290Lkxvb3RPdXRwb3N0c1F1ZXN0VGFza0gAEjcKCndpbl90cmFj",
            "ZXMYAyABKAsyIS5XVVByb3Rvcy5EYXRhLldpblRyYWNlc1F1ZXN0VGFza0gA",
            "ElYKGmNvbGxlY3RfcG90aW9uX2luZ3JlZGllbnRzGAQgASgLMjAuV1VQcm90",
            "b3MuRGF0YS5Db2xsZWN0UG90aW9uSW5ncmVkaWVudHNRdWVzdFRhc2tIABI7",
            "CgxicmV3X3BvdGlvbnMYBSABKAsyIy5XVVByb3Rvcy5EYXRhLkJyZXdQb3Rp",
            "b25zUXVlc3RUYXNrSAASPQoNd2Fsa19kaXN0YW5jZRgGIAEoCzIkLldVUHJv",
            "dG9zLkRhdGEuV2Fsa0Rpc3RhbmNlUXVlc3RUYXNrSAASUgoYcGxheV9mb3J0",
            "cmVzc19jaGFsbGVuZ2VzGAcgASgLMi4uV1VQcm90b3MuRGF0YS5QbGF5Rm9y",
            "dHJlc3NDaGFsbGVuZ2VzUXVlc3RUYXNrSABCBgoEVHlwZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.DoEncounterHookQuestTaskReflection.Descriptor, global::WUProtos.Data.Loot.LootOutpostsQuestTaskReflection.Descriptor, global::WUProtos.Data.WinTracesQuestTaskReflection.Descriptor, global::WUProtos.Data.CollectPotionIngredientsQuestTaskReflection.Descriptor, global::WUProtos.Data.BrewPotionsQuestTaskReflection.Descriptor, global::WUProtos.Data.WalkDistanceQuestTaskReflection.Descriptor, global::WUProtos.Data.PlayFortressChallengesQuestTaskReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.HookQuestTask), global::WUProtos.Data.HookQuestTask.Parser, new[]{ "DoEncounter", "LootOutposts", "WinTraces", "CollectPotionIngredients", "BrewPotions", "WalkDistance", "PlayFortressChallenges" }, new[]{ "Type" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HookQuestTask : pb::IMessage<HookQuestTask> {
    private static readonly pb::MessageParser<HookQuestTask> _parser = new pb::MessageParser<HookQuestTask>(() => new HookQuestTask());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HookQuestTask> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.HookQuestTaskReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HookQuestTask() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HookQuestTask(HookQuestTask other) : this() {
      switch (other.TypeCase) {
        case TypeOneofCase.DoEncounter:
          DoEncounter = other.DoEncounter.Clone();
          break;
        case TypeOneofCase.LootOutposts:
          LootOutposts = other.LootOutposts.Clone();
          break;
        case TypeOneofCase.WinTraces:
          WinTraces = other.WinTraces.Clone();
          break;
        case TypeOneofCase.CollectPotionIngredients:
          CollectPotionIngredients = other.CollectPotionIngredients.Clone();
          break;
        case TypeOneofCase.BrewPotions:
          BrewPotions = other.BrewPotions.Clone();
          break;
        case TypeOneofCase.WalkDistance:
          WalkDistance = other.WalkDistance.Clone();
          break;
        case TypeOneofCase.PlayFortressChallenges:
          PlayFortressChallenges = other.PlayFortressChallenges.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HookQuestTask Clone() {
      return new HookQuestTask(this);
    }

    /// <summary>Field number for the "do_encounter" field.</summary>
    public const int DoEncounterFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.DoEncounterHookQuestTask DoEncounter {
      get { return typeCase_ == TypeOneofCase.DoEncounter ? (global::WUProtos.Data.DoEncounterHookQuestTask) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.DoEncounter;
      }
    }

    /// <summary>Field number for the "loot_outposts" field.</summary>
    public const int LootOutpostsFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Loot.LootOutpostsQuestTask LootOutposts {
      get { return typeCase_ == TypeOneofCase.LootOutposts ? (global::WUProtos.Data.Loot.LootOutpostsQuestTask) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.LootOutposts;
      }
    }

    /// <summary>Field number for the "win_traces" field.</summary>
    public const int WinTracesFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.WinTracesQuestTask WinTraces {
      get { return typeCase_ == TypeOneofCase.WinTraces ? (global::WUProtos.Data.WinTracesQuestTask) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.WinTraces;
      }
    }

    /// <summary>Field number for the "collect_potion_ingredients" field.</summary>
    public const int CollectPotionIngredientsFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.CollectPotionIngredientsQuestTask CollectPotionIngredients {
      get { return typeCase_ == TypeOneofCase.CollectPotionIngredients ? (global::WUProtos.Data.CollectPotionIngredientsQuestTask) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.CollectPotionIngredients;
      }
    }

    /// <summary>Field number for the "brew_potions" field.</summary>
    public const int BrewPotionsFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.BrewPotionsQuestTask BrewPotions {
      get { return typeCase_ == TypeOneofCase.BrewPotions ? (global::WUProtos.Data.BrewPotionsQuestTask) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.BrewPotions;
      }
    }

    /// <summary>Field number for the "walk_distance" field.</summary>
    public const int WalkDistanceFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.WalkDistanceQuestTask WalkDistance {
      get { return typeCase_ == TypeOneofCase.WalkDistance ? (global::WUProtos.Data.WalkDistanceQuestTask) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.WalkDistance;
      }
    }

    /// <summary>Field number for the "play_fortress_challenges" field.</summary>
    public const int PlayFortressChallengesFieldNumber = 7;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.PlayFortressChallengesQuestTask PlayFortressChallenges {
      get { return typeCase_ == TypeOneofCase.PlayFortressChallenges ? (global::WUProtos.Data.PlayFortressChallengesQuestTask) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.PlayFortressChallenges;
      }
    }

    private object type_;
    /// <summary>Enum of possible cases for the "Type" oneof.</summary>
    public enum TypeOneofCase {
      None = 0,
      DoEncounter = 1,
      LootOutposts = 2,
      WinTraces = 3,
      CollectPotionIngredients = 4,
      BrewPotions = 5,
      WalkDistance = 6,
      PlayFortressChallenges = 7,
    }
    private TypeOneofCase typeCase_ = TypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TypeOneofCase TypeCase {
      get { return typeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearType() {
      typeCase_ = TypeOneofCase.None;
      type_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HookQuestTask);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HookQuestTask other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DoEncounter, other.DoEncounter)) return false;
      if (!object.Equals(LootOutposts, other.LootOutposts)) return false;
      if (!object.Equals(WinTraces, other.WinTraces)) return false;
      if (!object.Equals(CollectPotionIngredients, other.CollectPotionIngredients)) return false;
      if (!object.Equals(BrewPotions, other.BrewPotions)) return false;
      if (!object.Equals(WalkDistance, other.WalkDistance)) return false;
      if (!object.Equals(PlayFortressChallenges, other.PlayFortressChallenges)) return false;
      if (TypeCase != other.TypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (typeCase_ == TypeOneofCase.DoEncounter) hash ^= DoEncounter.GetHashCode();
      if (typeCase_ == TypeOneofCase.LootOutposts) hash ^= LootOutposts.GetHashCode();
      if (typeCase_ == TypeOneofCase.WinTraces) hash ^= WinTraces.GetHashCode();
      if (typeCase_ == TypeOneofCase.CollectPotionIngredients) hash ^= CollectPotionIngredients.GetHashCode();
      if (typeCase_ == TypeOneofCase.BrewPotions) hash ^= BrewPotions.GetHashCode();
      if (typeCase_ == TypeOneofCase.WalkDistance) hash ^= WalkDistance.GetHashCode();
      if (typeCase_ == TypeOneofCase.PlayFortressChallenges) hash ^= PlayFortressChallenges.GetHashCode();
      hash ^= (int) typeCase_;
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
      if (typeCase_ == TypeOneofCase.DoEncounter) {
        output.WriteRawTag(10);
        output.WriteMessage(DoEncounter);
      }
      if (typeCase_ == TypeOneofCase.LootOutposts) {
        output.WriteRawTag(18);
        output.WriteMessage(LootOutposts);
      }
      if (typeCase_ == TypeOneofCase.WinTraces) {
        output.WriteRawTag(26);
        output.WriteMessage(WinTraces);
      }
      if (typeCase_ == TypeOneofCase.CollectPotionIngredients) {
        output.WriteRawTag(34);
        output.WriteMessage(CollectPotionIngredients);
      }
      if (typeCase_ == TypeOneofCase.BrewPotions) {
        output.WriteRawTag(42);
        output.WriteMessage(BrewPotions);
      }
      if (typeCase_ == TypeOneofCase.WalkDistance) {
        output.WriteRawTag(50);
        output.WriteMessage(WalkDistance);
      }
      if (typeCase_ == TypeOneofCase.PlayFortressChallenges) {
        output.WriteRawTag(58);
        output.WriteMessage(PlayFortressChallenges);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (typeCase_ == TypeOneofCase.DoEncounter) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DoEncounter);
      }
      if (typeCase_ == TypeOneofCase.LootOutposts) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LootOutposts);
      }
      if (typeCase_ == TypeOneofCase.WinTraces) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(WinTraces);
      }
      if (typeCase_ == TypeOneofCase.CollectPotionIngredients) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CollectPotionIngredients);
      }
      if (typeCase_ == TypeOneofCase.BrewPotions) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BrewPotions);
      }
      if (typeCase_ == TypeOneofCase.WalkDistance) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(WalkDistance);
      }
      if (typeCase_ == TypeOneofCase.PlayFortressChallenges) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayFortressChallenges);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HookQuestTask other) {
      if (other == null) {
        return;
      }
      switch (other.TypeCase) {
        case TypeOneofCase.DoEncounter:
          if (DoEncounter == null) {
            DoEncounter = new global::WUProtos.Data.DoEncounterHookQuestTask();
          }
          DoEncounter.MergeFrom(other.DoEncounter);
          break;
        case TypeOneofCase.LootOutposts:
          if (LootOutposts == null) {
            LootOutposts = new global::WUProtos.Data.Loot.LootOutpostsQuestTask();
          }
          LootOutposts.MergeFrom(other.LootOutposts);
          break;
        case TypeOneofCase.WinTraces:
          if (WinTraces == null) {
            WinTraces = new global::WUProtos.Data.WinTracesQuestTask();
          }
          WinTraces.MergeFrom(other.WinTraces);
          break;
        case TypeOneofCase.CollectPotionIngredients:
          if (CollectPotionIngredients == null) {
            CollectPotionIngredients = new global::WUProtos.Data.CollectPotionIngredientsQuestTask();
          }
          CollectPotionIngredients.MergeFrom(other.CollectPotionIngredients);
          break;
        case TypeOneofCase.BrewPotions:
          if (BrewPotions == null) {
            BrewPotions = new global::WUProtos.Data.BrewPotionsQuestTask();
          }
          BrewPotions.MergeFrom(other.BrewPotions);
          break;
        case TypeOneofCase.WalkDistance:
          if (WalkDistance == null) {
            WalkDistance = new global::WUProtos.Data.WalkDistanceQuestTask();
          }
          WalkDistance.MergeFrom(other.WalkDistance);
          break;
        case TypeOneofCase.PlayFortressChallenges:
          if (PlayFortressChallenges == null) {
            PlayFortressChallenges = new global::WUProtos.Data.PlayFortressChallengesQuestTask();
          }
          PlayFortressChallenges.MergeFrom(other.PlayFortressChallenges);
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
            global::WUProtos.Data.DoEncounterHookQuestTask subBuilder = new global::WUProtos.Data.DoEncounterHookQuestTask();
            if (typeCase_ == TypeOneofCase.DoEncounter) {
              subBuilder.MergeFrom(DoEncounter);
            }
            input.ReadMessage(subBuilder);
            DoEncounter = subBuilder;
            break;
          }
          case 18: {
            global::WUProtos.Data.Loot.LootOutpostsQuestTask subBuilder = new global::WUProtos.Data.Loot.LootOutpostsQuestTask();
            if (typeCase_ == TypeOneofCase.LootOutposts) {
              subBuilder.MergeFrom(LootOutposts);
            }
            input.ReadMessage(subBuilder);
            LootOutposts = subBuilder;
            break;
          }
          case 26: {
            global::WUProtos.Data.WinTracesQuestTask subBuilder = new global::WUProtos.Data.WinTracesQuestTask();
            if (typeCase_ == TypeOneofCase.WinTraces) {
              subBuilder.MergeFrom(WinTraces);
            }
            input.ReadMessage(subBuilder);
            WinTraces = subBuilder;
            break;
          }
          case 34: {
            global::WUProtos.Data.CollectPotionIngredientsQuestTask subBuilder = new global::WUProtos.Data.CollectPotionIngredientsQuestTask();
            if (typeCase_ == TypeOneofCase.CollectPotionIngredients) {
              subBuilder.MergeFrom(CollectPotionIngredients);
            }
            input.ReadMessage(subBuilder);
            CollectPotionIngredients = subBuilder;
            break;
          }
          case 42: {
            global::WUProtos.Data.BrewPotionsQuestTask subBuilder = new global::WUProtos.Data.BrewPotionsQuestTask();
            if (typeCase_ == TypeOneofCase.BrewPotions) {
              subBuilder.MergeFrom(BrewPotions);
            }
            input.ReadMessage(subBuilder);
            BrewPotions = subBuilder;
            break;
          }
          case 50: {
            global::WUProtos.Data.WalkDistanceQuestTask subBuilder = new global::WUProtos.Data.WalkDistanceQuestTask();
            if (typeCase_ == TypeOneofCase.WalkDistance) {
              subBuilder.MergeFrom(WalkDistance);
            }
            input.ReadMessage(subBuilder);
            WalkDistance = subBuilder;
            break;
          }
          case 58: {
            global::WUProtos.Data.PlayFortressChallengesQuestTask subBuilder = new global::WUProtos.Data.PlayFortressChallengesQuestTask();
            if (typeCase_ == TypeOneofCase.PlayFortressChallenges) {
              subBuilder.MergeFrom(PlayFortressChallenges);
            }
            input.ReadMessage(subBuilder);
            PlayFortressChallenges = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code