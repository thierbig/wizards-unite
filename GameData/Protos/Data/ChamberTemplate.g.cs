// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/ChamberTemplate.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/ChamberTemplate.proto</summary>
  public static partial class ChamberTemplateReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/ChamberTemplate.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChamberTemplateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNXVVByb3Rvcy9EYXRhL0NoYW1iZXJUZW1wbGF0ZS5wcm90bxINV1VQcm90",
            "b3MuRGF0YRogV1VQcm90b3MvRGF0YS9SZXF1aXJlbWVudHMucHJvdG8irwIK",
            "D0NoYW1iZXJUZW1wbGF0ZRIKCgJpZBgBIAEoCRI4ChN1bmxvY2tfcmVxdWly",
            "ZW1lbnRzGAIgASgLMhsuV1VQcm90b3MuRGF0YS5SZXF1aXJlbWVudHMSPAoX",
            "dmlzaWJpbGl0eV9yZXF1aXJlbWVudHMYAyABKAsyGy5XVVByb3Rvcy5EYXRh",
            "LlJlcXVpcmVtZW50cxIbChNtaW5fcnVuZXN0b25lX2xldmVsGAQgASgNEhsK",
            "E21heF9ydW5lc3RvbmVfbGV2ZWwYBSABKA0SEgoKcGxheWVyX2NhcBgGIAEo",
            "DRITCgtkdXJhdGlvbl9tcxgHIAEoAxIYChBrbm9ja291dF90aW1lX21zGAog",
            "ASgDEhsKE2Jhc2VfY2hhbWJlcl9yYXRpbmcYDCABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.RequirementsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.ChamberTemplate), global::WUProtos.Data.ChamberTemplate.Parser, new[]{ "Id", "UnlockRequirements", "VisibilityRequirements", "MinRunestoneLevel", "MaxRunestoneLevel", "PlayerCap", "DurationMs", "KnockoutTimeMs", "BaseChamberRating" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChamberTemplate : pb::IMessage<ChamberTemplate> {
    private static readonly pb::MessageParser<ChamberTemplate> _parser = new pb::MessageParser<ChamberTemplate>(() => new ChamberTemplate());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChamberTemplate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.ChamberTemplateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChamberTemplate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChamberTemplate(ChamberTemplate other) : this() {
      id_ = other.id_;
      unlockRequirements_ = other.unlockRequirements_ != null ? other.unlockRequirements_.Clone() : null;
      visibilityRequirements_ = other.visibilityRequirements_ != null ? other.visibilityRequirements_.Clone() : null;
      minRunestoneLevel_ = other.minRunestoneLevel_;
      maxRunestoneLevel_ = other.maxRunestoneLevel_;
      playerCap_ = other.playerCap_;
      durationMs_ = other.durationMs_;
      knockoutTimeMs_ = other.knockoutTimeMs_;
      baseChamberRating_ = other.baseChamberRating_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChamberTemplate Clone() {
      return new ChamberTemplate(this);
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

    /// <summary>Field number for the "unlock_requirements" field.</summary>
    public const int UnlockRequirementsFieldNumber = 2;
    private global::WUProtos.Data.Requirements unlockRequirements_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Requirements UnlockRequirements {
      get { return unlockRequirements_; }
      set {
        unlockRequirements_ = value;
      }
    }

    /// <summary>Field number for the "visibility_requirements" field.</summary>
    public const int VisibilityRequirementsFieldNumber = 3;
    private global::WUProtos.Data.Requirements visibilityRequirements_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Requirements VisibilityRequirements {
      get { return visibilityRequirements_; }
      set {
        visibilityRequirements_ = value;
      }
    }

    /// <summary>Field number for the "min_runestone_level" field.</summary>
    public const int MinRunestoneLevelFieldNumber = 4;
    private uint minRunestoneLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint MinRunestoneLevel {
      get { return minRunestoneLevel_; }
      set {
        minRunestoneLevel_ = value;
      }
    }

    /// <summary>Field number for the "max_runestone_level" field.</summary>
    public const int MaxRunestoneLevelFieldNumber = 5;
    private uint maxRunestoneLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint MaxRunestoneLevel {
      get { return maxRunestoneLevel_; }
      set {
        maxRunestoneLevel_ = value;
      }
    }

    /// <summary>Field number for the "player_cap" field.</summary>
    public const int PlayerCapFieldNumber = 6;
    private uint playerCap_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint PlayerCap {
      get { return playerCap_; }
      set {
        playerCap_ = value;
      }
    }

    /// <summary>Field number for the "duration_ms" field.</summary>
    public const int DurationMsFieldNumber = 7;
    private long durationMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long DurationMs {
      get { return durationMs_; }
      set {
        durationMs_ = value;
      }
    }

    /// <summary>Field number for the "knockout_time_ms" field.</summary>
    public const int KnockoutTimeMsFieldNumber = 10;
    private long knockoutTimeMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long KnockoutTimeMs {
      get { return knockoutTimeMs_; }
      set {
        knockoutTimeMs_ = value;
      }
    }

    /// <summary>Field number for the "base_chamber_rating" field.</summary>
    public const int BaseChamberRatingFieldNumber = 12;
    private uint baseChamberRating_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint BaseChamberRating {
      get { return baseChamberRating_; }
      set {
        baseChamberRating_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChamberTemplate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChamberTemplate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(UnlockRequirements, other.UnlockRequirements)) return false;
      if (!object.Equals(VisibilityRequirements, other.VisibilityRequirements)) return false;
      if (MinRunestoneLevel != other.MinRunestoneLevel) return false;
      if (MaxRunestoneLevel != other.MaxRunestoneLevel) return false;
      if (PlayerCap != other.PlayerCap) return false;
      if (DurationMs != other.DurationMs) return false;
      if (KnockoutTimeMs != other.KnockoutTimeMs) return false;
      if (BaseChamberRating != other.BaseChamberRating) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (unlockRequirements_ != null) hash ^= UnlockRequirements.GetHashCode();
      if (visibilityRequirements_ != null) hash ^= VisibilityRequirements.GetHashCode();
      if (MinRunestoneLevel != 0) hash ^= MinRunestoneLevel.GetHashCode();
      if (MaxRunestoneLevel != 0) hash ^= MaxRunestoneLevel.GetHashCode();
      if (PlayerCap != 0) hash ^= PlayerCap.GetHashCode();
      if (DurationMs != 0L) hash ^= DurationMs.GetHashCode();
      if (KnockoutTimeMs != 0L) hash ^= KnockoutTimeMs.GetHashCode();
      if (BaseChamberRating != 0) hash ^= BaseChamberRating.GetHashCode();
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
      if (unlockRequirements_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UnlockRequirements);
      }
      if (visibilityRequirements_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(VisibilityRequirements);
      }
      if (MinRunestoneLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MinRunestoneLevel);
      }
      if (MaxRunestoneLevel != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MaxRunestoneLevel);
      }
      if (PlayerCap != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PlayerCap);
      }
      if (DurationMs != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(DurationMs);
      }
      if (KnockoutTimeMs != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(KnockoutTimeMs);
      }
      if (BaseChamberRating != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BaseChamberRating);
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
      if (unlockRequirements_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UnlockRequirements);
      }
      if (visibilityRequirements_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VisibilityRequirements);
      }
      if (MinRunestoneLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MinRunestoneLevel);
      }
      if (MaxRunestoneLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxRunestoneLevel);
      }
      if (PlayerCap != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayerCap);
      }
      if (DurationMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(DurationMs);
      }
      if (KnockoutTimeMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(KnockoutTimeMs);
      }
      if (BaseChamberRating != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BaseChamberRating);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChamberTemplate other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.unlockRequirements_ != null) {
        if (unlockRequirements_ == null) {
          UnlockRequirements = new global::WUProtos.Data.Requirements();
        }
        UnlockRequirements.MergeFrom(other.UnlockRequirements);
      }
      if (other.visibilityRequirements_ != null) {
        if (visibilityRequirements_ == null) {
          VisibilityRequirements = new global::WUProtos.Data.Requirements();
        }
        VisibilityRequirements.MergeFrom(other.VisibilityRequirements);
      }
      if (other.MinRunestoneLevel != 0) {
        MinRunestoneLevel = other.MinRunestoneLevel;
      }
      if (other.MaxRunestoneLevel != 0) {
        MaxRunestoneLevel = other.MaxRunestoneLevel;
      }
      if (other.PlayerCap != 0) {
        PlayerCap = other.PlayerCap;
      }
      if (other.DurationMs != 0L) {
        DurationMs = other.DurationMs;
      }
      if (other.KnockoutTimeMs != 0L) {
        KnockoutTimeMs = other.KnockoutTimeMs;
      }
      if (other.BaseChamberRating != 0) {
        BaseChamberRating = other.BaseChamberRating;
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
          case 18: {
            if (unlockRequirements_ == null) {
              UnlockRequirements = new global::WUProtos.Data.Requirements();
            }
            input.ReadMessage(UnlockRequirements);
            break;
          }
          case 26: {
            if (visibilityRequirements_ == null) {
              VisibilityRequirements = new global::WUProtos.Data.Requirements();
            }
            input.ReadMessage(VisibilityRequirements);
            break;
          }
          case 32: {
            MinRunestoneLevel = input.ReadUInt32();
            break;
          }
          case 40: {
            MaxRunestoneLevel = input.ReadUInt32();
            break;
          }
          case 48: {
            PlayerCap = input.ReadUInt32();
            break;
          }
          case 56: {
            DurationMs = input.ReadInt64();
            break;
          }
          case 80: {
            KnockoutTimeMs = input.ReadInt64();
            break;
          }
          case 96: {
            BaseChamberRating = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
