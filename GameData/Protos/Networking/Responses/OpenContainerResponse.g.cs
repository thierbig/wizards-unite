// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/OpenContainerResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/OpenContainerResponse.proto</summary>
  public static partial class OpenContainerResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/OpenContainerResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OpenContainerResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjlXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9PcGVuQ29udGFpbmVy",
            "UmVzcG9uc2UucHJvdG8SHVdVUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2Vz",
            "GidXVVByb3Rvcy9EYXRhL0xvb3QvTG9vdENvbGxlY3Rpb24ucHJvdG8imQEK",
            "FU9wZW5Db250YWluZXJSZXNwb25zZRIUCgxmYW1pbHlfbGV2ZWwYASABKAUS",
            "OAoMY2hlc3RfcmV3YXJkGAIgAygLMiIuV1VQcm90b3MuRGF0YS5Mb290Lkxv",
            "b3RDb2xsZWN0aW9uEhEKCWZhbWlseV94cBgDIAEoBRIdChVjdXJyZW50X2No",
            "ZXN0c19vcGVuZWQYBCABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Loot.LootCollectionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.OpenContainerResponse), global::WUProtos.Networking.Responses.OpenContainerResponse.Parser, new[]{ "FamilyLevel", "ChestReward", "FamilyXp", "CurrentChestsOpened" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OpenContainerResponse : pb::IMessage<OpenContainerResponse> {
    private static readonly pb::MessageParser<OpenContainerResponse> _parser = new pb::MessageParser<OpenContainerResponse>(() => new OpenContainerResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OpenContainerResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.OpenContainerResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OpenContainerResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OpenContainerResponse(OpenContainerResponse other) : this() {
      familyLevel_ = other.familyLevel_;
      chestReward_ = other.chestReward_.Clone();
      familyXp_ = other.familyXp_;
      currentChestsOpened_ = other.currentChestsOpened_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OpenContainerResponse Clone() {
      return new OpenContainerResponse(this);
    }

    /// <summary>Field number for the "family_level" field.</summary>
    public const int FamilyLevelFieldNumber = 1;
    private int familyLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FamilyLevel {
      get { return familyLevel_; }
      set {
        familyLevel_ = value;
      }
    }

    /// <summary>Field number for the "chest_reward" field.</summary>
    public const int ChestRewardFieldNumber = 2;
    private static readonly pb::FieldCodec<global::WUProtos.Data.Loot.LootCollection> _repeated_chestReward_codec
        = pb::FieldCodec.ForMessage(18, global::WUProtos.Data.Loot.LootCollection.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.Loot.LootCollection> chestReward_ = new pbc::RepeatedField<global::WUProtos.Data.Loot.LootCollection>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.Loot.LootCollection> ChestReward {
      get { return chestReward_; }
    }

    /// <summary>Field number for the "family_xp" field.</summary>
    public const int FamilyXpFieldNumber = 3;
    private int familyXp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FamilyXp {
      get { return familyXp_; }
      set {
        familyXp_ = value;
      }
    }

    /// <summary>Field number for the "current_chests_opened" field.</summary>
    public const int CurrentChestsOpenedFieldNumber = 4;
    private int currentChestsOpened_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CurrentChestsOpened {
      get { return currentChestsOpened_; }
      set {
        currentChestsOpened_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OpenContainerResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OpenContainerResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FamilyLevel != other.FamilyLevel) return false;
      if(!chestReward_.Equals(other.chestReward_)) return false;
      if (FamilyXp != other.FamilyXp) return false;
      if (CurrentChestsOpened != other.CurrentChestsOpened) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FamilyLevel != 0) hash ^= FamilyLevel.GetHashCode();
      hash ^= chestReward_.GetHashCode();
      if (FamilyXp != 0) hash ^= FamilyXp.GetHashCode();
      if (CurrentChestsOpened != 0) hash ^= CurrentChestsOpened.GetHashCode();
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
      if (FamilyLevel != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(FamilyLevel);
      }
      chestReward_.WriteTo(output, _repeated_chestReward_codec);
      if (FamilyXp != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(FamilyXp);
      }
      if (CurrentChestsOpened != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(CurrentChestsOpened);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FamilyLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FamilyLevel);
      }
      size += chestReward_.CalculateSize(_repeated_chestReward_codec);
      if (FamilyXp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FamilyXp);
      }
      if (CurrentChestsOpened != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CurrentChestsOpened);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OpenContainerResponse other) {
      if (other == null) {
        return;
      }
      if (other.FamilyLevel != 0) {
        FamilyLevel = other.FamilyLevel;
      }
      chestReward_.Add(other.chestReward_);
      if (other.FamilyXp != 0) {
        FamilyXp = other.FamilyXp;
      }
      if (other.CurrentChestsOpened != 0) {
        CurrentChestsOpened = other.CurrentChestsOpened;
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
            FamilyLevel = input.ReadInt32();
            break;
          }
          case 18: {
            chestReward_.AddEntriesFrom(input, _repeated_chestReward_codec);
            break;
          }
          case 24: {
            FamilyXp = input.ReadInt32();
            break;
          }
          case 32: {
            CurrentChestsOpened = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
