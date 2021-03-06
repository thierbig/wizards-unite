// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/QuestProgress.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/QuestProgress.proto</summary>
  public static partial class QuestProgressReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/QuestProgress.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuestProgressReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFXVVByb3Rvcy9EYXRhL1F1ZXN0UHJvZ3Jlc3MucHJvdG8SDVdVUHJvdG9z",
            "LkRhdGEaLVdVUHJvdG9zL0RhdGEvUmVxdWlyZW1lbnRzUXVlc3RQcm9ncmVz",
            "cy5wcm90bxolV1VQcm90b3MvRGF0YS9Ib29rUXVlc3RQcm9ncmVzcy5wcm90",
            "byKUAQoNUXVlc3RQcm9ncmVzcxJACgxyZXFfcHJvZ3Jlc3MYASABKAsyKC5X",
            "VVByb3Rvcy5EYXRhLlJlcXVpcmVtZW50c1F1ZXN0UHJvZ3Jlc3NIABI5Cg1o",
            "b29rX3Byb2dyZXNzGAIgASgLMiAuV1VQcm90b3MuRGF0YS5Ib29rUXVlc3RQ",
            "cm9ncmVzc0gAQgYKBFR5cGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.RequirementsQuestProgressReflection.Descriptor, global::WUProtos.Data.HookQuestProgressReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.QuestProgress), global::WUProtos.Data.QuestProgress.Parser, new[]{ "ReqProgress", "HookProgress" }, new[]{ "Type" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class QuestProgress : pb::IMessage<QuestProgress> {
    private static readonly pb::MessageParser<QuestProgress> _parser = new pb::MessageParser<QuestProgress>(() => new QuestProgress());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QuestProgress> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.QuestProgressReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuestProgress() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuestProgress(QuestProgress other) : this() {
      switch (other.TypeCase) {
        case TypeOneofCase.ReqProgress:
          ReqProgress = other.ReqProgress.Clone();
          break;
        case TypeOneofCase.HookProgress:
          HookProgress = other.HookProgress.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuestProgress Clone() {
      return new QuestProgress(this);
    }

    /// <summary>Field number for the "req_progress" field.</summary>
    public const int ReqProgressFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.RequirementsQuestProgress ReqProgress {
      get { return typeCase_ == TypeOneofCase.ReqProgress ? (global::WUProtos.Data.RequirementsQuestProgress) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.ReqProgress;
      }
    }

    /// <summary>Field number for the "hook_progress" field.</summary>
    public const int HookProgressFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.HookQuestProgress HookProgress {
      get { return typeCase_ == TypeOneofCase.HookProgress ? (global::WUProtos.Data.HookQuestProgress) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.HookProgress;
      }
    }

    private object type_;
    /// <summary>Enum of possible cases for the "Type" oneof.</summary>
    public enum TypeOneofCase {
      None = 0,
      ReqProgress = 1,
      HookProgress = 2,
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
      return Equals(other as QuestProgress);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QuestProgress other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ReqProgress, other.ReqProgress)) return false;
      if (!object.Equals(HookProgress, other.HookProgress)) return false;
      if (TypeCase != other.TypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (typeCase_ == TypeOneofCase.ReqProgress) hash ^= ReqProgress.GetHashCode();
      if (typeCase_ == TypeOneofCase.HookProgress) hash ^= HookProgress.GetHashCode();
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
      if (typeCase_ == TypeOneofCase.ReqProgress) {
        output.WriteRawTag(10);
        output.WriteMessage(ReqProgress);
      }
      if (typeCase_ == TypeOneofCase.HookProgress) {
        output.WriteRawTag(18);
        output.WriteMessage(HookProgress);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (typeCase_ == TypeOneofCase.ReqProgress) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReqProgress);
      }
      if (typeCase_ == TypeOneofCase.HookProgress) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HookProgress);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QuestProgress other) {
      if (other == null) {
        return;
      }
      switch (other.TypeCase) {
        case TypeOneofCase.ReqProgress:
          if (ReqProgress == null) {
            ReqProgress = new global::WUProtos.Data.RequirementsQuestProgress();
          }
          ReqProgress.MergeFrom(other.ReqProgress);
          break;
        case TypeOneofCase.HookProgress:
          if (HookProgress == null) {
            HookProgress = new global::WUProtos.Data.HookQuestProgress();
          }
          HookProgress.MergeFrom(other.HookProgress);
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
            global::WUProtos.Data.RequirementsQuestProgress subBuilder = new global::WUProtos.Data.RequirementsQuestProgress();
            if (typeCase_ == TypeOneofCase.ReqProgress) {
              subBuilder.MergeFrom(ReqProgress);
            }
            input.ReadMessage(subBuilder);
            ReqProgress = subBuilder;
            break;
          }
          case 18: {
            global::WUProtos.Data.HookQuestProgress subBuilder = new global::WUProtos.Data.HookQuestProgress();
            if (typeCase_ == TypeOneofCase.HookProgress) {
              subBuilder.MergeFrom(HookProgress);
            }
            input.ReadMessage(subBuilder);
            HookProgress = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
