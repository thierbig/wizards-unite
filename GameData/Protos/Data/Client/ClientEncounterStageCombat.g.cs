// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientEncounterStageCombat.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientEncounterStageCombat.proto</summary>
  public static partial class ClientEncounterStageCombatReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientEncounterStageCombat.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientEncounterStageCombatReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRFbmNvdW50ZXJTdGFnZUNv",
            "bWJhdC5wcm90bxIUV1VQcm90b3MuRGF0YS5DbGllbnQaLFdVUHJvdG9zL0Rh",
            "dGEvQ2xpZW50L0NsaWVudENvbWJhdFN0YXRlLnByb3RvGjFXVVByb3Rvcy9E",
            "YXRhL0NsaWVudC9DbGllbnRDb21iYXRFbmVteVRyYWl0LnByb3RvGi5XVVBy",
            "b3Rvcy9EYXRhL0NsaWVudC9DbGllbnRFbmNvdW50ZXJUeXBlLnByb3RvIoMC",
            "ChpDbGllbnRFbmNvdW50ZXJTdGFnZUNvbWJhdBJCChFzdGF0ZV9ncmFwaF9u",
            "b2RlcxgBIAMoCzInLldVUHJvdG9zLkRhdGEuQ2xpZW50LkNsaWVudENvbWJh",
            "dFN0YXRlEkIKDGVuZW15X3RyYWl0cxgCIAMoCzIsLldVUHJvdG9zLkRhdGEu",
            "Q2xpZW50LkNsaWVudENvbWJhdEVuZW15VHJhaXQSQgoPZW5lbXlfcmFua190",
            "YWdzGAMgAygLMikuV1VQcm90b3MuRGF0YS5DbGllbnQuQ2xpZW50RW5jb3Vu",
            "dGVyVHlwZRIZChFlbmVteV9mbGF2b3JfdGV4dBgEIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Client.ClientCombatStateReflection.Descriptor, global::WUProtos.Data.Client.ClientCombatEnemyTraitReflection.Descriptor, global::WUProtos.Data.Client.ClientEncounterTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientEncounterStageCombat), global::WUProtos.Data.Client.ClientEncounterStageCombat.Parser, new[]{ "StateGraphNodes", "EnemyTraits", "EnemyRankTags", "EnemyFlavorText" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientEncounterStageCombat : pb::IMessage<ClientEncounterStageCombat> {
    private static readonly pb::MessageParser<ClientEncounterStageCombat> _parser = new pb::MessageParser<ClientEncounterStageCombat>(() => new ClientEncounterStageCombat());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientEncounterStageCombat> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientEncounterStageCombatReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientEncounterStageCombat() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientEncounterStageCombat(ClientEncounterStageCombat other) : this() {
      stateGraphNodes_ = other.stateGraphNodes_.Clone();
      enemyTraits_ = other.enemyTraits_.Clone();
      enemyRankTags_ = other.enemyRankTags_.Clone();
      enemyFlavorText_ = other.enemyFlavorText_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientEncounterStageCombat Clone() {
      return new ClientEncounterStageCombat(this);
    }

    /// <summary>Field number for the "state_graph_nodes" field.</summary>
    public const int StateGraphNodesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::WUProtos.Data.Client.ClientCombatState> _repeated_stateGraphNodes_codec
        = pb::FieldCodec.ForMessage(10, global::WUProtos.Data.Client.ClientCombatState.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.Client.ClientCombatState> stateGraphNodes_ = new pbc::RepeatedField<global::WUProtos.Data.Client.ClientCombatState>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.Client.ClientCombatState> StateGraphNodes {
      get { return stateGraphNodes_; }
    }

    /// <summary>Field number for the "enemy_traits" field.</summary>
    public const int EnemyTraitsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::WUProtos.Data.Client.ClientCombatEnemyTrait> _repeated_enemyTraits_codec
        = pb::FieldCodec.ForMessage(18, global::WUProtos.Data.Client.ClientCombatEnemyTrait.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.Client.ClientCombatEnemyTrait> enemyTraits_ = new pbc::RepeatedField<global::WUProtos.Data.Client.ClientCombatEnemyTrait>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.Client.ClientCombatEnemyTrait> EnemyTraits {
      get { return enemyTraits_; }
    }

    /// <summary>Field number for the "enemy_rank_tags" field.</summary>
    public const int EnemyRankTagsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::WUProtos.Data.Client.ClientEncounterType> _repeated_enemyRankTags_codec
        = pb::FieldCodec.ForMessage(26, global::WUProtos.Data.Client.ClientEncounterType.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.Client.ClientEncounterType> enemyRankTags_ = new pbc::RepeatedField<global::WUProtos.Data.Client.ClientEncounterType>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.Client.ClientEncounterType> EnemyRankTags {
      get { return enemyRankTags_; }
    }

    /// <summary>Field number for the "enemy_flavor_text" field.</summary>
    public const int EnemyFlavorTextFieldNumber = 4;
    private string enemyFlavorText_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EnemyFlavorText {
      get { return enemyFlavorText_; }
      set {
        enemyFlavorText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientEncounterStageCombat);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientEncounterStageCombat other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!stateGraphNodes_.Equals(other.stateGraphNodes_)) return false;
      if(!enemyTraits_.Equals(other.enemyTraits_)) return false;
      if(!enemyRankTags_.Equals(other.enemyRankTags_)) return false;
      if (EnemyFlavorText != other.EnemyFlavorText) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= stateGraphNodes_.GetHashCode();
      hash ^= enemyTraits_.GetHashCode();
      hash ^= enemyRankTags_.GetHashCode();
      if (EnemyFlavorText.Length != 0) hash ^= EnemyFlavorText.GetHashCode();
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
      stateGraphNodes_.WriteTo(output, _repeated_stateGraphNodes_codec);
      enemyTraits_.WriteTo(output, _repeated_enemyTraits_codec);
      enemyRankTags_.WriteTo(output, _repeated_enemyRankTags_codec);
      if (EnemyFlavorText.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(EnemyFlavorText);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += stateGraphNodes_.CalculateSize(_repeated_stateGraphNodes_codec);
      size += enemyTraits_.CalculateSize(_repeated_enemyTraits_codec);
      size += enemyRankTags_.CalculateSize(_repeated_enemyRankTags_codec);
      if (EnemyFlavorText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EnemyFlavorText);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientEncounterStageCombat other) {
      if (other == null) {
        return;
      }
      stateGraphNodes_.Add(other.stateGraphNodes_);
      enemyTraits_.Add(other.enemyTraits_);
      enemyRankTags_.Add(other.enemyRankTags_);
      if (other.EnemyFlavorText.Length != 0) {
        EnemyFlavorText = other.EnemyFlavorText;
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
            stateGraphNodes_.AddEntriesFrom(input, _repeated_stateGraphNodes_codec);
            break;
          }
          case 18: {
            enemyTraits_.AddEntriesFrom(input, _repeated_enemyTraits_codec);
            break;
          }
          case 26: {
            enemyRankTags_.AddEntriesFrom(input, _repeated_enemyRankTags_codec);
            break;
          }
          case 34: {
            EnemyFlavorText = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
