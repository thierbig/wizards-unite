// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/PlayerSelectTeamResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/PlayerSelectTeamResponse.proto</summary>
  public static partial class PlayerSelectTeamResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/PlayerSelectTeamResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerSelectTeamResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9QbGF5ZXJTZWxlY3RU",
            "ZWFtUmVzcG9uc2UucHJvdG8SHVdVUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9u",
            "c2VzIsEBChhQbGF5ZXJTZWxlY3RUZWFtUmVzcG9uc2USTgoGcmVzdWx0GAEg",
            "ASgOMj4uV1VQcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuUGxheWVyU2Vs",
            "ZWN0VGVhbVJlc3BvbnNlLlJlc3VsdCJVCgZSZXN1bHQSCwoHVU5LTk9XThAA",
            "EgwKCFRFQU1fU0VUEAESEwoPVEVBTV9JRF9JTlZBTElEEAISGwoXUExBWUVS",
            "X0FMUkVBRFlfSEFTX1RFQU0QA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.PlayerSelectTeamResponse), global::WUProtos.Networking.Responses.PlayerSelectTeamResponse.Parser, new[]{ "Result" }, null, new[]{ typeof(global::WUProtos.Networking.Responses.PlayerSelectTeamResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerSelectTeamResponse : pb::IMessage<PlayerSelectTeamResponse> {
    private static readonly pb::MessageParser<PlayerSelectTeamResponse> _parser = new pb::MessageParser<PlayerSelectTeamResponse>(() => new PlayerSelectTeamResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayerSelectTeamResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.PlayerSelectTeamResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerSelectTeamResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerSelectTeamResponse(PlayerSelectTeamResponse other) : this() {
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerSelectTeamResponse Clone() {
      return new PlayerSelectTeamResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::WUProtos.Networking.Responses.PlayerSelectTeamResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Responses.PlayerSelectTeamResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayerSelectTeamResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayerSelectTeamResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
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
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayerSelectTeamResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
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
            Result = (global::WUProtos.Networking.Responses.PlayerSelectTeamResponse.Types.Result) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the PlayerSelectTeamResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("TEAM_SET")] TeamSet = 1,
        [pbr::OriginalName("TEAM_ID_INVALID")] TeamIdInvalid = 2,
        [pbr::OriginalName("PLAYER_ALREADY_HAS_TEAM")] PlayerAlreadyHasTeam = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code