// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientTelemetryHyperlinkClickthrough.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientTelemetryHyperlinkClickthrough.proto</summary>
  public static partial class ClientTelemetryHyperlinkClickthroughReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientTelemetryHyperlinkClickthrough.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientTelemetryHyperlinkClickthroughReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9XVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRUZWxlbWV0cnlIeXBlcmxp",
            "bmtDbGlja3Rocm91Z2gucHJvdG8SFFdVUHJvdG9zLkRhdGEuQ2xpZW50IlsK",
            "JENsaWVudFRlbGVtZXRyeUh5cGVybGlua0NsaWNrdGhyb3VnaBILCgN1cmwY",
            "ASABKAkSEgoKb3V0cG9zdF9pZBgCIAEoCRISCgpwYXJ0bmVyX2lkGAMgASgJ",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientTelemetryHyperlinkClickthrough), global::WUProtos.Data.Client.ClientTelemetryHyperlinkClickthrough.Parser, new[]{ "Url", "OutpostId", "PartnerId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientTelemetryHyperlinkClickthrough : pb::IMessage<ClientTelemetryHyperlinkClickthrough> {
    private static readonly pb::MessageParser<ClientTelemetryHyperlinkClickthrough> _parser = new pb::MessageParser<ClientTelemetryHyperlinkClickthrough>(() => new ClientTelemetryHyperlinkClickthrough());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientTelemetryHyperlinkClickthrough> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientTelemetryHyperlinkClickthroughReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryHyperlinkClickthrough() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryHyperlinkClickthrough(ClientTelemetryHyperlinkClickthrough other) : this() {
      url_ = other.url_;
      outpostId_ = other.outpostId_;
      partnerId_ = other.partnerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryHyperlinkClickthrough Clone() {
      return new ClientTelemetryHyperlinkClickthrough(this);
    }

    /// <summary>Field number for the "url" field.</summary>
    public const int UrlFieldNumber = 1;
    private string url_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Url {
      get { return url_; }
      set {
        url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "outpost_id" field.</summary>
    public const int OutpostIdFieldNumber = 2;
    private string outpostId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OutpostId {
      get { return outpostId_; }
      set {
        outpostId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "partner_id" field.</summary>
    public const int PartnerIdFieldNumber = 3;
    private string partnerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PartnerId {
      get { return partnerId_; }
      set {
        partnerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientTelemetryHyperlinkClickthrough);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientTelemetryHyperlinkClickthrough other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Url != other.Url) return false;
      if (OutpostId != other.OutpostId) return false;
      if (PartnerId != other.PartnerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Url.Length != 0) hash ^= Url.GetHashCode();
      if (OutpostId.Length != 0) hash ^= OutpostId.GetHashCode();
      if (PartnerId.Length != 0) hash ^= PartnerId.GetHashCode();
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
      if (Url.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Url);
      }
      if (OutpostId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(OutpostId);
      }
      if (PartnerId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PartnerId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Url.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
      }
      if (OutpostId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OutpostId);
      }
      if (PartnerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PartnerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientTelemetryHyperlinkClickthrough other) {
      if (other == null) {
        return;
      }
      if (other.Url.Length != 0) {
        Url = other.Url;
      }
      if (other.OutpostId.Length != 0) {
        OutpostId = other.OutpostId;
      }
      if (other.PartnerId.Length != 0) {
        PartnerId = other.PartnerId;
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
            Url = input.ReadString();
            break;
          }
          case 18: {
            OutpostId = input.ReadString();
            break;
          }
          case 26: {
            PartnerId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
