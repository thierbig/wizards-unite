// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Inventory/InventoryCauldron.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Inventory {

  /// <summary>Holder for reflection information generated from WUProtos/Inventory/InventoryCauldron.proto</summary>
  public static partial class InventoryCauldronReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Inventory/InventoryCauldron.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InventoryCauldronReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipXVVByb3Rvcy9JbnZlbnRvcnkvSW52ZW50b3J5Q2F1bGRyb24ucHJvdG8S",
            "EldVUHJvdG9zLkludmVudG9yeRouV1VQcm90b3MvSW52ZW50b3J5L0ludmVu",
            "dG9yeUNhdWxkcm9uU2xvdC5wcm90byLqAQoRSW52ZW50b3J5Q2F1bGRyb24S",
            "EAoIaXByb3RvaWQYASABKAkSCgoCaWQYAiABKAMSEwoLdGVtcGxhdGVfaWQY",
            "AyABKAkSQAoNY2F1bGRyb25fc2xvdBgEIAMoCzIpLldVUHJvdG9zLkludmVu",
            "dG9yeS5JbnZlbnRvcnlDYXVsZHJvblNsb3QSHwoXYnJld2luZ19zdGFydF90",
            "aW1lc3RhbXAYBSABKAMSJAocYXZhaWxhYmlsaXR5X3N0YXJ0X3RpbWVzdGFt",
            "cBgGIAEoAxIZChFhdmFpbGFiaWxpdHlfdGltZRgHIAEoA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Inventory.InventoryCauldronSlotReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Inventory.InventoryCauldron), global::WUProtos.Inventory.InventoryCauldron.Parser, new[]{ "Iprotoid", "Id", "TemplateId", "CauldronSlot", "BrewingStartTimestamp", "AvailabilityStartTimestamp", "AvailabilityTime" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InventoryCauldron : pb::IMessage<InventoryCauldron> {
    private static readonly pb::MessageParser<InventoryCauldron> _parser = new pb::MessageParser<InventoryCauldron>(() => new InventoryCauldron());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InventoryCauldron> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Inventory.InventoryCauldronReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InventoryCauldron() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InventoryCauldron(InventoryCauldron other) : this() {
      iprotoid_ = other.iprotoid_;
      id_ = other.id_;
      templateId_ = other.templateId_;
      cauldronSlot_ = other.cauldronSlot_.Clone();
      brewingStartTimestamp_ = other.brewingStartTimestamp_;
      availabilityStartTimestamp_ = other.availabilityStartTimestamp_;
      availabilityTime_ = other.availabilityTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InventoryCauldron Clone() {
      return new InventoryCauldron(this);
    }

    /// <summary>Field number for the "iprotoid" field.</summary>
    public const int IprotoidFieldNumber = 1;
    private string iprotoid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Iprotoid {
      get { return iprotoid_; }
      set {
        iprotoid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private long id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "template_id" field.</summary>
    public const int TemplateIdFieldNumber = 3;
    private string templateId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TemplateId {
      get { return templateId_; }
      set {
        templateId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cauldron_slot" field.</summary>
    public const int CauldronSlotFieldNumber = 4;
    private static readonly pb::FieldCodec<global::WUProtos.Inventory.InventoryCauldronSlot> _repeated_cauldronSlot_codec
        = pb::FieldCodec.ForMessage(34, global::WUProtos.Inventory.InventoryCauldronSlot.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Inventory.InventoryCauldronSlot> cauldronSlot_ = new pbc::RepeatedField<global::WUProtos.Inventory.InventoryCauldronSlot>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Inventory.InventoryCauldronSlot> CauldronSlot {
      get { return cauldronSlot_; }
    }

    /// <summary>Field number for the "brewing_start_timestamp" field.</summary>
    public const int BrewingStartTimestampFieldNumber = 5;
    private long brewingStartTimestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BrewingStartTimestamp {
      get { return brewingStartTimestamp_; }
      set {
        brewingStartTimestamp_ = value;
      }
    }

    /// <summary>Field number for the "availability_start_timestamp" field.</summary>
    public const int AvailabilityStartTimestampFieldNumber = 6;
    private long availabilityStartTimestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long AvailabilityStartTimestamp {
      get { return availabilityStartTimestamp_; }
      set {
        availabilityStartTimestamp_ = value;
      }
    }

    /// <summary>Field number for the "availability_time" field.</summary>
    public const int AvailabilityTimeFieldNumber = 7;
    private long availabilityTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long AvailabilityTime {
      get { return availabilityTime_; }
      set {
        availabilityTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InventoryCauldron);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InventoryCauldron other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Iprotoid != other.Iprotoid) return false;
      if (Id != other.Id) return false;
      if (TemplateId != other.TemplateId) return false;
      if(!cauldronSlot_.Equals(other.cauldronSlot_)) return false;
      if (BrewingStartTimestamp != other.BrewingStartTimestamp) return false;
      if (AvailabilityStartTimestamp != other.AvailabilityStartTimestamp) return false;
      if (AvailabilityTime != other.AvailabilityTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Iprotoid.Length != 0) hash ^= Iprotoid.GetHashCode();
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (TemplateId.Length != 0) hash ^= TemplateId.GetHashCode();
      hash ^= cauldronSlot_.GetHashCode();
      if (BrewingStartTimestamp != 0L) hash ^= BrewingStartTimestamp.GetHashCode();
      if (AvailabilityStartTimestamp != 0L) hash ^= AvailabilityStartTimestamp.GetHashCode();
      if (AvailabilityTime != 0L) hash ^= AvailabilityTime.GetHashCode();
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
      if (Iprotoid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Iprotoid);
      }
      if (Id != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Id);
      }
      if (TemplateId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(TemplateId);
      }
      cauldronSlot_.WriteTo(output, _repeated_cauldronSlot_codec);
      if (BrewingStartTimestamp != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(BrewingStartTimestamp);
      }
      if (AvailabilityStartTimestamp != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(AvailabilityStartTimestamp);
      }
      if (AvailabilityTime != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(AvailabilityTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Iprotoid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Iprotoid);
      }
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (TemplateId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TemplateId);
      }
      size += cauldronSlot_.CalculateSize(_repeated_cauldronSlot_codec);
      if (BrewingStartTimestamp != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BrewingStartTimestamp);
      }
      if (AvailabilityStartTimestamp != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(AvailabilityStartTimestamp);
      }
      if (AvailabilityTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(AvailabilityTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InventoryCauldron other) {
      if (other == null) {
        return;
      }
      if (other.Iprotoid.Length != 0) {
        Iprotoid = other.Iprotoid;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.TemplateId.Length != 0) {
        TemplateId = other.TemplateId;
      }
      cauldronSlot_.Add(other.cauldronSlot_);
      if (other.BrewingStartTimestamp != 0L) {
        BrewingStartTimestamp = other.BrewingStartTimestamp;
      }
      if (other.AvailabilityStartTimestamp != 0L) {
        AvailabilityStartTimestamp = other.AvailabilityStartTimestamp;
      }
      if (other.AvailabilityTime != 0L) {
        AvailabilityTime = other.AvailabilityTime;
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
            Iprotoid = input.ReadString();
            break;
          }
          case 16: {
            Id = input.ReadInt64();
            break;
          }
          case 26: {
            TemplateId = input.ReadString();
            break;
          }
          case 34: {
            cauldronSlot_.AddEntriesFrom(input, _repeated_cauldronSlot_codec);
            break;
          }
          case 40: {
            BrewingStartTimestamp = input.ReadInt64();
            break;
          }
          case 48: {
            AvailabilityStartTimestamp = input.ReadInt64();
            break;
          }
          case 56: {
            AvailabilityTime = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
