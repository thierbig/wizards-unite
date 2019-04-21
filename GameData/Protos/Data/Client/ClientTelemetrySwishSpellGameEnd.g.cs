// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientTelemetrySwishSpellGameEnd.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientTelemetrySwishSpellGameEnd.proto</summary>
  public static partial class ClientTelemetrySwishSpellGameEndReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientTelemetrySwishSpellGameEnd.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientTelemetrySwishSpellGameEndReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjtXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRUZWxlbWV0cnlTd2lzaFNw",
            "ZWxsR2FtZUVuZC5wcm90bxIUV1VQcm90b3MuRGF0YS5DbGllbnQiowMKIENs",
            "aWVudFRlbGVtZXRyeVN3aXNoU3BlbGxHYW1lRW5kEhQKDGVuY291bnRlcl9p",
            "ZBgBIAEoCRIWCg5hdHRlbXB0X251bWJlchgCIAEoBRIPCgdzdWNjZXNzGAMg",
            "ASgIElYKC2ZhaWxfcmVhc29uGAQgASgOMkEuV1VQcm90b3MuRGF0YS5DbGll",
            "bnQuQ2xpZW50VGVsZW1ldHJ5U3dpc2hTcGVsbEdhbWVFbmQuRmFpbFJlYXNv",
            "bhIRCgljYXN0X3RpbWUYBSABKAESIAoYZmFpbGVkX2NoZWNrcG9pbnRfbnVt",
            "YmVyGAYgASgFEh0KFWF2ZXJhZ2VfZHJhd2luZ19lcnJvchgHIAEoARIcChRt",
            "ZWRpYW5fZHJhd2luZ19lcnJvchgIIAEoARIcChRmaW5hbF9zcGVsbGJhcl9z",
            "Y29yZRgJIAEoARIaChJlbmNvdW50ZXJfcHJvdG9faWQYCiABKAkiPAoKRmFp",
            "bFJlYXNvbhIICgRub25lEAASCQoFdGltZXIQARIOCgpjaGVja3BvaW50EAIS",
            "CQoFc2NvcmUQA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientTelemetrySwishSpellGameEnd), global::WUProtos.Data.Client.ClientTelemetrySwishSpellGameEnd.Parser, new[]{ "EncounterId", "AttemptNumber", "Success", "FailReason", "CastTime", "FailedCheckpointNumber", "AverageDrawingError", "MedianDrawingError", "FinalSpellbarScore", "EncounterProtoId" }, null, new[]{ typeof(global::WUProtos.Data.Client.ClientTelemetrySwishSpellGameEnd.Types.FailReason) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientTelemetrySwishSpellGameEnd : pb::IMessage<ClientTelemetrySwishSpellGameEnd> {
    private static readonly pb::MessageParser<ClientTelemetrySwishSpellGameEnd> _parser = new pb::MessageParser<ClientTelemetrySwishSpellGameEnd>(() => new ClientTelemetrySwishSpellGameEnd());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientTelemetrySwishSpellGameEnd> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientTelemetrySwishSpellGameEndReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetrySwishSpellGameEnd() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetrySwishSpellGameEnd(ClientTelemetrySwishSpellGameEnd other) : this() {
      encounterId_ = other.encounterId_;
      attemptNumber_ = other.attemptNumber_;
      success_ = other.success_;
      failReason_ = other.failReason_;
      castTime_ = other.castTime_;
      failedCheckpointNumber_ = other.failedCheckpointNumber_;
      averageDrawingError_ = other.averageDrawingError_;
      medianDrawingError_ = other.medianDrawingError_;
      finalSpellbarScore_ = other.finalSpellbarScore_;
      encounterProtoId_ = other.encounterProtoId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetrySwishSpellGameEnd Clone() {
      return new ClientTelemetrySwishSpellGameEnd(this);
    }

    /// <summary>Field number for the "encounter_id" field.</summary>
    public const int EncounterIdFieldNumber = 1;
    private string encounterId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EncounterId {
      get { return encounterId_; }
      set {
        encounterId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "attempt_number" field.</summary>
    public const int AttemptNumberFieldNumber = 2;
    private int attemptNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int AttemptNumber {
      get { return attemptNumber_; }
      set {
        attemptNumber_ = value;
      }
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 3;
    private bool success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    /// <summary>Field number for the "fail_reason" field.</summary>
    public const int FailReasonFieldNumber = 4;
    private global::WUProtos.Data.Client.ClientTelemetrySwishSpellGameEnd.Types.FailReason failReason_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Client.ClientTelemetrySwishSpellGameEnd.Types.FailReason FailReason {
      get { return failReason_; }
      set {
        failReason_ = value;
      }
    }

    /// <summary>Field number for the "cast_time" field.</summary>
    public const int CastTimeFieldNumber = 5;
    private double castTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double CastTime {
      get { return castTime_; }
      set {
        castTime_ = value;
      }
    }

    /// <summary>Field number for the "failed_checkpoint_number" field.</summary>
    public const int FailedCheckpointNumberFieldNumber = 6;
    private int failedCheckpointNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FailedCheckpointNumber {
      get { return failedCheckpointNumber_; }
      set {
        failedCheckpointNumber_ = value;
      }
    }

    /// <summary>Field number for the "average_drawing_error" field.</summary>
    public const int AverageDrawingErrorFieldNumber = 7;
    private double averageDrawingError_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double AverageDrawingError {
      get { return averageDrawingError_; }
      set {
        averageDrawingError_ = value;
      }
    }

    /// <summary>Field number for the "median_drawing_error" field.</summary>
    public const int MedianDrawingErrorFieldNumber = 8;
    private double medianDrawingError_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double MedianDrawingError {
      get { return medianDrawingError_; }
      set {
        medianDrawingError_ = value;
      }
    }

    /// <summary>Field number for the "final_spellbar_score" field.</summary>
    public const int FinalSpellbarScoreFieldNumber = 9;
    private double finalSpellbarScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double FinalSpellbarScore {
      get { return finalSpellbarScore_; }
      set {
        finalSpellbarScore_ = value;
      }
    }

    /// <summary>Field number for the "encounter_proto_id" field.</summary>
    public const int EncounterProtoIdFieldNumber = 10;
    private string encounterProtoId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EncounterProtoId {
      get { return encounterProtoId_; }
      set {
        encounterProtoId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientTelemetrySwishSpellGameEnd);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientTelemetrySwishSpellGameEnd other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EncounterId != other.EncounterId) return false;
      if (AttemptNumber != other.AttemptNumber) return false;
      if (Success != other.Success) return false;
      if (FailReason != other.FailReason) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CastTime, other.CastTime)) return false;
      if (FailedCheckpointNumber != other.FailedCheckpointNumber) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(AverageDrawingError, other.AverageDrawingError)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MedianDrawingError, other.MedianDrawingError)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(FinalSpellbarScore, other.FinalSpellbarScore)) return false;
      if (EncounterProtoId != other.EncounterProtoId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EncounterId.Length != 0) hash ^= EncounterId.GetHashCode();
      if (AttemptNumber != 0) hash ^= AttemptNumber.GetHashCode();
      if (Success != false) hash ^= Success.GetHashCode();
      if (FailReason != 0) hash ^= FailReason.GetHashCode();
      if (CastTime != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CastTime);
      if (FailedCheckpointNumber != 0) hash ^= FailedCheckpointNumber.GetHashCode();
      if (AverageDrawingError != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(AverageDrawingError);
      if (MedianDrawingError != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MedianDrawingError);
      if (FinalSpellbarScore != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(FinalSpellbarScore);
      if (EncounterProtoId.Length != 0) hash ^= EncounterProtoId.GetHashCode();
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
      if (EncounterId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(EncounterId);
      }
      if (AttemptNumber != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(AttemptNumber);
      }
      if (Success != false) {
        output.WriteRawTag(24);
        output.WriteBool(Success);
      }
      if (FailReason != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) FailReason);
      }
      if (CastTime != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(CastTime);
      }
      if (FailedCheckpointNumber != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(FailedCheckpointNumber);
      }
      if (AverageDrawingError != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(AverageDrawingError);
      }
      if (MedianDrawingError != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(MedianDrawingError);
      }
      if (FinalSpellbarScore != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(FinalSpellbarScore);
      }
      if (EncounterProtoId.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(EncounterProtoId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EncounterId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EncounterId);
      }
      if (AttemptNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AttemptNumber);
      }
      if (Success != false) {
        size += 1 + 1;
      }
      if (FailReason != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FailReason);
      }
      if (CastTime != 0D) {
        size += 1 + 8;
      }
      if (FailedCheckpointNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FailedCheckpointNumber);
      }
      if (AverageDrawingError != 0D) {
        size += 1 + 8;
      }
      if (MedianDrawingError != 0D) {
        size += 1 + 8;
      }
      if (FinalSpellbarScore != 0D) {
        size += 1 + 8;
      }
      if (EncounterProtoId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EncounterProtoId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientTelemetrySwishSpellGameEnd other) {
      if (other == null) {
        return;
      }
      if (other.EncounterId.Length != 0) {
        EncounterId = other.EncounterId;
      }
      if (other.AttemptNumber != 0) {
        AttemptNumber = other.AttemptNumber;
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      if (other.FailReason != 0) {
        FailReason = other.FailReason;
      }
      if (other.CastTime != 0D) {
        CastTime = other.CastTime;
      }
      if (other.FailedCheckpointNumber != 0) {
        FailedCheckpointNumber = other.FailedCheckpointNumber;
      }
      if (other.AverageDrawingError != 0D) {
        AverageDrawingError = other.AverageDrawingError;
      }
      if (other.MedianDrawingError != 0D) {
        MedianDrawingError = other.MedianDrawingError;
      }
      if (other.FinalSpellbarScore != 0D) {
        FinalSpellbarScore = other.FinalSpellbarScore;
      }
      if (other.EncounterProtoId.Length != 0) {
        EncounterProtoId = other.EncounterProtoId;
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
            EncounterId = input.ReadString();
            break;
          }
          case 16: {
            AttemptNumber = input.ReadInt32();
            break;
          }
          case 24: {
            Success = input.ReadBool();
            break;
          }
          case 32: {
            FailReason = (global::WUProtos.Data.Client.ClientTelemetrySwishSpellGameEnd.Types.FailReason) input.ReadEnum();
            break;
          }
          case 41: {
            CastTime = input.ReadDouble();
            break;
          }
          case 48: {
            FailedCheckpointNumber = input.ReadInt32();
            break;
          }
          case 57: {
            AverageDrawingError = input.ReadDouble();
            break;
          }
          case 65: {
            MedianDrawingError = input.ReadDouble();
            break;
          }
          case 73: {
            FinalSpellbarScore = input.ReadDouble();
            break;
          }
          case 82: {
            EncounterProtoId = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ClientTelemetrySwishSpellGameEnd message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum FailReason {
        [pbr::OriginalName("none")] None = 0,
        [pbr::OriginalName("timer")] Timer = 1,
        [pbr::OriginalName("checkpoint")] Checkpoint = 2,
        [pbr::OriginalName("score")] Score = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
