// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientEncounterStage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientEncounterStage.proto</summary>
  public static partial class ClientEncounterStageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientEncounterStage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientEncounterStageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9XVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRFbmNvdW50ZXJTdGFnZS5w",
            "cm90bxIUV1VQcm90b3MuRGF0YS5DbGllbnQaNFdVUHJvdG9zL0RhdGEvQ2xp",
            "ZW50L0NsaWVudEVuY291bnRlclN0YWdlU3dpc2gucHJvdG8aNVdVUHJvdG9z",
            "L0RhdGEvQ2xpZW50L0NsaWVudEVuY291bnRlclN0YWdlQ29tYmF0LnByb3Rv",
            "GjZXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRFbmNvdW50ZXJTdGFnZVBv",
            "cnRrZXkucHJvdG8aNldVUHJvdG9zL0RhdGEvQ2xpZW50L0NsaWVudEVuY291",
            "bnRlclN0YWdlUGljdHVyZS5wcm90bxotV1VQcm90b3MvRGF0YS9DbGllbnQv",
            "Q2xpZW50U2VxdWVuY2VEYXRhLnByb3RvIpoFChRDbGllbnRFbmNvdW50ZXJT",
            "dGFnZRJACgVzd2lzaBgBIAEoCzIvLldVUHJvdG9zLkRhdGEuQ2xpZW50LkNs",
            "aWVudEVuY291bnRlclN0YWdlU3dpc2hIABJCCgZjb21iYXQYAiABKAsyMC5X",
            "VVByb3Rvcy5EYXRhLkNsaWVudC5DbGllbnRFbmNvdW50ZXJTdGFnZUNvbWJh",
            "dEgAEkQKB3BvcnRrZXkYAyABKAsyMS5XVVByb3Rvcy5EYXRhLkNsaWVudC5D",
            "bGllbnRFbmNvdW50ZXJTdGFnZVBvcnRrZXlIABJECgdwaWN0dXJlGAQgASgL",
            "MjEuV1VQcm90b3MuRGF0YS5DbGllbnQuQ2xpZW50RW5jb3VudGVyU3RhZ2VQ",
            "aWN0dXJlSAASFwoPZGlzYXBwZWFyX2RlbGF5GAUgASgCEhIKCmludHJvX3Rl",
            "eHQYBiABKAkSRgoUc3RhZ2Vfc2V0dXBfc2VxdWVuY2UYByADKAsyKC5XVVBy",
            "b3Rvcy5EYXRhLkNsaWVudC5DbGllbnRTZXF1ZW5jZURhdGESSwoZc3RhZ2Vf",
            "Y29tcGxldGlvbl9zZXF1ZW5jZRgIIAMoCzIoLldVUHJvdG9zLkRhdGEuQ2xp",
            "ZW50LkNsaWVudFNlcXVlbmNlRGF0YRIYChBzcGVsbF9haW1fbGF5b3V0GAkg",
            "ASgJEhsKE2lkbGVfbG9vcF90aW1lbGluZXMYCiADKAkSGgoScm5nX2ludHJv",
            "X3RpbWVsaW5lGAsgASgJEhkKEXJuZ19sb29wX3RpbWVsaW5lGAwgASgJEh0K",
            "FXNwZWxsX2ZhaWxlZF90aW1lbGluZRgNIAEoCRIZChFjb21iYXRfc3BlbGxf",
            "bGlzdBgOIAMoCUIGCgRUeXBlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Client.ClientEncounterStageSwishReflection.Descriptor, global::WUProtos.Data.Client.ClientEncounterStageCombatReflection.Descriptor, global::WUProtos.Data.Client.ClientEncounterStagePortkeyReflection.Descriptor, global::WUProtos.Data.Client.ClientEncounterStagePictureReflection.Descriptor, global::WUProtos.Data.Client.ClientSequenceDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientEncounterStage), global::WUProtos.Data.Client.ClientEncounterStage.Parser, new[]{ "Swish", "Combat", "Portkey", "Picture", "DisappearDelay", "IntroText", "StageSetupSequence", "StageCompletionSequence", "SpellAimLayout", "IdleLoopTimelines", "RngIntroTimeline", "RngLoopTimeline", "SpellFailedTimeline", "CombatSpellList" }, new[]{ "Type" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientEncounterStage : pb::IMessage<ClientEncounterStage> {
    private static readonly pb::MessageParser<ClientEncounterStage> _parser = new pb::MessageParser<ClientEncounterStage>(() => new ClientEncounterStage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientEncounterStage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientEncounterStageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientEncounterStage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientEncounterStage(ClientEncounterStage other) : this() {
      disappearDelay_ = other.disappearDelay_;
      introText_ = other.introText_;
      stageSetupSequence_ = other.stageSetupSequence_.Clone();
      stageCompletionSequence_ = other.stageCompletionSequence_.Clone();
      spellAimLayout_ = other.spellAimLayout_;
      idleLoopTimelines_ = other.idleLoopTimelines_.Clone();
      rngIntroTimeline_ = other.rngIntroTimeline_;
      rngLoopTimeline_ = other.rngLoopTimeline_;
      spellFailedTimeline_ = other.spellFailedTimeline_;
      combatSpellList_ = other.combatSpellList_.Clone();
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
        case TypeOneofCase.Picture:
          Picture = other.Picture.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientEncounterStage Clone() {
      return new ClientEncounterStage(this);
    }

    /// <summary>Field number for the "swish" field.</summary>
    public const int SwishFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Client.ClientEncounterStageSwish Swish {
      get { return typeCase_ == TypeOneofCase.Swish ? (global::WUProtos.Data.Client.ClientEncounterStageSwish) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.Swish;
      }
    }

    /// <summary>Field number for the "combat" field.</summary>
    public const int CombatFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Client.ClientEncounterStageCombat Combat {
      get { return typeCase_ == TypeOneofCase.Combat ? (global::WUProtos.Data.Client.ClientEncounterStageCombat) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.Combat;
      }
    }

    /// <summary>Field number for the "portkey" field.</summary>
    public const int PortkeyFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Client.ClientEncounterStagePortkey Portkey {
      get { return typeCase_ == TypeOneofCase.Portkey ? (global::WUProtos.Data.Client.ClientEncounterStagePortkey) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.Portkey;
      }
    }

    /// <summary>Field number for the "picture" field.</summary>
    public const int PictureFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Client.ClientEncounterStagePicture Picture {
      get { return typeCase_ == TypeOneofCase.Picture ? (global::WUProtos.Data.Client.ClientEncounterStagePicture) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.Picture;
      }
    }

    /// <summary>Field number for the "disappear_delay" field.</summary>
    public const int DisappearDelayFieldNumber = 5;
    private float disappearDelay_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float DisappearDelay {
      get { return disappearDelay_; }
      set {
        disappearDelay_ = value;
      }
    }

    /// <summary>Field number for the "intro_text" field.</summary>
    public const int IntroTextFieldNumber = 6;
    private string introText_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string IntroText {
      get { return introText_; }
      set {
        introText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stage_setup_sequence" field.</summary>
    public const int StageSetupSequenceFieldNumber = 7;
    private static readonly pb::FieldCodec<global::WUProtos.Data.Client.ClientSequenceData> _repeated_stageSetupSequence_codec
        = pb::FieldCodec.ForMessage(58, global::WUProtos.Data.Client.ClientSequenceData.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.Client.ClientSequenceData> stageSetupSequence_ = new pbc::RepeatedField<global::WUProtos.Data.Client.ClientSequenceData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.Client.ClientSequenceData> StageSetupSequence {
      get { return stageSetupSequence_; }
    }

    /// <summary>Field number for the "stage_completion_sequence" field.</summary>
    public const int StageCompletionSequenceFieldNumber = 8;
    private static readonly pb::FieldCodec<global::WUProtos.Data.Client.ClientSequenceData> _repeated_stageCompletionSequence_codec
        = pb::FieldCodec.ForMessage(66, global::WUProtos.Data.Client.ClientSequenceData.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.Client.ClientSequenceData> stageCompletionSequence_ = new pbc::RepeatedField<global::WUProtos.Data.Client.ClientSequenceData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.Client.ClientSequenceData> StageCompletionSequence {
      get { return stageCompletionSequence_; }
    }

    /// <summary>Field number for the "spell_aim_layout" field.</summary>
    public const int SpellAimLayoutFieldNumber = 9;
    private string spellAimLayout_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SpellAimLayout {
      get { return spellAimLayout_; }
      set {
        spellAimLayout_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "idle_loop_timelines" field.</summary>
    public const int IdleLoopTimelinesFieldNumber = 10;
    private static readonly pb::FieldCodec<string> _repeated_idleLoopTimelines_codec
        = pb::FieldCodec.ForString(82);
    private readonly pbc::RepeatedField<string> idleLoopTimelines_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> IdleLoopTimelines {
      get { return idleLoopTimelines_; }
    }

    /// <summary>Field number for the "rng_intro_timeline" field.</summary>
    public const int RngIntroTimelineFieldNumber = 11;
    private string rngIntroTimeline_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RngIntroTimeline {
      get { return rngIntroTimeline_; }
      set {
        rngIntroTimeline_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "rng_loop_timeline" field.</summary>
    public const int RngLoopTimelineFieldNumber = 12;
    private string rngLoopTimeline_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RngLoopTimeline {
      get { return rngLoopTimeline_; }
      set {
        rngLoopTimeline_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "spell_failed_timeline" field.</summary>
    public const int SpellFailedTimelineFieldNumber = 13;
    private string spellFailedTimeline_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SpellFailedTimeline {
      get { return spellFailedTimeline_; }
      set {
        spellFailedTimeline_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "combat_spell_list" field.</summary>
    public const int CombatSpellListFieldNumber = 14;
    private static readonly pb::FieldCodec<string> _repeated_combatSpellList_codec
        = pb::FieldCodec.ForString(114);
    private readonly pbc::RepeatedField<string> combatSpellList_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> CombatSpellList {
      get { return combatSpellList_; }
    }

    private object type_;
    /// <summary>Enum of possible cases for the "Type" oneof.</summary>
    public enum TypeOneofCase {
      None = 0,
      Swish = 1,
      Combat = 2,
      Portkey = 3,
      Picture = 4,
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
      return Equals(other as ClientEncounterStage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientEncounterStage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Swish, other.Swish)) return false;
      if (!object.Equals(Combat, other.Combat)) return false;
      if (!object.Equals(Portkey, other.Portkey)) return false;
      if (!object.Equals(Picture, other.Picture)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DisappearDelay, other.DisappearDelay)) return false;
      if (IntroText != other.IntroText) return false;
      if(!stageSetupSequence_.Equals(other.stageSetupSequence_)) return false;
      if(!stageCompletionSequence_.Equals(other.stageCompletionSequence_)) return false;
      if (SpellAimLayout != other.SpellAimLayout) return false;
      if(!idleLoopTimelines_.Equals(other.idleLoopTimelines_)) return false;
      if (RngIntroTimeline != other.RngIntroTimeline) return false;
      if (RngLoopTimeline != other.RngLoopTimeline) return false;
      if (SpellFailedTimeline != other.SpellFailedTimeline) return false;
      if(!combatSpellList_.Equals(other.combatSpellList_)) return false;
      if (TypeCase != other.TypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (typeCase_ == TypeOneofCase.Swish) hash ^= Swish.GetHashCode();
      if (typeCase_ == TypeOneofCase.Combat) hash ^= Combat.GetHashCode();
      if (typeCase_ == TypeOneofCase.Portkey) hash ^= Portkey.GetHashCode();
      if (typeCase_ == TypeOneofCase.Picture) hash ^= Picture.GetHashCode();
      if (DisappearDelay != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DisappearDelay);
      if (IntroText.Length != 0) hash ^= IntroText.GetHashCode();
      hash ^= stageSetupSequence_.GetHashCode();
      hash ^= stageCompletionSequence_.GetHashCode();
      if (SpellAimLayout.Length != 0) hash ^= SpellAimLayout.GetHashCode();
      hash ^= idleLoopTimelines_.GetHashCode();
      if (RngIntroTimeline.Length != 0) hash ^= RngIntroTimeline.GetHashCode();
      if (RngLoopTimeline.Length != 0) hash ^= RngLoopTimeline.GetHashCode();
      if (SpellFailedTimeline.Length != 0) hash ^= SpellFailedTimeline.GetHashCode();
      hash ^= combatSpellList_.GetHashCode();
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
      if (typeCase_ == TypeOneofCase.Picture) {
        output.WriteRawTag(34);
        output.WriteMessage(Picture);
      }
      if (DisappearDelay != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(DisappearDelay);
      }
      if (IntroText.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(IntroText);
      }
      stageSetupSequence_.WriteTo(output, _repeated_stageSetupSequence_codec);
      stageCompletionSequence_.WriteTo(output, _repeated_stageCompletionSequence_codec);
      if (SpellAimLayout.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(SpellAimLayout);
      }
      idleLoopTimelines_.WriteTo(output, _repeated_idleLoopTimelines_codec);
      if (RngIntroTimeline.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(RngIntroTimeline);
      }
      if (RngLoopTimeline.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(RngLoopTimeline);
      }
      if (SpellFailedTimeline.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(SpellFailedTimeline);
      }
      combatSpellList_.WriteTo(output, _repeated_combatSpellList_codec);
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
      if (typeCase_ == TypeOneofCase.Picture) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Picture);
      }
      if (DisappearDelay != 0F) {
        size += 1 + 4;
      }
      if (IntroText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IntroText);
      }
      size += stageSetupSequence_.CalculateSize(_repeated_stageSetupSequence_codec);
      size += stageCompletionSequence_.CalculateSize(_repeated_stageCompletionSequence_codec);
      if (SpellAimLayout.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SpellAimLayout);
      }
      size += idleLoopTimelines_.CalculateSize(_repeated_idleLoopTimelines_codec);
      if (RngIntroTimeline.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RngIntroTimeline);
      }
      if (RngLoopTimeline.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RngLoopTimeline);
      }
      if (SpellFailedTimeline.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SpellFailedTimeline);
      }
      size += combatSpellList_.CalculateSize(_repeated_combatSpellList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientEncounterStage other) {
      if (other == null) {
        return;
      }
      if (other.DisappearDelay != 0F) {
        DisappearDelay = other.DisappearDelay;
      }
      if (other.IntroText.Length != 0) {
        IntroText = other.IntroText;
      }
      stageSetupSequence_.Add(other.stageSetupSequence_);
      stageCompletionSequence_.Add(other.stageCompletionSequence_);
      if (other.SpellAimLayout.Length != 0) {
        SpellAimLayout = other.SpellAimLayout;
      }
      idleLoopTimelines_.Add(other.idleLoopTimelines_);
      if (other.RngIntroTimeline.Length != 0) {
        RngIntroTimeline = other.RngIntroTimeline;
      }
      if (other.RngLoopTimeline.Length != 0) {
        RngLoopTimeline = other.RngLoopTimeline;
      }
      if (other.SpellFailedTimeline.Length != 0) {
        SpellFailedTimeline = other.SpellFailedTimeline;
      }
      combatSpellList_.Add(other.combatSpellList_);
      switch (other.TypeCase) {
        case TypeOneofCase.Swish:
          if (Swish == null) {
            Swish = new global::WUProtos.Data.Client.ClientEncounterStageSwish();
          }
          Swish.MergeFrom(other.Swish);
          break;
        case TypeOneofCase.Combat:
          if (Combat == null) {
            Combat = new global::WUProtos.Data.Client.ClientEncounterStageCombat();
          }
          Combat.MergeFrom(other.Combat);
          break;
        case TypeOneofCase.Portkey:
          if (Portkey == null) {
            Portkey = new global::WUProtos.Data.Client.ClientEncounterStagePortkey();
          }
          Portkey.MergeFrom(other.Portkey);
          break;
        case TypeOneofCase.Picture:
          if (Picture == null) {
            Picture = new global::WUProtos.Data.Client.ClientEncounterStagePicture();
          }
          Picture.MergeFrom(other.Picture);
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
            global::WUProtos.Data.Client.ClientEncounterStageSwish subBuilder = new global::WUProtos.Data.Client.ClientEncounterStageSwish();
            if (typeCase_ == TypeOneofCase.Swish) {
              subBuilder.MergeFrom(Swish);
            }
            input.ReadMessage(subBuilder);
            Swish = subBuilder;
            break;
          }
          case 18: {
            global::WUProtos.Data.Client.ClientEncounterStageCombat subBuilder = new global::WUProtos.Data.Client.ClientEncounterStageCombat();
            if (typeCase_ == TypeOneofCase.Combat) {
              subBuilder.MergeFrom(Combat);
            }
            input.ReadMessage(subBuilder);
            Combat = subBuilder;
            break;
          }
          case 26: {
            global::WUProtos.Data.Client.ClientEncounterStagePortkey subBuilder = new global::WUProtos.Data.Client.ClientEncounterStagePortkey();
            if (typeCase_ == TypeOneofCase.Portkey) {
              subBuilder.MergeFrom(Portkey);
            }
            input.ReadMessage(subBuilder);
            Portkey = subBuilder;
            break;
          }
          case 34: {
            global::WUProtos.Data.Client.ClientEncounterStagePicture subBuilder = new global::WUProtos.Data.Client.ClientEncounterStagePicture();
            if (typeCase_ == TypeOneofCase.Picture) {
              subBuilder.MergeFrom(Picture);
            }
            input.ReadMessage(subBuilder);
            Picture = subBuilder;
            break;
          }
          case 45: {
            DisappearDelay = input.ReadFloat();
            break;
          }
          case 50: {
            IntroText = input.ReadString();
            break;
          }
          case 58: {
            stageSetupSequence_.AddEntriesFrom(input, _repeated_stageSetupSequence_codec);
            break;
          }
          case 66: {
            stageCompletionSequence_.AddEntriesFrom(input, _repeated_stageCompletionSequence_codec);
            break;
          }
          case 74: {
            SpellAimLayout = input.ReadString();
            break;
          }
          case 82: {
            idleLoopTimelines_.AddEntriesFrom(input, _repeated_idleLoopTimelines_codec);
            break;
          }
          case 90: {
            RngIntroTimeline = input.ReadString();
            break;
          }
          case 98: {
            RngLoopTimeline = input.ReadString();
            break;
          }
          case 106: {
            SpellFailedTimeline = input.ReadString();
            break;
          }
          case 114: {
            combatSpellList_.AddEntriesFrom(input, _repeated_combatSpellList_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
