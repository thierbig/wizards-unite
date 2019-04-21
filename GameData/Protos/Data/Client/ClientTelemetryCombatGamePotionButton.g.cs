// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientTelemetryCombatGamePotionButton.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientTelemetryCombatGamePotionButton.proto</summary>
  public static partial class ClientTelemetryCombatGamePotionButtonReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientTelemetryCombatGamePotionButton.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientTelemetryCombatGamePotionButtonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRUZWxlbWV0cnlDb21iYXRH",
            "YW1lUG90aW9uQnV0dG9uLnByb3RvEhRXVVByb3Rvcy5EYXRhLkNsaWVudCJk",
            "CiVDbGllbnRUZWxlbWV0cnlDb21iYXRHYW1lUG90aW9uQnV0dG9uEhQKDHBs",
            "YXllcl9sZXZlbBgBIAEoBRIUCgxlbmNvdW50ZXJfaWQYAiABKAkSDwoHYXR0",
            "ZW1wdBgDIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientTelemetryCombatGamePotionButton), global::WUProtos.Data.Client.ClientTelemetryCombatGamePotionButton.Parser, new[]{ "PlayerLevel", "EncounterId", "Attempt" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientTelemetryCombatGamePotionButton : pb::IMessage<ClientTelemetryCombatGamePotionButton> {
    private static readonly pb::MessageParser<ClientTelemetryCombatGamePotionButton> _parser = new pb::MessageParser<ClientTelemetryCombatGamePotionButton>(() => new ClientTelemetryCombatGamePotionButton());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientTelemetryCombatGamePotionButton> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientTelemetryCombatGamePotionButtonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryCombatGamePotionButton() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryCombatGamePotionButton(ClientTelemetryCombatGamePotionButton other) : this() {
      playerLevel_ = other.playerLevel_;
      encounterId_ = other.encounterId_;
      attempt_ = other.attempt_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryCombatGamePotionButton Clone() {
      return new ClientTelemetryCombatGamePotionButton(this);
    }

    /// <summary>Field number for the "player_level" field.</summary>
    public const int PlayerLevelFieldNumber = 1;
    private int playerLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PlayerLevel {
      get { return playerLevel_; }
      set {
        playerLevel_ = value;
      }
    }

    /// <summary>Field number for the "encounter_id" field.</summary>
    public const int EncounterIdFieldNumber = 2;
    private string encounterId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EncounterId {
      get { return encounterId_; }
      set {
        encounterId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "attempt" field.</summary>
    public const int AttemptFieldNumber = 3;
    private int attempt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Attempt {
      get { return attempt_; }
      set {
        attempt_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientTelemetryCombatGamePotionButton);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientTelemetryCombatGamePotionButton other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerLevel != other.PlayerLevel) return false;
      if (EncounterId != other.EncounterId) return false;
      if (Attempt != other.Attempt) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerLevel != 0) hash ^= PlayerLevel.GetHashCode();
      if (EncounterId.Length != 0) hash ^= EncounterId.GetHashCode();
      if (Attempt != 0) hash ^= Attempt.GetHashCode();
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
      if (PlayerLevel != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PlayerLevel);
      }
      if (EncounterId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(EncounterId);
      }
      if (Attempt != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Attempt);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlayerLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PlayerLevel);
      }
      if (EncounterId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EncounterId);
      }
      if (Attempt != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Attempt);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientTelemetryCombatGamePotionButton other) {
      if (other == null) {
        return;
      }
      if (other.PlayerLevel != 0) {
        PlayerLevel = other.PlayerLevel;
      }
      if (other.EncounterId.Length != 0) {
        EncounterId = other.EncounterId;
      }
      if (other.Attempt != 0) {
        Attempt = other.Attempt;
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
            PlayerLevel = input.ReadInt32();
            break;
          }
          case 18: {
            EncounterId = input.ReadString();
            break;
          }
          case 24: {
            Attempt = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
