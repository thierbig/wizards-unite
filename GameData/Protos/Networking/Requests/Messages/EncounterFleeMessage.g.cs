// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/EncounterFleeMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/EncounterFleeMessage.proto</summary>
  public static partial class EncounterFleeMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/EncounterFleeMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EncounterFleeMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBXVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0VuY291",
            "bnRlckZsZWVNZXNzYWdlLnByb3RvEiVXVVByb3Rvcy5OZXR3b3JraW5nLlJl",
            "cXVlc3RzLk1lc3NhZ2VzIsEBChRFbmNvdW50ZXJGbGVlTWVzc2FnZRIUCgxl",
            "bmNvdW50ZXJfaWQYASABKAwSXwoNc3RhZ2Vfb3B0aW9ucxgCIAEoDjJILldV",
            "UHJvdG9zLk5ldHdvcmtpbmcuUmVxdWVzdHMuTWVzc2FnZXMuRW5jb3VudGVy",
            "RmxlZU1lc3NhZ2UuU3RhZ2VPcHRpb25zIjIKDFN0YWdlT3B0aW9ucxILCgdV",
            "TktOT1dOEAASCQoFU1dJU0gQARIKCgZDT01CQVQQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.EncounterFleeMessage), global::WUProtos.Networking.Requests.Messages.EncounterFleeMessage.Parser, new[]{ "EncounterId", "StageOptions" }, null, new[]{ typeof(global::WUProtos.Networking.Requests.Messages.EncounterFleeMessage.Types.StageOptions) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EncounterFleeMessage : pb::IMessage<EncounterFleeMessage> {
    private static readonly pb::MessageParser<EncounterFleeMessage> _parser = new pb::MessageParser<EncounterFleeMessage>(() => new EncounterFleeMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EncounterFleeMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.EncounterFleeMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterFleeMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterFleeMessage(EncounterFleeMessage other) : this() {
      encounterId_ = other.encounterId_;
      stageOptions_ = other.stageOptions_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterFleeMessage Clone() {
      return new EncounterFleeMessage(this);
    }

    /// <summary>Field number for the "encounter_id" field.</summary>
    public const int EncounterIdFieldNumber = 1;
    private pb::ByteString encounterId_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString EncounterId {
      get { return encounterId_; }
      set {
        encounterId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stage_options" field.</summary>
    public const int StageOptionsFieldNumber = 2;
    private global::WUProtos.Networking.Requests.Messages.EncounterFleeMessage.Types.StageOptions stageOptions_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Requests.Messages.EncounterFleeMessage.Types.StageOptions StageOptions {
      get { return stageOptions_; }
      set {
        stageOptions_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EncounterFleeMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EncounterFleeMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EncounterId != other.EncounterId) return false;
      if (StageOptions != other.StageOptions) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EncounterId.Length != 0) hash ^= EncounterId.GetHashCode();
      if (StageOptions != 0) hash ^= StageOptions.GetHashCode();
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
        output.WriteBytes(EncounterId);
      }
      if (StageOptions != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) StageOptions);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EncounterId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(EncounterId);
      }
      if (StageOptions != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) StageOptions);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EncounterFleeMessage other) {
      if (other == null) {
        return;
      }
      if (other.EncounterId.Length != 0) {
        EncounterId = other.EncounterId;
      }
      if (other.StageOptions != 0) {
        StageOptions = other.StageOptions;
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
            EncounterId = input.ReadBytes();
            break;
          }
          case 16: {
            StageOptions = (global::WUProtos.Networking.Requests.Messages.EncounterFleeMessage.Types.StageOptions) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the EncounterFleeMessage message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum StageOptions {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("SWISH")] Swish = 1,
        [pbr::OriginalName("COMBAT")] Combat = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
