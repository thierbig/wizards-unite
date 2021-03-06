// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/SelfieAvatarAsset.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/SelfieAvatarAsset.proto</summary>
  public static partial class SelfieAvatarAssetReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/SelfieAvatarAsset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SelfieAvatarAssetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVXVVByb3Rvcy9EYXRhL1NlbGZpZUF2YXRhckFzc2V0LnByb3RvEg1XVVBy",
            "b3Rvcy5EYXRhGiBXVVByb3Rvcy9EYXRhL1JlcXVpcmVtZW50cy5wcm90byJX",
            "ChFTZWxmaWVBdmF0YXJBc3NldBIKCgJpZBgBIAEoCRI2ChF1bmxvY2tfY29u",
            "ZGl0aW9ucxgCIAEoCzIbLldVUHJvdG9zLkRhdGEuUmVxdWlyZW1lbnRzYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.RequirementsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.SelfieAvatarAsset), global::WUProtos.Data.SelfieAvatarAsset.Parser, new[]{ "Id", "UnlockConditions" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SelfieAvatarAsset : pb::IMessage<SelfieAvatarAsset> {
    private static readonly pb::MessageParser<SelfieAvatarAsset> _parser = new pb::MessageParser<SelfieAvatarAsset>(() => new SelfieAvatarAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SelfieAvatarAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.SelfieAvatarAssetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SelfieAvatarAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SelfieAvatarAsset(SelfieAvatarAsset other) : this() {
      id_ = other.id_;
      unlockConditions_ = other.unlockConditions_ != null ? other.unlockConditions_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SelfieAvatarAsset Clone() {
      return new SelfieAvatarAsset(this);
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

    /// <summary>Field number for the "unlock_conditions" field.</summary>
    public const int UnlockConditionsFieldNumber = 2;
    private global::WUProtos.Data.Requirements unlockConditions_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Requirements UnlockConditions {
      get { return unlockConditions_; }
      set {
        unlockConditions_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SelfieAvatarAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SelfieAvatarAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(UnlockConditions, other.UnlockConditions)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (unlockConditions_ != null) hash ^= UnlockConditions.GetHashCode();
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
      if (unlockConditions_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UnlockConditions);
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
      if (unlockConditions_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UnlockConditions);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SelfieAvatarAsset other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.unlockConditions_ != null) {
        if (unlockConditions_ == null) {
          UnlockConditions = new global::WUProtos.Data.Requirements();
        }
        UnlockConditions.MergeFrom(other.UnlockConditions);
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
            if (unlockConditions_ == null) {
              UnlockConditions = new global::WUProtos.Data.Requirements();
            }
            input.ReadMessage(UnlockConditions);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
