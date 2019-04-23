// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientMapAbility.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientMapAbility.proto</summary>
  public static partial class ClientMapAbilityReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientMapAbility.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientMapAbilityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRNYXBBYmlsaXR5LnByb3Rv",
            "EhRXVVByb3Rvcy5EYXRhLkNsaWVudCLkAgoQQ2xpZW50TWFwQWJpbGl0eRIK",
            "CgJpZBgBIAEoCRIMCgRuYW1lGAIgASgJEgwKBGljb24YAyABKAkSEwoLZGVz",
            "Y3JpcHRpb24YBCABKAkSFQoNZWZmZWN0X3Nwcml0ZRgFIAEoCRITCgtzdGF0",
            "dXNfaWNvbhgGIAEoCRIMCgRzbG90GAcgASgFEhUKDWVmZmVjdF9wcmVmYWIY",
            "CCABKAkSTAoEcnVsZRgJIAEoDjI+LldVUHJvdG9zLkRhdGEuQ2xpZW50LkNs",
            "aWVudE1hcEFiaWxpdHkuQWRkaXRpb25hbFNlbGVjdGlvblJ1bGUidAoXQWRk",
            "aXRpb25hbFNlbGVjdGlvblJ1bGUSHQoZbm9uZV9hZGRpdGlvbmFsX3NlbGVj",
            "dGlvbhAAEhQKEG5vX2lmX21heF9oZWFsdGgQARITCg9ub19pZl9tYXhfZm9j",
            "dXMQAhIPCgtub19pZl9hbGl2ZRADYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientMapAbility), global::WUProtos.Data.Client.ClientMapAbility.Parser, new[]{ "Id", "Name", "Icon", "Description", "EffectSprite", "StatusIcon", "Slot", "EffectPrefab", "Rule" }, null, new[]{ typeof(global::WUProtos.Data.Client.ClientMapAbility.Types.AdditionalSelectionRule) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientMapAbility : pb::IMessage<ClientMapAbility> {
    private static readonly pb::MessageParser<ClientMapAbility> _parser = new pb::MessageParser<ClientMapAbility>(() => new ClientMapAbility());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientMapAbility> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientMapAbilityReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientMapAbility() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientMapAbility(ClientMapAbility other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      icon_ = other.icon_;
      description_ = other.description_;
      effectSprite_ = other.effectSprite_;
      statusIcon_ = other.statusIcon_;
      slot_ = other.slot_;
      effectPrefab_ = other.effectPrefab_;
      rule_ = other.rule_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientMapAbility Clone() {
      return new ClientMapAbility(this);
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

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "icon" field.</summary>
    public const int IconFieldNumber = 3;
    private string icon_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Icon {
      get { return icon_; }
      set {
        icon_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 4;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "effect_sprite" field.</summary>
    public const int EffectSpriteFieldNumber = 5;
    private string effectSprite_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EffectSprite {
      get { return effectSprite_; }
      set {
        effectSprite_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status_icon" field.</summary>
    public const int StatusIconFieldNumber = 6;
    private string statusIcon_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StatusIcon {
      get { return statusIcon_; }
      set {
        statusIcon_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "slot" field.</summary>
    public const int SlotFieldNumber = 7;
    private int slot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Slot {
      get { return slot_; }
      set {
        slot_ = value;
      }
    }

    /// <summary>Field number for the "effect_prefab" field.</summary>
    public const int EffectPrefabFieldNumber = 8;
    private string effectPrefab_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EffectPrefab {
      get { return effectPrefab_; }
      set {
        effectPrefab_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "rule" field.</summary>
    public const int RuleFieldNumber = 9;
    private global::WUProtos.Data.Client.ClientMapAbility.Types.AdditionalSelectionRule rule_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Client.ClientMapAbility.Types.AdditionalSelectionRule Rule {
      get { return rule_; }
      set {
        rule_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientMapAbility);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientMapAbility other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Icon != other.Icon) return false;
      if (Description != other.Description) return false;
      if (EffectSprite != other.EffectSprite) return false;
      if (StatusIcon != other.StatusIcon) return false;
      if (Slot != other.Slot) return false;
      if (EffectPrefab != other.EffectPrefab) return false;
      if (Rule != other.Rule) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Icon.Length != 0) hash ^= Icon.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (EffectSprite.Length != 0) hash ^= EffectSprite.GetHashCode();
      if (StatusIcon.Length != 0) hash ^= StatusIcon.GetHashCode();
      if (Slot != 0) hash ^= Slot.GetHashCode();
      if (EffectPrefab.Length != 0) hash ^= EffectPrefab.GetHashCode();
      if (Rule != 0) hash ^= Rule.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Icon.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Icon);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Description);
      }
      if (EffectSprite.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(EffectSprite);
      }
      if (StatusIcon.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(StatusIcon);
      }
      if (Slot != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Slot);
      }
      if (EffectPrefab.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(EffectPrefab);
      }
      if (Rule != 0) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Rule);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Icon.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Icon);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (EffectSprite.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EffectSprite);
      }
      if (StatusIcon.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StatusIcon);
      }
      if (Slot != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Slot);
      }
      if (EffectPrefab.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EffectPrefab);
      }
      if (Rule != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Rule);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientMapAbility other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Icon.Length != 0) {
        Icon = other.Icon;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.EffectSprite.Length != 0) {
        EffectSprite = other.EffectSprite;
      }
      if (other.StatusIcon.Length != 0) {
        StatusIcon = other.StatusIcon;
      }
      if (other.Slot != 0) {
        Slot = other.Slot;
      }
      if (other.EffectPrefab.Length != 0) {
        EffectPrefab = other.EffectPrefab;
      }
      if (other.Rule != 0) {
        Rule = other.Rule;
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
            Name = input.ReadString();
            break;
          }
          case 26: {
            Icon = input.ReadString();
            break;
          }
          case 34: {
            Description = input.ReadString();
            break;
          }
          case 42: {
            EffectSprite = input.ReadString();
            break;
          }
          case 50: {
            StatusIcon = input.ReadString();
            break;
          }
          case 56: {
            Slot = input.ReadInt32();
            break;
          }
          case 66: {
            EffectPrefab = input.ReadString();
            break;
          }
          case 72: {
            Rule = (global::WUProtos.Data.Client.ClientMapAbility.Types.AdditionalSelectionRule) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ClientMapAbility message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum AdditionalSelectionRule {
        [pbr::OriginalName("none_additional_selection")] NoneAdditionalSelection = 0,
        [pbr::OriginalName("no_if_max_health")] NoIfMaxHealth = 1,
        [pbr::OriginalName("no_if_max_focus")] NoIfMaxFocus = 2,
        [pbr::OriginalName("no_if_alive")] NoIfAlive = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code