// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/WinTracesQuestProgress.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/WinTracesQuestProgress.proto</summary>
  public static partial class WinTracesQuestProgressReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/WinTracesQuestProgress.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WinTracesQuestProgressReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipXVVByb3Rvcy9EYXRhL1dpblRyYWNlc1F1ZXN0UHJvZ3Jlc3MucHJvdG8S",
            "DVdVUHJvdG9zLkRhdGEiNQoWV2luVHJhY2VzUXVlc3RQcm9ncmVzcxIbChNj",
            "dXJyZW50X3RyYWNlX2NvdW50GAEgASgDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.WinTracesQuestProgress), global::WUProtos.Data.WinTracesQuestProgress.Parser, new[]{ "CurrentTraceCount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WinTracesQuestProgress : pb::IMessage<WinTracesQuestProgress> {
    private static readonly pb::MessageParser<WinTracesQuestProgress> _parser = new pb::MessageParser<WinTracesQuestProgress>(() => new WinTracesQuestProgress());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WinTracesQuestProgress> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.WinTracesQuestProgressReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WinTracesQuestProgress() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WinTracesQuestProgress(WinTracesQuestProgress other) : this() {
      currentTraceCount_ = other.currentTraceCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WinTracesQuestProgress Clone() {
      return new WinTracesQuestProgress(this);
    }

    /// <summary>Field number for the "current_trace_count" field.</summary>
    public const int CurrentTraceCountFieldNumber = 1;
    private long currentTraceCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CurrentTraceCount {
      get { return currentTraceCount_; }
      set {
        currentTraceCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WinTracesQuestProgress);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WinTracesQuestProgress other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurrentTraceCount != other.CurrentTraceCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CurrentTraceCount != 0L) hash ^= CurrentTraceCount.GetHashCode();
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
      if (CurrentTraceCount != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(CurrentTraceCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CurrentTraceCount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CurrentTraceCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WinTracesQuestProgress other) {
      if (other == null) {
        return;
      }
      if (other.CurrentTraceCount != 0L) {
        CurrentTraceCount = other.CurrentTraceCount;
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
            CurrentTraceCount = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
