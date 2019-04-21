// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Loot/LootOutpostsQuestProgress.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Loot {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Loot/LootOutpostsQuestProgress.proto</summary>
  public static partial class LootOutpostsQuestProgressReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Loot/LootOutpostsQuestProgress.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LootOutpostsQuestProgressReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJXVVByb3Rvcy9EYXRhL0xvb3QvTG9vdE91dHBvc3RzUXVlc3RQcm9ncmVz",
            "cy5wcm90bxISV1VQcm90b3MuRGF0YS5Mb290IjoKGUxvb3RPdXRwb3N0c1F1",
            "ZXN0UHJvZ3Jlc3MSHQoVY3VycmVudF9vdXRwb3N0X2NvdW50GAEgASgDYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Loot.LootOutpostsQuestProgress), global::WUProtos.Data.Loot.LootOutpostsQuestProgress.Parser, new[]{ "CurrentOutpostCount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LootOutpostsQuestProgress : pb::IMessage<LootOutpostsQuestProgress> {
    private static readonly pb::MessageParser<LootOutpostsQuestProgress> _parser = new pb::MessageParser<LootOutpostsQuestProgress>(() => new LootOutpostsQuestProgress());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LootOutpostsQuestProgress> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Loot.LootOutpostsQuestProgressReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LootOutpostsQuestProgress() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LootOutpostsQuestProgress(LootOutpostsQuestProgress other) : this() {
      currentOutpostCount_ = other.currentOutpostCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LootOutpostsQuestProgress Clone() {
      return new LootOutpostsQuestProgress(this);
    }

    /// <summary>Field number for the "current_outpost_count" field.</summary>
    public const int CurrentOutpostCountFieldNumber = 1;
    private long currentOutpostCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CurrentOutpostCount {
      get { return currentOutpostCount_; }
      set {
        currentOutpostCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LootOutpostsQuestProgress);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LootOutpostsQuestProgress other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurrentOutpostCount != other.CurrentOutpostCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CurrentOutpostCount != 0L) hash ^= CurrentOutpostCount.GetHashCode();
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
      if (CurrentOutpostCount != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(CurrentOutpostCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CurrentOutpostCount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CurrentOutpostCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LootOutpostsQuestProgress other) {
      if (other == null) {
        return;
      }
      if (other.CurrentOutpostCount != 0L) {
        CurrentOutpostCount = other.CurrentOutpostCount;
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
            CurrentOutpostCount = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
