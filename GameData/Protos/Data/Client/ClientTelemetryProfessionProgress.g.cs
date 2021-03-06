// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientTelemetryProfessionProgress.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientTelemetryProfessionProgress.proto</summary>
  public static partial class ClientTelemetryProfessionProgressReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientTelemetryProfessionProgress.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientTelemetryProfessionProgressReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRUZWxlbWV0cnlQcm9mZXNz",
            "aW9uUHJvZ3Jlc3MucHJvdG8SFFdVUHJvdG9zLkRhdGEuQ2xpZW50IlMKIUNs",
            "aWVudFRlbGVtZXRyeVByb2Zlc3Npb25Qcm9ncmVzcxIZChFwcm9mZXNzaW9u",
            "X2dtdF9pZBgBIAEoCRITCgtyYW5rX3BvaW50cxgCIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientTelemetryProfessionProgress), global::WUProtos.Data.Client.ClientTelemetryProfessionProgress.Parser, new[]{ "ProfessionGmtId", "RankPoints" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientTelemetryProfessionProgress : pb::IMessage<ClientTelemetryProfessionProgress> {
    private static readonly pb::MessageParser<ClientTelemetryProfessionProgress> _parser = new pb::MessageParser<ClientTelemetryProfessionProgress>(() => new ClientTelemetryProfessionProgress());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientTelemetryProfessionProgress> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientTelemetryProfessionProgressReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryProfessionProgress() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryProfessionProgress(ClientTelemetryProfessionProgress other) : this() {
      professionGmtId_ = other.professionGmtId_;
      rankPoints_ = other.rankPoints_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryProfessionProgress Clone() {
      return new ClientTelemetryProfessionProgress(this);
    }

    /// <summary>Field number for the "profession_gmt_id" field.</summary>
    public const int ProfessionGmtIdFieldNumber = 1;
    private string professionGmtId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProfessionGmtId {
      get { return professionGmtId_; }
      set {
        professionGmtId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "rank_points" field.</summary>
    public const int RankPointsFieldNumber = 2;
    private uint rankPoints_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint RankPoints {
      get { return rankPoints_; }
      set {
        rankPoints_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientTelemetryProfessionProgress);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientTelemetryProfessionProgress other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProfessionGmtId != other.ProfessionGmtId) return false;
      if (RankPoints != other.RankPoints) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ProfessionGmtId.Length != 0) hash ^= ProfessionGmtId.GetHashCode();
      if (RankPoints != 0) hash ^= RankPoints.GetHashCode();
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
      if (ProfessionGmtId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProfessionGmtId);
      }
      if (RankPoints != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(RankPoints);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ProfessionGmtId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProfessionGmtId);
      }
      if (RankPoints != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RankPoints);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientTelemetryProfessionProgress other) {
      if (other == null) {
        return;
      }
      if (other.ProfessionGmtId.Length != 0) {
        ProfessionGmtId = other.ProfessionGmtId;
      }
      if (other.RankPoints != 0) {
        RankPoints = other.RankPoints;
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
            ProfessionGmtId = input.ReadString();
            break;
          }
          case 16: {
            RankPoints = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
