// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/PermissionsConfigStaticData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/PermissionsConfigStaticData.proto</summary>
  public static partial class PermissionsConfigStaticDataReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/PermissionsConfigStaticData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PermissionsConfigStaticDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9XVVByb3Rvcy9EYXRhL1Blcm1pc3Npb25zQ29uZmlnU3RhdGljRGF0YS5w",
            "cm90bxINV1VQcm90b3MuRGF0YSKSAQobUGVybWlzc2lvbnNDb25maWdTdGF0",
            "aWNEYXRhEgoKAmlkGAEgASgJEhYKDmluaXRpYWxfcHJvbXB0GAIgASgJEhUK",
            "DWRlbmlhbF9wcm9tcHQYAyABKAkSEAoIb3B0aW9uYWwYBCABKAgSDQoFdGl0",
            "bGUYBSABKAkSFwoPYmVnZ2luZ19lbmFibGVkGAYgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.PermissionsConfigStaticData), global::WUProtos.Data.PermissionsConfigStaticData.Parser, new[]{ "Id", "InitialPrompt", "DenialPrompt", "Optional", "Title", "BeggingEnabled" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PermissionsConfigStaticData : pb::IMessage<PermissionsConfigStaticData> {
    private static readonly pb::MessageParser<PermissionsConfigStaticData> _parser = new pb::MessageParser<PermissionsConfigStaticData>(() => new PermissionsConfigStaticData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PermissionsConfigStaticData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.PermissionsConfigStaticDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PermissionsConfigStaticData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PermissionsConfigStaticData(PermissionsConfigStaticData other) : this() {
      id_ = other.id_;
      initialPrompt_ = other.initialPrompt_;
      denialPrompt_ = other.denialPrompt_;
      optional_ = other.optional_;
      title_ = other.title_;
      beggingEnabled_ = other.beggingEnabled_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PermissionsConfigStaticData Clone() {
      return new PermissionsConfigStaticData(this);
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

    /// <summary>Field number for the "initial_prompt" field.</summary>
    public const int InitialPromptFieldNumber = 2;
    private string initialPrompt_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InitialPrompt {
      get { return initialPrompt_; }
      set {
        initialPrompt_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "denial_prompt" field.</summary>
    public const int DenialPromptFieldNumber = 3;
    private string denialPrompt_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DenialPrompt {
      get { return denialPrompt_; }
      set {
        denialPrompt_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "optional" field.</summary>
    public const int OptionalFieldNumber = 4;
    private bool optional_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Optional {
      get { return optional_; }
      set {
        optional_ = value;
      }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 5;
    private string title_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "begging_enabled" field.</summary>
    public const int BeggingEnabledFieldNumber = 6;
    private bool beggingEnabled_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool BeggingEnabled {
      get { return beggingEnabled_; }
      set {
        beggingEnabled_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PermissionsConfigStaticData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PermissionsConfigStaticData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (InitialPrompt != other.InitialPrompt) return false;
      if (DenialPrompt != other.DenialPrompt) return false;
      if (Optional != other.Optional) return false;
      if (Title != other.Title) return false;
      if (BeggingEnabled != other.BeggingEnabled) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (InitialPrompt.Length != 0) hash ^= InitialPrompt.GetHashCode();
      if (DenialPrompt.Length != 0) hash ^= DenialPrompt.GetHashCode();
      if (Optional != false) hash ^= Optional.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (BeggingEnabled != false) hash ^= BeggingEnabled.GetHashCode();
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
      if (InitialPrompt.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(InitialPrompt);
      }
      if (DenialPrompt.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DenialPrompt);
      }
      if (Optional != false) {
        output.WriteRawTag(32);
        output.WriteBool(Optional);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Title);
      }
      if (BeggingEnabled != false) {
        output.WriteRawTag(48);
        output.WriteBool(BeggingEnabled);
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
      if (InitialPrompt.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InitialPrompt);
      }
      if (DenialPrompt.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DenialPrompt);
      }
      if (Optional != false) {
        size += 1 + 1;
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (BeggingEnabled != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PermissionsConfigStaticData other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.InitialPrompt.Length != 0) {
        InitialPrompt = other.InitialPrompt;
      }
      if (other.DenialPrompt.Length != 0) {
        DenialPrompt = other.DenialPrompt;
      }
      if (other.Optional != false) {
        Optional = other.Optional;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.BeggingEnabled != false) {
        BeggingEnabled = other.BeggingEnabled;
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
            InitialPrompt = input.ReadString();
            break;
          }
          case 26: {
            DenialPrompt = input.ReadString();
            break;
          }
          case 32: {
            Optional = input.ReadBool();
            break;
          }
          case 42: {
            Title = input.ReadString();
            break;
          }
          case 48: {
            BeggingEnabled = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
