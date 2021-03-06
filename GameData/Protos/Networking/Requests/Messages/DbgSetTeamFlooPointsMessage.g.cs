// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/DbgSetTeamFlooPointsMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/DbgSetTeamFlooPointsMessage.proto</summary>
  public static partial class DbgSetTeamFlooPointsMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/DbgSetTeamFlooPointsMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DbgSetTeamFlooPointsMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkdXVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0RiZ1Nl",
            "dFRlYW1GbG9vUG9pbnRzTWVzc2FnZS5wcm90bxIlV1VQcm90b3MuTmV0d29y",
            "a2luZy5SZXF1ZXN0cy5NZXNzYWdlcyJ9ChtEYmdTZXRUZWFtRmxvb1BvaW50",
            "c01lc3NhZ2USEwoLZm9ydHJlc3NfaWQYASABKAkSEAoIbGF0aXR1ZGUYAiAB",
            "KAESEQoJbG9uZ2l0dWRlGAMgASgBEg8KB3RlYW1faWQYBCABKAkSEwoLZmxv",
            "b19wb2ludHMYBSABKANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.DbgSetTeamFlooPointsMessage), global::WUProtos.Networking.Requests.Messages.DbgSetTeamFlooPointsMessage.Parser, new[]{ "FortressId", "Latitude", "Longitude", "TeamId", "FlooPoints" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DbgSetTeamFlooPointsMessage : pb::IMessage<DbgSetTeamFlooPointsMessage> {
    private static readonly pb::MessageParser<DbgSetTeamFlooPointsMessage> _parser = new pb::MessageParser<DbgSetTeamFlooPointsMessage>(() => new DbgSetTeamFlooPointsMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DbgSetTeamFlooPointsMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.DbgSetTeamFlooPointsMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgSetTeamFlooPointsMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgSetTeamFlooPointsMessage(DbgSetTeamFlooPointsMessage other) : this() {
      fortressId_ = other.fortressId_;
      latitude_ = other.latitude_;
      longitude_ = other.longitude_;
      teamId_ = other.teamId_;
      flooPoints_ = other.flooPoints_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgSetTeamFlooPointsMessage Clone() {
      return new DbgSetTeamFlooPointsMessage(this);
    }

    /// <summary>Field number for the "fortress_id" field.</summary>
    public const int FortressIdFieldNumber = 1;
    private string fortressId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FortressId {
      get { return fortressId_; }
      set {
        fortressId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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

    /// <summary>Field number for the "team_id" field.</summary>
    public const int TeamIdFieldNumber = 4;
    private string teamId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TeamId {
      get { return teamId_; }
      set {
        teamId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "floo_points" field.</summary>
    public const int FlooPointsFieldNumber = 5;
    private long flooPoints_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long FlooPoints {
      get { return flooPoints_; }
      set {
        flooPoints_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DbgSetTeamFlooPointsMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DbgSetTeamFlooPointsMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FortressId != other.FortressId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Latitude, other.Latitude)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Longitude, other.Longitude)) return false;
      if (TeamId != other.TeamId) return false;
      if (FlooPoints != other.FlooPoints) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FortressId.Length != 0) hash ^= FortressId.GetHashCode();
      if (Latitude != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Latitude);
      if (Longitude != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Longitude);
      if (TeamId.Length != 0) hash ^= TeamId.GetHashCode();
      if (FlooPoints != 0L) hash ^= FlooPoints.GetHashCode();
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
      if (FortressId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FortressId);
      }
      if (Latitude != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Latitude);
      }
      if (Longitude != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Longitude);
      }
      if (TeamId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(TeamId);
      }
      if (FlooPoints != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(FlooPoints);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FortressId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FortressId);
      }
      if (Latitude != 0D) {
        size += 1 + 8;
      }
      if (Longitude != 0D) {
        size += 1 + 8;
      }
      if (TeamId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TeamId);
      }
      if (FlooPoints != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(FlooPoints);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DbgSetTeamFlooPointsMessage other) {
      if (other == null) {
        return;
      }
      if (other.FortressId.Length != 0) {
        FortressId = other.FortressId;
      }
      if (other.Latitude != 0D) {
        Latitude = other.Latitude;
      }
      if (other.Longitude != 0D) {
        Longitude = other.Longitude;
      }
      if (other.TeamId.Length != 0) {
        TeamId = other.TeamId;
      }
      if (other.FlooPoints != 0L) {
        FlooPoints = other.FlooPoints;
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
            FortressId = input.ReadString();
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
            TeamId = input.ReadString();
            break;
          }
          case 40: {
            FlooPoints = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
