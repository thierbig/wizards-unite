// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientEncounterStageSwish.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientEncounterStageSwish.proto</summary>
  public static partial class ClientEncounterStageSwishReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientEncounterStageSwish.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientEncounterStageSwishReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRFbmNvdW50ZXJTdGFnZVN3",
            "aXNoLnByb3RvEhRXVVByb3Rvcy5EYXRhLkNsaWVudBoiV1VQcm90b3MvRGF0",
            "YS9BdWRpb1BhcmFtZXRlci5wcm90byKWAQoZQ2xpZW50RW5jb3VudGVyU3Rh",
            "Z2VTd2lzaBI9ChZ0cmFjZV9zdWNjZWVkc19mYW5mYXJlGAEgASgLMh0uV1VQ",
            "cm90b3MuRGF0YS5BdWRpb1BhcmFtZXRlchI6ChN0cmFjZV9mYWlsc19mYW5m",
            "YXJlGAIgASgLMh0uV1VQcm90b3MuRGF0YS5BdWRpb1BhcmFtZXRlcmIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.AudioParameterReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientEncounterStageSwish), global::WUProtos.Data.Client.ClientEncounterStageSwish.Parser, new[]{ "TraceSucceedsFanfare", "TraceFailsFanfare" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientEncounterStageSwish : pb::IMessage<ClientEncounterStageSwish> {
    private static readonly pb::MessageParser<ClientEncounterStageSwish> _parser = new pb::MessageParser<ClientEncounterStageSwish>(() => new ClientEncounterStageSwish());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientEncounterStageSwish> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientEncounterStageSwishReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientEncounterStageSwish() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientEncounterStageSwish(ClientEncounterStageSwish other) : this() {
      traceSucceedsFanfare_ = other.traceSucceedsFanfare_ != null ? other.traceSucceedsFanfare_.Clone() : null;
      traceFailsFanfare_ = other.traceFailsFanfare_ != null ? other.traceFailsFanfare_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientEncounterStageSwish Clone() {
      return new ClientEncounterStageSwish(this);
    }

    /// <summary>Field number for the "trace_succeeds_fanfare" field.</summary>
    public const int TraceSucceedsFanfareFieldNumber = 1;
    private global::WUProtos.Data.AudioParameter traceSucceedsFanfare_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.AudioParameter TraceSucceedsFanfare {
      get { return traceSucceedsFanfare_; }
      set {
        traceSucceedsFanfare_ = value;
      }
    }

    /// <summary>Field number for the "trace_fails_fanfare" field.</summary>
    public const int TraceFailsFanfareFieldNumber = 2;
    private global::WUProtos.Data.AudioParameter traceFailsFanfare_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.AudioParameter TraceFailsFanfare {
      get { return traceFailsFanfare_; }
      set {
        traceFailsFanfare_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientEncounterStageSwish);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientEncounterStageSwish other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TraceSucceedsFanfare, other.TraceSucceedsFanfare)) return false;
      if (!object.Equals(TraceFailsFanfare, other.TraceFailsFanfare)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (traceSucceedsFanfare_ != null) hash ^= TraceSucceedsFanfare.GetHashCode();
      if (traceFailsFanfare_ != null) hash ^= TraceFailsFanfare.GetHashCode();
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
      if (traceSucceedsFanfare_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TraceSucceedsFanfare);
      }
      if (traceFailsFanfare_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TraceFailsFanfare);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (traceSucceedsFanfare_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TraceSucceedsFanfare);
      }
      if (traceFailsFanfare_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TraceFailsFanfare);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientEncounterStageSwish other) {
      if (other == null) {
        return;
      }
      if (other.traceSucceedsFanfare_ != null) {
        if (traceSucceedsFanfare_ == null) {
          TraceSucceedsFanfare = new global::WUProtos.Data.AudioParameter();
        }
        TraceSucceedsFanfare.MergeFrom(other.TraceSucceedsFanfare);
      }
      if (other.traceFailsFanfare_ != null) {
        if (traceFailsFanfare_ == null) {
          TraceFailsFanfare = new global::WUProtos.Data.AudioParameter();
        }
        TraceFailsFanfare.MergeFrom(other.TraceFailsFanfare);
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
            if (traceSucceedsFanfare_ == null) {
              TraceSucceedsFanfare = new global::WUProtos.Data.AudioParameter();
            }
            input.ReadMessage(TraceSucceedsFanfare);
            break;
          }
          case 18: {
            if (traceFailsFanfare_ == null) {
              TraceFailsFanfare = new global::WUProtos.Data.AudioParameter();
            }
            input.ReadMessage(TraceFailsFanfare);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
