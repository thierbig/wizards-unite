// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/ContainerVaultItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/ContainerVaultItem.proto</summary>
  public static partial class ContainerVaultItemReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/ContainerVaultItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ContainerVaultItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZXVVByb3Rvcy9EYXRhL0NvbnRhaW5lclZhdWx0SXRlbS5wcm90bxINV1VQ",
            "cm90b3MuRGF0YRonV1VQcm90b3MvRGF0YS9Mb290L0xvb3RDb2xsZWN0aW9u",
            "LnByb3RvImAKEkNvbnRhaW5lclZhdWx0SXRlbRI0Cghjb250ZW50cxgBIAEo",
            "CzIiLldVUHJvdG9zLkRhdGEuTG9vdC5Mb290Q29sbGVjdGlvbhIUCgxhdXRv",
            "X2NvbnN1bWUYAiABKAhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Loot.LootCollectionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.ContainerVaultItem), global::WUProtos.Data.ContainerVaultItem.Parser, new[]{ "Contents", "AutoConsume" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ContainerVaultItem : pb::IMessage<ContainerVaultItem> {
    private static readonly pb::MessageParser<ContainerVaultItem> _parser = new pb::MessageParser<ContainerVaultItem>(() => new ContainerVaultItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ContainerVaultItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.ContainerVaultItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContainerVaultItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContainerVaultItem(ContainerVaultItem other) : this() {
      contents_ = other.contents_ != null ? other.contents_.Clone() : null;
      autoConsume_ = other.autoConsume_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContainerVaultItem Clone() {
      return new ContainerVaultItem(this);
    }

    /// <summary>Field number for the "contents" field.</summary>
    public const int ContentsFieldNumber = 1;
    private global::WUProtos.Data.Loot.LootCollection contents_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Loot.LootCollection Contents {
      get { return contents_; }
      set {
        contents_ = value;
      }
    }

    /// <summary>Field number for the "auto_consume" field.</summary>
    public const int AutoConsumeFieldNumber = 2;
    private bool autoConsume_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool AutoConsume {
      get { return autoConsume_; }
      set {
        autoConsume_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ContainerVaultItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ContainerVaultItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Contents, other.Contents)) return false;
      if (AutoConsume != other.AutoConsume) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (contents_ != null) hash ^= Contents.GetHashCode();
      if (AutoConsume != false) hash ^= AutoConsume.GetHashCode();
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
      if (contents_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Contents);
      }
      if (AutoConsume != false) {
        output.WriteRawTag(16);
        output.WriteBool(AutoConsume);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (contents_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Contents);
      }
      if (AutoConsume != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ContainerVaultItem other) {
      if (other == null) {
        return;
      }
      if (other.contents_ != null) {
        if (contents_ == null) {
          Contents = new global::WUProtos.Data.Loot.LootCollection();
        }
        Contents.MergeFrom(other.Contents);
      }
      if (other.AutoConsume != false) {
        AutoConsume = other.AutoConsume;
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
            if (contents_ == null) {
              Contents = new global::WUProtos.Data.Loot.LootCollection();
            }
            input.ReadMessage(Contents);
            break;
          }
          case 16: {
            AutoConsume = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
