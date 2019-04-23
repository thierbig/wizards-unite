// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/WalkboxReward.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/WalkboxReward.proto</summary>
  public static partial class WalkboxRewardReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/WalkboxReward.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WalkboxRewardReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFXVVByb3Rvcy9EYXRhL1dhbGtib3hSZXdhcmQucHJvdG8SDVdVUHJvdG9z",
            "LkRhdGEiLAoNV2Fsa2JveFJld2FyZBIbChN3YWxrYm94X3RlbXBsYXRlX2lk",
            "GAEgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.WalkboxReward), global::WUProtos.Data.WalkboxReward.Parser, new[]{ "WalkboxTemplateId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WalkboxReward : pb::IMessage<WalkboxReward> {
    private static readonly pb::MessageParser<WalkboxReward> _parser = new pb::MessageParser<WalkboxReward>(() => new WalkboxReward());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WalkboxReward> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.WalkboxRewardReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WalkboxReward() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WalkboxReward(WalkboxReward other) : this() {
      walkboxTemplateId_ = other.walkboxTemplateId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WalkboxReward Clone() {
      return new WalkboxReward(this);
    }

    /// <summary>Field number for the "walkbox_template_id" field.</summary>
    public const int WalkboxTemplateIdFieldNumber = 1;
    private string walkboxTemplateId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string WalkboxTemplateId {
      get { return walkboxTemplateId_; }
      set {
        walkboxTemplateId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WalkboxReward);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WalkboxReward other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WalkboxTemplateId != other.WalkboxTemplateId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (WalkboxTemplateId.Length != 0) hash ^= WalkboxTemplateId.GetHashCode();
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
      if (WalkboxTemplateId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(WalkboxTemplateId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (WalkboxTemplateId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(WalkboxTemplateId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WalkboxReward other) {
      if (other == null) {
        return;
      }
      if (other.WalkboxTemplateId.Length != 0) {
        WalkboxTemplateId = other.WalkboxTemplateId;
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
            WalkboxTemplateId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code