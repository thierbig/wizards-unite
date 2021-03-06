// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/MasterNote.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/MasterNote.proto</summary>
  public static partial class MasterNoteReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/MasterNote.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MasterNoteReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5XVVByb3Rvcy9EYXRhL01hc3Rlck5vdGUucHJvdG8SDVdVUHJvdG9zLkRh",
            "dGEaJldVUHJvdG9zL0VudW1zL01hc3Rlck5vdGVHZXN0dXJlLnByb3RvGiRX",
            "VVByb3Rvcy9EYXRhL01hc3Rlck5vdGVFZmZlY3QucHJvdG8ifgoKTWFzdGVy",
            "Tm90ZRIKCgJpZBgBIAEoCRIzCghnZXN0dXJlcxgCIAMoDjIhLldVUHJvdG9z",
            "LkVudW1zLk1hc3Rlck5vdGVHZXN0dXJlEi8KBmVmZmVjdBgDIAEoCzIfLldV",
            "UHJvdG9zLkRhdGEuTWFzdGVyTm90ZUVmZmVjdGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Enums.MasterNoteGestureReflection.Descriptor, global::WUProtos.Data.MasterNoteEffectReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.MasterNote), global::WUProtos.Data.MasterNote.Parser, new[]{ "Id", "Gestures", "Effect" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MasterNote : pb::IMessage<MasterNote> {
    private static readonly pb::MessageParser<MasterNote> _parser = new pb::MessageParser<MasterNote>(() => new MasterNote());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MasterNote> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.MasterNoteReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterNote() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterNote(MasterNote other) : this() {
      id_ = other.id_;
      gestures_ = other.gestures_.Clone();
      effect_ = other.effect_ != null ? other.effect_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterNote Clone() {
      return new MasterNote(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "gestures" field.</summary>
    public const int GesturesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::WUProtos.Enums.MasterNoteGesture> _repeated_gestures_codec
        = pb::FieldCodec.ForEnum(18, x => (int) x, x => (global::WUProtos.Enums.MasterNoteGesture) x);
    private readonly pbc::RepeatedField<global::WUProtos.Enums.MasterNoteGesture> gestures_ = new pbc::RepeatedField<global::WUProtos.Enums.MasterNoteGesture>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Enums.MasterNoteGesture> Gestures {
      get { return gestures_; }
    }

    /// <summary>Field number for the "effect" field.</summary>
    public const int EffectFieldNumber = 3;
    private global::WUProtos.Data.MasterNoteEffect effect_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.MasterNoteEffect Effect {
      get { return effect_; }
      set {
        effect_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MasterNote);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MasterNote other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if(!gestures_.Equals(other.gestures_)) return false;
      if (!object.Equals(Effect, other.Effect)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      hash ^= gestures_.GetHashCode();
      if (effect_ != null) hash ^= Effect.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      gestures_.WriteTo(output, _repeated_gestures_codec);
      if (effect_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Effect);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      size += gestures_.CalculateSize(_repeated_gestures_codec);
      if (effect_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Effect);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MasterNote other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      gestures_.Add(other.gestures_);
      if (other.effect_ != null) {
        if (effect_ == null) {
          Effect = new global::WUProtos.Data.MasterNoteEffect();
        }
        Effect.MergeFrom(other.Effect);
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
            Id = input.ReadString();
            break;
          }
          case 18:
          case 16: {
            gestures_.AddEntriesFrom(input, _repeated_gestures_codec);
            break;
          }
          case 26: {
            if (effect_ == null) {
              Effect = new global::WUProtos.Data.MasterNoteEffect();
            }
            input.ReadMessage(Effect);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
