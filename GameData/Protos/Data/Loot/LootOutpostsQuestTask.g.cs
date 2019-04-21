// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Loot/LootOutpostsQuestTask.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Loot {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Loot/LootOutpostsQuestTask.proto</summary>
  public static partial class LootOutpostsQuestTaskReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Loot/LootOutpostsQuestTask.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LootOutpostsQuestTaskReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5XVVByb3Rvcy9EYXRhL0xvb3QvTG9vdE91dHBvc3RzUXVlc3RUYXNrLnBy",
            "b3RvEhJXVVByb3Rvcy5EYXRhLkxvb3QiOAoVTG9vdE91dHBvc3RzUXVlc3RU",
            "YXNrEh8KF3JlcXVpcmVkX291dHBvc3RzX2NvdW50GAEgASgDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Loot.LootOutpostsQuestTask), global::WUProtos.Data.Loot.LootOutpostsQuestTask.Parser, new[]{ "RequiredOutpostsCount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LootOutpostsQuestTask : pb::IMessage<LootOutpostsQuestTask> {
    private static readonly pb::MessageParser<LootOutpostsQuestTask> _parser = new pb::MessageParser<LootOutpostsQuestTask>(() => new LootOutpostsQuestTask());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LootOutpostsQuestTask> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Loot.LootOutpostsQuestTaskReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LootOutpostsQuestTask() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LootOutpostsQuestTask(LootOutpostsQuestTask other) : this() {
      requiredOutpostsCount_ = other.requiredOutpostsCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LootOutpostsQuestTask Clone() {
      return new LootOutpostsQuestTask(this);
    }

    /// <summary>Field number for the "required_outposts_count" field.</summary>
    public const int RequiredOutpostsCountFieldNumber = 1;
    private long requiredOutpostsCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RequiredOutpostsCount {
      get { return requiredOutpostsCount_; }
      set {
        requiredOutpostsCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LootOutpostsQuestTask);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LootOutpostsQuestTask other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RequiredOutpostsCount != other.RequiredOutpostsCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RequiredOutpostsCount != 0L) hash ^= RequiredOutpostsCount.GetHashCode();
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
      if (RequiredOutpostsCount != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(RequiredOutpostsCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RequiredOutpostsCount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RequiredOutpostsCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LootOutpostsQuestTask other) {
      if (other == null) {
        return;
      }
      if (other.RequiredOutpostsCount != 0L) {
        RequiredOutpostsCount = other.RequiredOutpostsCount;
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
            RequiredOutpostsCount = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
