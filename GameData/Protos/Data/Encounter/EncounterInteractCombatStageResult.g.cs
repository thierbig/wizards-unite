// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Encounter/EncounterInteractCombatStageResult.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Encounter {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Encounter/EncounterInteractCombatStageResult.proto</summary>
  public static partial class EncounterInteractCombatStageResultReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Encounter/EncounterInteractCombatStageResult.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EncounterInteractCombatStageResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBXVVByb3Rvcy9EYXRhL0VuY291bnRlci9FbmNvdW50ZXJJbnRlcmFjdENv",
            "bWJhdFN0YWdlUmVzdWx0LnByb3RvEhdXVVByb3Rvcy5EYXRhLkVuY291bnRl",
            "chooV1VQcm90b3MvRGF0YS9Db21iYXQvQ29tYmF0UmVzdWx0cy5wcm90byKl",
            "AwoiRW5jb3VudGVySW50ZXJhY3RDb21iYXRTdGFnZVJlc3VsdBJSCgZzdGF0",
            "dXMYASABKA4yQi5XVVByb3Rvcy5EYXRhLkVuY291bnRlci5FbmNvdW50ZXJJ",
            "bnRlcmFjdENvbWJhdFN0YWdlUmVzdWx0LlN0YXR1cxI0CgdyZXN1bHRzGAIg",
            "ASgLMiMuV1VQcm90b3MuRGF0YS5Db21iYXQuQ29tYmF0UmVzdWx0cyL0AQoG",
            "U3RhdHVzEiIKHkNPTUJBVF9JTlRFUkFDVF9SRVNVTFRfVU5LTk9XThAAEikK",
            "JUNPTUJBVF9JTlRFUkFDVF9SRVNVTFRfRU5FTVlfREVGRUFURUQQARIjCh9D",
            "T01CQVRfSU5URVJBQ1RfUkVTVUxUX0NPTlRJTlVFEAISKgomQ09NQkFUX0lO",
            "VEVSQUNUX1JFU1VMVF9QTEFZRVJfREVGRUFURUQQAxIoCiRDT01CQVRfSU5U",
            "RVJBQ1RfUkVTVUxUX09VVF9PRl9FTkVSR1kQBBIgChxDT01CQVRfSU5URVJB",
            "Q1RfUkVTVUxUX0VSUk9SEAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Combat.CombatResultsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Encounter.EncounterInteractCombatStageResult), global::WUProtos.Data.Encounter.EncounterInteractCombatStageResult.Parser, new[]{ "Status", "Results" }, null, new[]{ typeof(global::WUProtos.Data.Encounter.EncounterInteractCombatStageResult.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EncounterInteractCombatStageResult : pb::IMessage<EncounterInteractCombatStageResult> {
    private static readonly pb::MessageParser<EncounterInteractCombatStageResult> _parser = new pb::MessageParser<EncounterInteractCombatStageResult>(() => new EncounterInteractCombatStageResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EncounterInteractCombatStageResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Encounter.EncounterInteractCombatStageResultReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterInteractCombatStageResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterInteractCombatStageResult(EncounterInteractCombatStageResult other) : this() {
      status_ = other.status_;
      results_ = other.results_ != null ? other.results_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterInteractCombatStageResult Clone() {
      return new EncounterInteractCombatStageResult(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::WUProtos.Data.Encounter.EncounterInteractCombatStageResult.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Encounter.EncounterInteractCombatStageResult.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "results" field.</summary>
    public const int ResultsFieldNumber = 2;
    private global::WUProtos.Data.Combat.CombatResults results_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Combat.CombatResults Results {
      get { return results_; }
      set {
        results_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EncounterInteractCombatStageResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EncounterInteractCombatStageResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (!object.Equals(Results, other.Results)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (results_ != null) hash ^= Results.GetHashCode();
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
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (results_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Results);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (results_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Results);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EncounterInteractCombatStageResult other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.results_ != null) {
        if (results_ == null) {
          Results = new global::WUProtos.Data.Combat.CombatResults();
        }
        Results.MergeFrom(other.Results);
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
            Status = (global::WUProtos.Data.Encounter.EncounterInteractCombatStageResult.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            if (results_ == null) {
              Results = new global::WUProtos.Data.Combat.CombatResults();
            }
            input.ReadMessage(Results);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the EncounterInteractCombatStageResult message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("COMBAT_INTERACT_RESULT_UNKNOWN")] CombatInteractResultUnknown = 0,
        [pbr::OriginalName("COMBAT_INTERACT_RESULT_ENEMY_DEFEATED")] CombatInteractResultEnemyDefeated = 1,
        [pbr::OriginalName("COMBAT_INTERACT_RESULT_CONTINUE")] CombatInteractResultContinue = 2,
        [pbr::OriginalName("COMBAT_INTERACT_RESULT_PLAYER_DEFEATED")] CombatInteractResultPlayerDefeated = 3,
        [pbr::OriginalName("COMBAT_INTERACT_RESULT_OUT_OF_ENERGY")] CombatInteractResultOutOfEnergy = 4,
        [pbr::OriginalName("COMBAT_INTERACT_RESULT_ERROR")] CombatInteractResultError = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
