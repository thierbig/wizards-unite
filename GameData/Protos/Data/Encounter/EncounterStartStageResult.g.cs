// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Encounter/EncounterStartStageResult.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Encounter {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Encounter/EncounterStartStageResult.proto</summary>
  public static partial class EncounterStartStageResultReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Encounter/EncounterStartStageResult.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EncounterStartStageResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjdXVVByb3Rvcy9EYXRhL0VuY291bnRlci9FbmNvdW50ZXJTdGFydFN0YWdl",
            "UmVzdWx0LnByb3RvEhdXVVByb3Rvcy5EYXRhLkVuY291bnRlcho8V1VQcm90",
            "b3MvRGF0YS9FbmNvdW50ZXIvRW5jb3VudGVyU3RhcnRTd2lzaFN0YWdlUmVz",
            "dWx0LnByb3RvGj1XVVByb3Rvcy9EYXRhL0VuY291bnRlci9FbmNvdW50ZXJT",
            "dGFydENvbWJhdFN0YWdlUmVzdWx0LnByb3RvGj5XVVByb3Rvcy9EYXRhL0Vu",
            "Y291bnRlci9FbmNvdW50ZXJTdGFydFBvcnRrZXlTdGFnZVJlc3VsdC5wcm90",
            "byKHAgoZRW5jb3VudGVyU3RhcnRTdGFnZVJlc3VsdBJICgVzd2lzaBgBIAEo",
            "CzI3LldVUHJvdG9zLkRhdGEuRW5jb3VudGVyLkVuY291bnRlclN0YXJ0U3dp",
            "c2hTdGFnZVJlc3VsdEgAEkoKBmNvbWJhdBgCIAEoCzI4LldVUHJvdG9zLkRh",
            "dGEuRW5jb3VudGVyLkVuY291bnRlclN0YXJ0Q29tYmF0U3RhZ2VSZXN1bHRI",
            "ABJMCgdwb3J0a2V5GAMgASgLMjkuV1VQcm90b3MuRGF0YS5FbmNvdW50ZXIu",
            "RW5jb3VudGVyU3RhcnRQb3J0a2V5U3RhZ2VSZXN1bHRIAEIGCgRUeXBlYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Encounter.EncounterStartSwishStageResultReflection.Descriptor, global::WUProtos.Data.Encounter.EncounterStartCombatStageResultReflection.Descriptor, global::WUProtos.Data.Encounter.EncounterStartPortkeyStageResultReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Encounter.EncounterStartStageResult), global::WUProtos.Data.Encounter.EncounterStartStageResult.Parser, new[]{ "Swish", "Combat", "Portkey" }, new[]{ "Type" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EncounterStartStageResult : pb::IMessage<EncounterStartStageResult> {
    private static readonly pb::MessageParser<EncounterStartStageResult> _parser = new pb::MessageParser<EncounterStartStageResult>(() => new EncounterStartStageResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EncounterStartStageResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Encounter.EncounterStartStageResultReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterStartStageResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterStartStageResult(EncounterStartStageResult other) : this() {
      switch (other.TypeCase) {
        case TypeOneofCase.Swish:
          Swish = other.Swish.Clone();
          break;
        case TypeOneofCase.Combat:
          Combat = other.Combat.Clone();
          break;
        case TypeOneofCase.Portkey:
          Portkey = other.Portkey.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterStartStageResult Clone() {
      return new EncounterStartStageResult(this);
    }

    /// <summary>Field number for the "swish" field.</summary>
    public const int SwishFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Encounter.EncounterStartSwishStageResult Swish {
      get { return typeCase_ == TypeOneofCase.Swish ? (global::WUProtos.Data.Encounter.EncounterStartSwishStageResult) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.Swish;
      }
    }

    /// <summary>Field number for the "combat" field.</summary>
    public const int CombatFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Encounter.EncounterStartCombatStageResult Combat {
      get { return typeCase_ == TypeOneofCase.Combat ? (global::WUProtos.Data.Encounter.EncounterStartCombatStageResult) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.Combat;
      }
    }

    /// <summary>Field number for the "portkey" field.</summary>
    public const int PortkeyFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Encounter.EncounterStartPortkeyStageResult Portkey {
      get { return typeCase_ == TypeOneofCase.Portkey ? (global::WUProtos.Data.Encounter.EncounterStartPortkeyStageResult) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.Portkey;
      }
    }

    private object type_;
    /// <summary>Enum of possible cases for the "Type" oneof.</summary>
    public enum TypeOneofCase {
      None = 0,
      Swish = 1,
      Combat = 2,
      Portkey = 3,
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
      return Equals(other as EncounterStartStageResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EncounterStartStageResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Swish, other.Swish)) return false;
      if (!object.Equals(Combat, other.Combat)) return false;
      if (!object.Equals(Portkey, other.Portkey)) return false;
      if (TypeCase != other.TypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (typeCase_ == TypeOneofCase.Swish) hash ^= Swish.GetHashCode();
      if (typeCase_ == TypeOneofCase.Combat) hash ^= Combat.GetHashCode();
      if (typeCase_ == TypeOneofCase.Portkey) hash ^= Portkey.GetHashCode();
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
      if (typeCase_ == TypeOneofCase.Swish) {
        output.WriteRawTag(10);
        output.WriteMessage(Swish);
      }
      if (typeCase_ == TypeOneofCase.Combat) {
        output.WriteRawTag(18);
        output.WriteMessage(Combat);
      }
      if (typeCase_ == TypeOneofCase.Portkey) {
        output.WriteRawTag(26);
        output.WriteMessage(Portkey);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (typeCase_ == TypeOneofCase.Swish) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Swish);
      }
      if (typeCase_ == TypeOneofCase.Combat) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Combat);
      }
      if (typeCase_ == TypeOneofCase.Portkey) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Portkey);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EncounterStartStageResult other) {
      if (other == null) {
        return;
      }
      switch (other.TypeCase) {
        case TypeOneofCase.Swish:
          if (Swish == null) {
            Swish = new global::WUProtos.Data.Encounter.EncounterStartSwishStageResult();
          }
          Swish.MergeFrom(other.Swish);
          break;
        case TypeOneofCase.Combat:
          if (Combat == null) {
            Combat = new global::WUProtos.Data.Encounter.EncounterStartCombatStageResult();
          }
          Combat.MergeFrom(other.Combat);
          break;
        case TypeOneofCase.Portkey:
          if (Portkey == null) {
            Portkey = new global::WUProtos.Data.Encounter.EncounterStartPortkeyStageResult();
          }
          Portkey.MergeFrom(other.Portkey);
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
            global::WUProtos.Data.Encounter.EncounterStartSwishStageResult subBuilder = new global::WUProtos.Data.Encounter.EncounterStartSwishStageResult();
            if (typeCase_ == TypeOneofCase.Swish) {
              subBuilder.MergeFrom(Swish);
            }
            input.ReadMessage(subBuilder);
            Swish = subBuilder;
            break;
          }
          case 18: {
            global::WUProtos.Data.Encounter.EncounterStartCombatStageResult subBuilder = new global::WUProtos.Data.Encounter.EncounterStartCombatStageResult();
            if (typeCase_ == TypeOneofCase.Combat) {
              subBuilder.MergeFrom(Combat);
            }
            input.ReadMessage(subBuilder);
            Combat = subBuilder;
            break;
          }
          case 26: {
            global::WUProtos.Data.Encounter.EncounterStartPortkeyStageResult subBuilder = new global::WUProtos.Data.Encounter.EncounterStartPortkeyStageResult();
            if (typeCase_ == TypeOneofCase.Portkey) {
              subBuilder.MergeFrom(Portkey);
            }
            input.ReadMessage(subBuilder);
            Portkey = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
