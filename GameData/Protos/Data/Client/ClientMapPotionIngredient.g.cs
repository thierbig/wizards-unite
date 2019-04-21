// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientMapPotionIngredient.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientMapPotionIngredient.proto</summary>
  public static partial class ClientMapPotionIngredientReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientMapPotionIngredient.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientMapPotionIngredientReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRNYXBQb3Rpb25JbmdyZWRp",
            "ZW50LnByb3RvEhRXVVByb3Rvcy5EYXRhLkNsaWVudCKDAQoZQ2xpZW50TWFw",
            "UG90aW9uSW5ncmVkaWVudBIZChFpbmdyZWRpZW50X2dtdF9pZBgBIAEoCRIQ",
            "CghsYXRpdHVkZRgCIAEoARIRCglsb25naXR1ZGUYAyABKAESDgoGdGlja2V0",
            "GAQgASgMEhYKDmV4cGlyeV90aW1lX21zGAUgASgDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientMapPotionIngredient), global::WUProtos.Data.Client.ClientMapPotionIngredient.Parser, new[]{ "IngredientGmtId", "Latitude", "Longitude", "Ticket", "ExpiryTimeMs" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientMapPotionIngredient : pb::IMessage<ClientMapPotionIngredient> {
    private static readonly pb::MessageParser<ClientMapPotionIngredient> _parser = new pb::MessageParser<ClientMapPotionIngredient>(() => new ClientMapPotionIngredient());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientMapPotionIngredient> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientMapPotionIngredientReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientMapPotionIngredient() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientMapPotionIngredient(ClientMapPotionIngredient other) : this() {
      ingredientGmtId_ = other.ingredientGmtId_;
      latitude_ = other.latitude_;
      longitude_ = other.longitude_;
      ticket_ = other.ticket_;
      expiryTimeMs_ = other.expiryTimeMs_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientMapPotionIngredient Clone() {
      return new ClientMapPotionIngredient(this);
    }

    /// <summary>Field number for the "ingredient_gmt_id" field.</summary>
    public const int IngredientGmtIdFieldNumber = 1;
    private string ingredientGmtId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string IngredientGmtId {
      get { return ingredientGmtId_; }
      set {
        ingredientGmtId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "latitude" field.</summary>
    public const int LatitudeFieldNumber = 2;
    private double latitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Latitude {
      get { return latitude_; }
      set {
        latitude_ = value;
      }
    }

    /// <summary>Field number for the "longitude" field.</summary>
    public const int LongitudeFieldNumber = 3;
    private double longitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Longitude {
      get { return longitude_; }
      set {
        longitude_ = value;
      }
    }

    /// <summary>Field number for the "ticket" field.</summary>
    public const int TicketFieldNumber = 4;
    private pb::ByteString ticket_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Ticket {
      get { return ticket_; }
      set {
        ticket_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "expiry_time_ms" field.</summary>
    public const int ExpiryTimeMsFieldNumber = 5;
    private long expiryTimeMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExpiryTimeMs {
      get { return expiryTimeMs_; }
      set {
        expiryTimeMs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientMapPotionIngredient);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientMapPotionIngredient other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IngredientGmtId != other.IngredientGmtId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Latitude, other.Latitude)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Longitude, other.Longitude)) return false;
      if (Ticket != other.Ticket) return false;
      if (ExpiryTimeMs != other.ExpiryTimeMs) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IngredientGmtId.Length != 0) hash ^= IngredientGmtId.GetHashCode();
      if (Latitude != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Latitude);
      if (Longitude != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Longitude);
      if (Ticket.Length != 0) hash ^= Ticket.GetHashCode();
      if (ExpiryTimeMs != 0L) hash ^= ExpiryTimeMs.GetHashCode();
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
      if (IngredientGmtId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(IngredientGmtId);
      }
      if (Latitude != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Latitude);
      }
      if (Longitude != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Longitude);
      }
      if (Ticket.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Ticket);
      }
      if (ExpiryTimeMs != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(ExpiryTimeMs);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IngredientGmtId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IngredientGmtId);
      }
      if (Latitude != 0D) {
        size += 1 + 8;
      }
      if (Longitude != 0D) {
        size += 1 + 8;
      }
      if (Ticket.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Ticket);
      }
      if (ExpiryTimeMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpiryTimeMs);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientMapPotionIngredient other) {
      if (other == null) {
        return;
      }
      if (other.IngredientGmtId.Length != 0) {
        IngredientGmtId = other.IngredientGmtId;
      }
      if (other.Latitude != 0D) {
        Latitude = other.Latitude;
      }
      if (other.Longitude != 0D) {
        Longitude = other.Longitude;
      }
      if (other.Ticket.Length != 0) {
        Ticket = other.Ticket;
      }
      if (other.ExpiryTimeMs != 0L) {
        ExpiryTimeMs = other.ExpiryTimeMs;
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
            IngredientGmtId = input.ReadString();
            break;
          }
          case 17: {
            Latitude = input.ReadDouble();
            break;
          }
          case 25: {
            Longitude = input.ReadDouble();
            break;
          }
          case 34: {
            Ticket = input.ReadBytes();
            break;
          }
          case 40: {
            ExpiryTimeMs = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
