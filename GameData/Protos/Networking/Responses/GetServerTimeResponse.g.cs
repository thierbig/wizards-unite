// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/GetServerTimeResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/GetServerTimeResponse.proto</summary>
  public static partial class GetServerTimeResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/GetServerTimeResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetServerTimeResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjlXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9HZXRTZXJ2ZXJUaW1l",
            "UmVzcG9uc2UucHJvdG8SHVdVUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2Vz",
            "IlIKFUdldFNlcnZlclRpbWVSZXNwb25zZRIWCg5zZXJ2ZXJfdGltZV9tcxgB",
            "IAEoAxIhChl0aW1lX3VudGlsX2RhaWx5X3JvbGxvdmVyGAIgASgEYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.GetServerTimeResponse), global::WUProtos.Networking.Responses.GetServerTimeResponse.Parser, new[]{ "ServerTimeMs", "TimeUntilDailyRollover" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetServerTimeResponse : pb::IMessage<GetServerTimeResponse> {
    private static readonly pb::MessageParser<GetServerTimeResponse> _parser = new pb::MessageParser<GetServerTimeResponse>(() => new GetServerTimeResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetServerTimeResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.GetServerTimeResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetServerTimeResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetServerTimeResponse(GetServerTimeResponse other) : this() {
      serverTimeMs_ = other.serverTimeMs_;
      timeUntilDailyRollover_ = other.timeUntilDailyRollover_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetServerTimeResponse Clone() {
      return new GetServerTimeResponse(this);
    }

    /// <summary>Field number for the "server_time_ms" field.</summary>
    public const int ServerTimeMsFieldNumber = 1;
    private long serverTimeMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ServerTimeMs {
      get { return serverTimeMs_; }
      set {
        serverTimeMs_ = value;
      }
    }

    /// <summary>Field number for the "time_until_daily_rollover" field.</summary>
    public const int TimeUntilDailyRolloverFieldNumber = 2;
    private ulong timeUntilDailyRollover_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong TimeUntilDailyRollover {
      get { return timeUntilDailyRollover_; }
      set {
        timeUntilDailyRollover_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetServerTimeResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetServerTimeResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServerTimeMs != other.ServerTimeMs) return false;
      if (TimeUntilDailyRollover != other.TimeUntilDailyRollover) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ServerTimeMs != 0L) hash ^= ServerTimeMs.GetHashCode();
      if (TimeUntilDailyRollover != 0UL) hash ^= TimeUntilDailyRollover.GetHashCode();
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
      if (ServerTimeMs != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ServerTimeMs);
      }
      if (TimeUntilDailyRollover != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(TimeUntilDailyRollover);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ServerTimeMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ServerTimeMs);
      }
      if (TimeUntilDailyRollover != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TimeUntilDailyRollover);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetServerTimeResponse other) {
      if (other == null) {
        return;
      }
      if (other.ServerTimeMs != 0L) {
        ServerTimeMs = other.ServerTimeMs;
      }
      if (other.TimeUntilDailyRollover != 0UL) {
        TimeUntilDailyRollover = other.TimeUntilDailyRollover;
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
            ServerTimeMs = input.ReadInt64();
            break;
          }
          case 16: {
            TimeUntilDailyRollover = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code