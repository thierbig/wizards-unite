// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/DbgGetSpellcastInfoMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/DbgGetSpellcastInfoMessage.proto</summary>
  public static partial class DbgGetSpellcastInfoMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/DbgGetSpellcastInfoMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DbgGetSpellcastInfoMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkZXVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0RiZ0dl",
            "dFNwZWxsY2FzdEluZm9NZXNzYWdlLnByb3RvEiVXVVByb3Rvcy5OZXR3b3Jr",
            "aW5nLlJlcXVlc3RzLk1lc3NhZ2VzImEKGkRiZ0dldFNwZWxsY2FzdEluZm9N",
            "ZXNzYWdlEhQKDGVuY291bnRlcl9pZBgBIAEoDBIVCg1lbmVyZ3lfZ210X2lk",
            "GAIgAygJEhYKDmFjY3VyYWN5X2JvbnVzGAMgASgCYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.DbgGetSpellcastInfoMessage), global::WUProtos.Networking.Requests.Messages.DbgGetSpellcastInfoMessage.Parser, new[]{ "EncounterId", "EnergyGmtId", "AccuracyBonus" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DbgGetSpellcastInfoMessage : pb::IMessage<DbgGetSpellcastInfoMessage> {
    private static readonly pb::MessageParser<DbgGetSpellcastInfoMessage> _parser = new pb::MessageParser<DbgGetSpellcastInfoMessage>(() => new DbgGetSpellcastInfoMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DbgGetSpellcastInfoMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.DbgGetSpellcastInfoMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgGetSpellcastInfoMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgGetSpellcastInfoMessage(DbgGetSpellcastInfoMessage other) : this() {
      encounterId_ = other.encounterId_;
      energyGmtId_ = other.energyGmtId_.Clone();
      accuracyBonus_ = other.accuracyBonus_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgGetSpellcastInfoMessage Clone() {
      return new DbgGetSpellcastInfoMessage(this);
    }

    /// <summary>Field number for the "encounter_id" field.</summary>
    public const int EncounterIdFieldNumber = 1;
    private pb::ByteString encounterId_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString EncounterId {
      get { return encounterId_; }
      set {
        encounterId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "energy_gmt_id" field.</summary>
    public const int EnergyGmtIdFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_energyGmtId_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> energyGmtId_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> EnergyGmtId {
      get { return energyGmtId_; }
    }

    /// <summary>Field number for the "accuracy_bonus" field.</summary>
    public const int AccuracyBonusFieldNumber = 3;
    private float accuracyBonus_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float AccuracyBonus {
      get { return accuracyBonus_; }
      set {
        accuracyBonus_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DbgGetSpellcastInfoMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DbgGetSpellcastInfoMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EncounterId != other.EncounterId) return false;
      if(!energyGmtId_.Equals(other.energyGmtId_)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AccuracyBonus, other.AccuracyBonus)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EncounterId.Length != 0) hash ^= EncounterId.GetHashCode();
      hash ^= energyGmtId_.GetHashCode();
      if (AccuracyBonus != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AccuracyBonus);
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
      if (EncounterId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(EncounterId);
      }
      energyGmtId_.WriteTo(output, _repeated_energyGmtId_codec);
      if (AccuracyBonus != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(AccuracyBonus);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EncounterId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(EncounterId);
      }
      size += energyGmtId_.CalculateSize(_repeated_energyGmtId_codec);
      if (AccuracyBonus != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DbgGetSpellcastInfoMessage other) {
      if (other == null) {
        return;
      }
      if (other.EncounterId.Length != 0) {
        EncounterId = other.EncounterId;
      }
      energyGmtId_.Add(other.energyGmtId_);
      if (other.AccuracyBonus != 0F) {
        AccuracyBonus = other.AccuracyBonus;
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
            EncounterId = input.ReadBytes();
            break;
          }
          case 18: {
            energyGmtId_.AddEntriesFrom(input, _repeated_energyGmtId_codec);
            break;
          }
          case 29: {
            AccuracyBonus = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
