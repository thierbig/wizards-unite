// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientTeamControl.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientTeamControl.proto</summary>
  public static partial class ClientTeamControlReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientTeamControl.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientTeamControlReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRUZWFtQ29udHJvbC5wcm90",
            "bxIUV1VQcm90b3MuRGF0YS5DbGllbnQaGVdVUHJvdG9zL0RhdGEvQ29sb3Iu",
            "cHJvdG8isQEKEUNsaWVudFRlYW1Db250cm9sEgoKAmlkGAEgASgJEhEKCXRl",
            "YW1fbmFtZRgCIAEoCRIRCgl0ZWFtX2ljb24YAyABKAkSKAoKdGVhbV9jb2xv",
            "chgEIAEoCzIULldVUHJvdG9zLkRhdGEuQ29sb3ISGAoQdGVhbV9oZWFkZXJf",
            "aWNvbhgFIAEoCRITCgt0ZWFtX2Jhbm5lchgGIAEoCRIRCgl0ZWFtX2ZsYWcY",
            "ByABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.ColorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientTeamControl), global::WUProtos.Data.Client.ClientTeamControl.Parser, new[]{ "Id", "TeamName", "TeamIcon", "TeamColor", "TeamHeaderIcon", "TeamBanner", "TeamFlag" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientTeamControl : pb::IMessage<ClientTeamControl> {
    private static readonly pb::MessageParser<ClientTeamControl> _parser = new pb::MessageParser<ClientTeamControl>(() => new ClientTeamControl());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientTeamControl> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientTeamControlReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTeamControl() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTeamControl(ClientTeamControl other) : this() {
      id_ = other.id_;
      teamName_ = other.teamName_;
      teamIcon_ = other.teamIcon_;
      teamColor_ = other.teamColor_ != null ? other.teamColor_.Clone() : null;
      teamHeaderIcon_ = other.teamHeaderIcon_;
      teamBanner_ = other.teamBanner_;
      teamFlag_ = other.teamFlag_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTeamControl Clone() {
      return new ClientTeamControl(this);
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

    /// <summary>Field number for the "team_name" field.</summary>
    public const int TeamNameFieldNumber = 2;
    private string teamName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TeamName {
      get { return teamName_; }
      set {
        teamName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "team_icon" field.</summary>
    public const int TeamIconFieldNumber = 3;
    private string teamIcon_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TeamIcon {
      get { return teamIcon_; }
      set {
        teamIcon_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "team_color" field.</summary>
    public const int TeamColorFieldNumber = 4;
    private global::WUProtos.Data.Color teamColor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Color TeamColor {
      get { return teamColor_; }
      set {
        teamColor_ = value;
      }
    }

    /// <summary>Field number for the "team_header_icon" field.</summary>
    public const int TeamHeaderIconFieldNumber = 5;
    private string teamHeaderIcon_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TeamHeaderIcon {
      get { return teamHeaderIcon_; }
      set {
        teamHeaderIcon_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "team_banner" field.</summary>
    public const int TeamBannerFieldNumber = 6;
    private string teamBanner_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TeamBanner {
      get { return teamBanner_; }
      set {
        teamBanner_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "team_flag" field.</summary>
    public const int TeamFlagFieldNumber = 7;
    private string teamFlag_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TeamFlag {
      get { return teamFlag_; }
      set {
        teamFlag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientTeamControl);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientTeamControl other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (TeamName != other.TeamName) return false;
      if (TeamIcon != other.TeamIcon) return false;
      if (!object.Equals(TeamColor, other.TeamColor)) return false;
      if (TeamHeaderIcon != other.TeamHeaderIcon) return false;
      if (TeamBanner != other.TeamBanner) return false;
      if (TeamFlag != other.TeamFlag) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (TeamName.Length != 0) hash ^= TeamName.GetHashCode();
      if (TeamIcon.Length != 0) hash ^= TeamIcon.GetHashCode();
      if (teamColor_ != null) hash ^= TeamColor.GetHashCode();
      if (TeamHeaderIcon.Length != 0) hash ^= TeamHeaderIcon.GetHashCode();
      if (TeamBanner.Length != 0) hash ^= TeamBanner.GetHashCode();
      if (TeamFlag.Length != 0) hash ^= TeamFlag.GetHashCode();
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
      if (TeamName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TeamName);
      }
      if (TeamIcon.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(TeamIcon);
      }
      if (teamColor_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(TeamColor);
      }
      if (TeamHeaderIcon.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(TeamHeaderIcon);
      }
      if (TeamBanner.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(TeamBanner);
      }
      if (TeamFlag.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(TeamFlag);
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
      if (TeamName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TeamName);
      }
      if (TeamIcon.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TeamIcon);
      }
      if (teamColor_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TeamColor);
      }
      if (TeamHeaderIcon.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TeamHeaderIcon);
      }
      if (TeamBanner.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TeamBanner);
      }
      if (TeamFlag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TeamFlag);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientTeamControl other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.TeamName.Length != 0) {
        TeamName = other.TeamName;
      }
      if (other.TeamIcon.Length != 0) {
        TeamIcon = other.TeamIcon;
      }
      if (other.teamColor_ != null) {
        if (teamColor_ == null) {
          TeamColor = new global::WUProtos.Data.Color();
        }
        TeamColor.MergeFrom(other.TeamColor);
      }
      if (other.TeamHeaderIcon.Length != 0) {
        TeamHeaderIcon = other.TeamHeaderIcon;
      }
      if (other.TeamBanner.Length != 0) {
        TeamBanner = other.TeamBanner;
      }
      if (other.TeamFlag.Length != 0) {
        TeamFlag = other.TeamFlag;
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
            TeamName = input.ReadString();
            break;
          }
          case 26: {
            TeamIcon = input.ReadString();
            break;
          }
          case 34: {
            if (teamColor_ == null) {
              TeamColor = new global::WUProtos.Data.Color();
            }
            input.ReadMessage(TeamColor);
            break;
          }
          case 42: {
            TeamHeaderIcon = input.ReadString();
            break;
          }
          case 50: {
            TeamBanner = input.ReadString();
            break;
          }
          case 58: {
            TeamFlag = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
