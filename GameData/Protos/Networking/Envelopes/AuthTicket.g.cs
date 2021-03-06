// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Envelopes/AuthTicket.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Envelopes {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Envelopes/AuthTicket.proto</summary>
  public static partial class AuthTicketReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Envelopes/AuthTicket.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AuthTicketReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5XVVByb3Rvcy9OZXR3b3JraW5nL0VudmVsb3Blcy9BdXRoVGlja2V0LnBy",
            "b3RvEh1XVVByb3Rvcy5OZXR3b3JraW5nLkVudmVsb3BlcyJFCgpBdXRoVGlj",
            "a2V0Eg0KBXN0YXJ0GAEgASgMEhsKE2V4cGlyZV90aW1lc3RhbXBfbXMYAiAB",
            "KAQSCwoDZW5kGAMgASgMYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Envelopes.AuthTicket), global::WUProtos.Networking.Envelopes.AuthTicket.Parser, new[]{ "Start", "ExpireTimestampMs", "End" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AuthTicket : pb::IMessage<AuthTicket> {
    private static readonly pb::MessageParser<AuthTicket> _parser = new pb::MessageParser<AuthTicket>(() => new AuthTicket());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AuthTicket> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Envelopes.AuthTicketReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthTicket() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthTicket(AuthTicket other) : this() {
      start_ = other.start_;
      expireTimestampMs_ = other.expireTimestampMs_;
      end_ = other.end_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthTicket Clone() {
      return new AuthTicket(this);
    }

    /// <summary>Field number for the "start" field.</summary>
    public const int StartFieldNumber = 1;
    private pb::ByteString start_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Start {
      get { return start_; }
      set {
        start_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "expire_timestamp_ms" field.</summary>
    public const int ExpireTimestampMsFieldNumber = 2;
    private ulong expireTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong ExpireTimestampMs {
      get { return expireTimestampMs_; }
      set {
        expireTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "end" field.</summary>
    public const int EndFieldNumber = 3;
    private pb::ByteString end_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString End {
      get { return end_; }
      set {
        end_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AuthTicket);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AuthTicket other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Start != other.Start) return false;
      if (ExpireTimestampMs != other.ExpireTimestampMs) return false;
      if (End != other.End) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Start.Length != 0) hash ^= Start.GetHashCode();
      if (ExpireTimestampMs != 0UL) hash ^= ExpireTimestampMs.GetHashCode();
      if (End.Length != 0) hash ^= End.GetHashCode();
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
      if (Start.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Start);
      }
      if (ExpireTimestampMs != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(ExpireTimestampMs);
      }
      if (End.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(End);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Start.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Start);
      }
      if (ExpireTimestampMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ExpireTimestampMs);
      }
      if (End.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(End);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AuthTicket other) {
      if (other == null) {
        return;
      }
      if (other.Start.Length != 0) {
        Start = other.Start;
      }
      if (other.ExpireTimestampMs != 0UL) {
        ExpireTimestampMs = other.ExpireTimestampMs;
      }
      if (other.End.Length != 0) {
        End = other.End;
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
            Start = input.ReadBytes();
            break;
          }
          case 16: {
            ExpireTimestampMs = input.ReadUInt64();
            break;
          }
          case 26: {
            End = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
