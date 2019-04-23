// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientMapTrace.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientMapTrace.proto</summary>
  public static partial class ClientMapTraceReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientMapTrace.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientMapTraceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRNYXBUcmFjZS5wcm90bxIU",
            "V1VQcm90b3MuRGF0YS5DbGllbnQi9gEKDkNsaWVudE1hcFRyYWNlEhgKEGVu",
            "Y291bnRlcl9nbXRfaWQYASABKAkSEAoIbGF0aXR1ZGUYAiABKAESEQoJbG9u",
            "Z2l0dWRlGAMgASgBEhgKEGVuY291bnRlcl90aWNrZXQYBCABKAwSOwoGc291",
            "cmNlGAUgASgOMisuV1VQcm90b3MuRGF0YS5DbGllbnQuQ2xpZW50TWFwVHJh",
            "Y2UuU291cmNlEhYKDmV4cGlyeV90aW1lX21zGAYgASgDIjYKBlNvdXJjZRIL",
            "CgdVTktOT1dOEAASDAoIU1RBTkRBUkQQARIRCg1EQVJLX0RFVEVDVE9SEAJi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientMapTrace), global::WUProtos.Data.Client.ClientMapTrace.Parser, new[]{ "EncounterGmtId", "Latitude", "Longitude", "EncounterTicket", "Source", "ExpiryTimeMs" }, null, new[]{ typeof(global::WUProtos.Data.Client.ClientMapTrace.Types.Source) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientMapTrace : pb::IMessage<ClientMapTrace> {
    private static readonly pb::MessageParser<ClientMapTrace> _parser = new pb::MessageParser<ClientMapTrace>(() => new ClientMapTrace());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientMapTrace> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientMapTraceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientMapTrace() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientMapTrace(ClientMapTrace other) : this() {
      encounterGmtId_ = other.encounterGmtId_;
      latitude_ = other.latitude_;
      longitude_ = other.longitude_;
      encounterTicket_ = other.encounterTicket_;
      source_ = other.source_;
      expiryTimeMs_ = other.expiryTimeMs_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientMapTrace Clone() {
      return new ClientMapTrace(this);
    }

    /// <summary>Field number for the "encounter_gmt_id" field.</summary>
    public const int EncounterGmtIdFieldNumber = 1;
    private string encounterGmtId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EncounterGmtId {
      get { return encounterGmtId_; }
      set {
        encounterGmtId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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

    /// <summary>Field number for the "encounter_ticket" field.</summary>
    public const int EncounterTicketFieldNumber = 4;
    private pb::ByteString encounterTicket_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString EncounterTicket {
      get { return encounterTicket_; }
      set {
        encounterTicket_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 5;
    private global::WUProtos.Data.Client.ClientMapTrace.Types.Source source_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Client.ClientMapTrace.Types.Source Source {
      get { return source_; }
      set {
        source_ = value;
      }
    }

    /// <summary>Field number for the "expiry_time_ms" field.</summary>
    public const int ExpiryTimeMsFieldNumber = 6;
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
      return Equals(other as ClientMapTrace);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientMapTrace other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EncounterGmtId != other.EncounterGmtId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Latitude, other.Latitude)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Longitude, other.Longitude)) return false;
      if (EncounterTicket != other.EncounterTicket) return false;
      if (Source != other.Source) return false;
      if (ExpiryTimeMs != other.ExpiryTimeMs) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EncounterGmtId.Length != 0) hash ^= EncounterGmtId.GetHashCode();
      if (Latitude != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Latitude);
      if (Longitude != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Longitude);
      if (EncounterTicket.Length != 0) hash ^= EncounterTicket.GetHashCode();
      if (Source != 0) hash ^= Source.GetHashCode();
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
      if (EncounterGmtId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(EncounterGmtId);
      }
      if (Latitude != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Latitude);
      }
      if (Longitude != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Longitude);
      }
      if (EncounterTicket.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(EncounterTicket);
      }
      if (Source != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Source);
      }
      if (ExpiryTimeMs != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(ExpiryTimeMs);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EncounterGmtId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EncounterGmtId);
      }
      if (Latitude != 0D) {
        size += 1 + 8;
      }
      if (Longitude != 0D) {
        size += 1 + 8;
      }
      if (EncounterTicket.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(EncounterTicket);
      }
      if (Source != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Source);
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
    public void MergeFrom(ClientMapTrace other) {
      if (other == null) {
        return;
      }
      if (other.EncounterGmtId.Length != 0) {
        EncounterGmtId = other.EncounterGmtId;
      }
      if (other.Latitude != 0D) {
        Latitude = other.Latitude;
      }
      if (other.Longitude != 0D) {
        Longitude = other.Longitude;
      }
      if (other.EncounterTicket.Length != 0) {
        EncounterTicket = other.EncounterTicket;
      }
      if (other.Source != 0) {
        Source = other.Source;
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
            EncounterGmtId = input.ReadString();
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
            EncounterTicket = input.ReadBytes();
            break;
          }
          case 40: {
            Source = (global::WUProtos.Data.Client.ClientMapTrace.Types.Source) input.ReadEnum();
            break;
          }
          case 48: {
            ExpiryTimeMs = input.ReadInt64();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ClientMapTrace message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Source {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("STANDARD")] Standard = 1,
        [pbr::OriginalName("DARK_DETECTOR")] DarkDetector = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code