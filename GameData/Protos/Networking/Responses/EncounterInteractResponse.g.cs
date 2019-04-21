// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/EncounterInteractResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/EncounterInteractResponse.proto</summary>
  public static partial class EncounterInteractResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/EncounterInteractResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EncounterInteractResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1XVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9FbmNvdW50ZXJJbnRl",
            "cmFjdFJlc3BvbnNlLnByb3RvEh1XVVByb3Rvcy5OZXR3b3JraW5nLlJlc3Bv",
            "bnNlcxo1V1VQcm90b3MvRGF0YS9FbmNvdW50ZXIvRW5jb3VudGVySW50ZXJh",
            "Y3RTdGF0dXMucHJvdG8aOldVUHJvdG9zL0RhdGEvRW5jb3VudGVyL0VuY291",
            "bnRlckludGVyYWN0U3RhZ2VSZXN1bHQucHJvdG8i4wIKGUVuY291bnRlcklu",
            "dGVyYWN0UmVzcG9uc2USQAoGc3RhdHVzGAEgASgLMjAuV1VQcm90b3MuRGF0",
            "YS5FbmNvdW50ZXIuRW5jb3VudGVySW50ZXJhY3RTdGF0dXMSRAoFc3RhZ2UY",
            "AiABKAsyNS5XVVByb3Rvcy5EYXRhLkVuY291bnRlci5FbmNvdW50ZXJJbnRl",
            "cmFjdFN0YWdlUmVzdWx0El4KDmVuY291bnRlcl90eXBlGAMgASgOMkYuV1VQ",
            "cm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuRW5jb3VudGVySW50ZXJhY3RS",
            "ZXNwb25zZS5FbmNvdW50ZXJUeXBlIl4KDUVuY291bnRlclR5cGUSCwoHVU5L",
            "Tk9XThAAEg8KC1RSQUNFX1NXSVNIEAESEAoMVFJBQ0VfQ09NQkFUEAISDQoJ",
            "V0NfQ09NQkFUEAMSDgoKSU5HUkVESUVOVBAEYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Encounter.EncounterInteractStatusReflection.Descriptor, global::WUProtos.Data.Encounter.EncounterInteractStageResultReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.EncounterInteractResponse), global::WUProtos.Networking.Responses.EncounterInteractResponse.Parser, new[]{ "Status", "Stage", "EncounterType" }, null, new[]{ typeof(global::WUProtos.Networking.Responses.EncounterInteractResponse.Types.EncounterType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EncounterInteractResponse : pb::IMessage<EncounterInteractResponse> {
    private static readonly pb::MessageParser<EncounterInteractResponse> _parser = new pb::MessageParser<EncounterInteractResponse>(() => new EncounterInteractResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EncounterInteractResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.EncounterInteractResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterInteractResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterInteractResponse(EncounterInteractResponse other) : this() {
      status_ = other.status_ != null ? other.status_.Clone() : null;
      stage_ = other.stage_ != null ? other.stage_.Clone() : null;
      encounterType_ = other.encounterType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterInteractResponse Clone() {
      return new EncounterInteractResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::WUProtos.Data.Encounter.EncounterInteractStatus status_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Encounter.EncounterInteractStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "stage" field.</summary>
    public const int StageFieldNumber = 2;
    private global::WUProtos.Data.Encounter.EncounterInteractStageResult stage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Encounter.EncounterInteractStageResult Stage {
      get { return stage_; }
      set {
        stage_ = value;
      }
    }

    /// <summary>Field number for the "encounter_type" field.</summary>
    public const int EncounterTypeFieldNumber = 3;
    private global::WUProtos.Networking.Responses.EncounterInteractResponse.Types.EncounterType encounterType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Responses.EncounterInteractResponse.Types.EncounterType EncounterType {
      get { return encounterType_; }
      set {
        encounterType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EncounterInteractResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EncounterInteractResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Status, other.Status)) return false;
      if (!object.Equals(Stage, other.Stage)) return false;
      if (EncounterType != other.EncounterType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (status_ != null) hash ^= Status.GetHashCode();
      if (stage_ != null) hash ^= Stage.GetHashCode();
      if (EncounterType != 0) hash ^= EncounterType.GetHashCode();
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
      if (status_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Status);
      }
      if (stage_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Stage);
      }
      if (EncounterType != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) EncounterType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (status_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Status);
      }
      if (stage_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Stage);
      }
      if (EncounterType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EncounterType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EncounterInteractResponse other) {
      if (other == null) {
        return;
      }
      if (other.status_ != null) {
        if (status_ == null) {
          Status = new global::WUProtos.Data.Encounter.EncounterInteractStatus();
        }
        Status.MergeFrom(other.Status);
      }
      if (other.stage_ != null) {
        if (stage_ == null) {
          Stage = new global::WUProtos.Data.Encounter.EncounterInteractStageResult();
        }
        Stage.MergeFrom(other.Stage);
      }
      if (other.EncounterType != 0) {
        EncounterType = other.EncounterType;
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
            if (status_ == null) {
              Status = new global::WUProtos.Data.Encounter.EncounterInteractStatus();
            }
            input.ReadMessage(Status);
            break;
          }
          case 18: {
            if (stage_ == null) {
              Stage = new global::WUProtos.Data.Encounter.EncounterInteractStageResult();
            }
            input.ReadMessage(Stage);
            break;
          }
          case 24: {
            EncounterType = (global::WUProtos.Networking.Responses.EncounterInteractResponse.Types.EncounterType) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the EncounterInteractResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum EncounterType {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("TRACE_SWISH")] TraceSwish = 1,
        [pbr::OriginalName("TRACE_COMBAT")] TraceCombat = 2,
        [pbr::OriginalName("WC_COMBAT")] WcCombat = 3,
        [pbr::OriginalName("INGREDIENT")] Ingredient = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
