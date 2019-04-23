// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/LevelUpCollectionFamilyResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/LevelUpCollectionFamilyResponse.proto</summary>
  public static partial class LevelUpCollectionFamilyResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/LevelUpCollectionFamilyResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LevelUpCollectionFamilyResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9MZXZlbFVwQ29sbGVj",
            "dGlvbkZhbWlseVJlc3BvbnNlLnByb3RvEh1XVVByb3Rvcy5OZXR3b3JraW5n",
            "LlJlc3BvbnNlcyJNCh9MZXZlbFVwQ29sbGVjdGlvbkZhbWlseVJlc3BvbnNl",
            "EhQKDGRpZF9sZXZlbF91cBgBIAEoCBIUCgxmYW1pbHlfbGV2ZWwYAiABKAVi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.LevelUpCollectionFamilyResponse), global::WUProtos.Networking.Responses.LevelUpCollectionFamilyResponse.Parser, new[]{ "DidLevelUp", "FamilyLevel" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LevelUpCollectionFamilyResponse : pb::IMessage<LevelUpCollectionFamilyResponse> {
    private static readonly pb::MessageParser<LevelUpCollectionFamilyResponse> _parser = new pb::MessageParser<LevelUpCollectionFamilyResponse>(() => new LevelUpCollectionFamilyResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LevelUpCollectionFamilyResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.LevelUpCollectionFamilyResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LevelUpCollectionFamilyResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LevelUpCollectionFamilyResponse(LevelUpCollectionFamilyResponse other) : this() {
      didLevelUp_ = other.didLevelUp_;
      familyLevel_ = other.familyLevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LevelUpCollectionFamilyResponse Clone() {
      return new LevelUpCollectionFamilyResponse(this);
    }

    /// <summary>Field number for the "did_level_up" field.</summary>
    public const int DidLevelUpFieldNumber = 1;
    private bool didLevelUp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DidLevelUp {
      get { return didLevelUp_; }
      set {
        didLevelUp_ = value;
      }
    }

    /// <summary>Field number for the "family_level" field.</summary>
    public const int FamilyLevelFieldNumber = 2;
    private int familyLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FamilyLevel {
      get { return familyLevel_; }
      set {
        familyLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LevelUpCollectionFamilyResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LevelUpCollectionFamilyResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DidLevelUp != other.DidLevelUp) return false;
      if (FamilyLevel != other.FamilyLevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DidLevelUp != false) hash ^= DidLevelUp.GetHashCode();
      if (FamilyLevel != 0) hash ^= FamilyLevel.GetHashCode();
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
      if (DidLevelUp != false) {
        output.WriteRawTag(8);
        output.WriteBool(DidLevelUp);
      }
      if (FamilyLevel != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(FamilyLevel);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DidLevelUp != false) {
        size += 1 + 1;
      }
      if (FamilyLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FamilyLevel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LevelUpCollectionFamilyResponse other) {
      if (other == null) {
        return;
      }
      if (other.DidLevelUp != false) {
        DidLevelUp = other.DidLevelUp;
      }
      if (other.FamilyLevel != 0) {
        FamilyLevel = other.FamilyLevel;
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
            DidLevelUp = input.ReadBool();
            break;
          }
          case 16: {
            FamilyLevel = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code