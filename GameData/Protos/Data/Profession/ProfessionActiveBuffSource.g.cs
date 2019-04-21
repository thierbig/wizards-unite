// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Profession/ProfessionActiveBuffSource.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Profession {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Profession/ProfessionActiveBuffSource.proto</summary>
  public static partial class ProfessionActiveBuffSourceReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Profession/ProfessionActiveBuffSource.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProfessionActiveBuffSourceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjlXVVByb3Rvcy9EYXRhL1Byb2Zlc3Npb24vUHJvZmVzc2lvbkFjdGl2ZUJ1",
            "ZmZTb3VyY2UucHJvdG8SGFdVUHJvdG9zLkRhdGEuUHJvZmVzc2lvbiJ2ChpQ",
            "cm9mZXNzaW9uQWN0aXZlQnVmZlNvdXJjZRIZChFwcm9mZXNzaW9uX2dtdF9p",
            "ZBgBIAEoCRIeChZwcm9mZXNzaW9uX2dtdF9ub2RlX2lkGAIgASgJEh0KFXBy",
            "b2Zlc3Npb25fbm9kZV9sZXZlbBgDIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Profession.ProfessionActiveBuffSource), global::WUProtos.Data.Profession.ProfessionActiveBuffSource.Parser, new[]{ "ProfessionGmtId", "ProfessionGmtNodeId", "ProfessionNodeLevel" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProfessionActiveBuffSource : pb::IMessage<ProfessionActiveBuffSource> {
    private static readonly pb::MessageParser<ProfessionActiveBuffSource> _parser = new pb::MessageParser<ProfessionActiveBuffSource>(() => new ProfessionActiveBuffSource());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProfessionActiveBuffSource> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Profession.ProfessionActiveBuffSourceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionActiveBuffSource() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionActiveBuffSource(ProfessionActiveBuffSource other) : this() {
      professionGmtId_ = other.professionGmtId_;
      professionGmtNodeId_ = other.professionGmtNodeId_;
      professionNodeLevel_ = other.professionNodeLevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionActiveBuffSource Clone() {
      return new ProfessionActiveBuffSource(this);
    }

    /// <summary>Field number for the "profession_gmt_id" field.</summary>
    public const int ProfessionGmtIdFieldNumber = 1;
    private string professionGmtId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProfessionGmtId {
      get { return professionGmtId_; }
      set {
        professionGmtId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "profession_gmt_node_id" field.</summary>
    public const int ProfessionGmtNodeIdFieldNumber = 2;
    private string professionGmtNodeId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProfessionGmtNodeId {
      get { return professionGmtNodeId_; }
      set {
        professionGmtNodeId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "profession_node_level" field.</summary>
    public const int ProfessionNodeLevelFieldNumber = 3;
    private uint professionNodeLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint ProfessionNodeLevel {
      get { return professionNodeLevel_; }
      set {
        professionNodeLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProfessionActiveBuffSource);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProfessionActiveBuffSource other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProfessionGmtId != other.ProfessionGmtId) return false;
      if (ProfessionGmtNodeId != other.ProfessionGmtNodeId) return false;
      if (ProfessionNodeLevel != other.ProfessionNodeLevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ProfessionGmtId.Length != 0) hash ^= ProfessionGmtId.GetHashCode();
      if (ProfessionGmtNodeId.Length != 0) hash ^= ProfessionGmtNodeId.GetHashCode();
      if (ProfessionNodeLevel != 0) hash ^= ProfessionNodeLevel.GetHashCode();
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
      if (ProfessionGmtId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProfessionGmtId);
      }
      if (ProfessionGmtNodeId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProfessionGmtNodeId);
      }
      if (ProfessionNodeLevel != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ProfessionNodeLevel);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ProfessionGmtId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProfessionGmtId);
      }
      if (ProfessionGmtNodeId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProfessionGmtNodeId);
      }
      if (ProfessionNodeLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ProfessionNodeLevel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProfessionActiveBuffSource other) {
      if (other == null) {
        return;
      }
      if (other.ProfessionGmtId.Length != 0) {
        ProfessionGmtId = other.ProfessionGmtId;
      }
      if (other.ProfessionGmtNodeId.Length != 0) {
        ProfessionGmtNodeId = other.ProfessionGmtNodeId;
      }
      if (other.ProfessionNodeLevel != 0) {
        ProfessionNodeLevel = other.ProfessionNodeLevel;
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
            ProfessionGmtId = input.ReadString();
            break;
          }
          case 18: {
            ProfessionGmtNodeId = input.ReadString();
            break;
          }
          case 24: {
            ProfessionNodeLevel = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
