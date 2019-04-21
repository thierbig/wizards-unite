// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientCollectionPage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientCollectionPage.proto</summary>
  public static partial class ClientCollectionPageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientCollectionPage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientCollectionPageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9XVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRDb2xsZWN0aW9uUGFnZS5w",
            "cm90bxIUV1VQcm90b3MuRGF0YS5DbGllbnQiagoUQ2xpZW50Q29sbGVjdGlv",
            "blBhZ2USCgoCaWQYASABKAkSDAoEbmFtZRgCIAEoCRITCgtwYWdlX3ByZWZh",
            "YhgDIAEoCRIPCgdpY29uX2JnGAQgASgJEhIKCnNob3dfaW5fdWkYBSABKAhi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientCollectionPage), global::WUProtos.Data.Client.ClientCollectionPage.Parser, new[]{ "Id", "Name", "PagePrefab", "IconBg", "ShowInUi" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientCollectionPage : pb::IMessage<ClientCollectionPage> {
    private static readonly pb::MessageParser<ClientCollectionPage> _parser = new pb::MessageParser<ClientCollectionPage>(() => new ClientCollectionPage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientCollectionPage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientCollectionPageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientCollectionPage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientCollectionPage(ClientCollectionPage other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      pagePrefab_ = other.pagePrefab_;
      iconBg_ = other.iconBg_;
      showInUi_ = other.showInUi_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientCollectionPage Clone() {
      return new ClientCollectionPage(this);
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

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page_prefab" field.</summary>
    public const int PagePrefabFieldNumber = 3;
    private string pagePrefab_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PagePrefab {
      get { return pagePrefab_; }
      set {
        pagePrefab_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "icon_bg" field.</summary>
    public const int IconBgFieldNumber = 4;
    private string iconBg_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string IconBg {
      get { return iconBg_; }
      set {
        iconBg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "show_in_ui" field.</summary>
    public const int ShowInUiFieldNumber = 5;
    private bool showInUi_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ShowInUi {
      get { return showInUi_; }
      set {
        showInUi_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientCollectionPage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientCollectionPage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (PagePrefab != other.PagePrefab) return false;
      if (IconBg != other.IconBg) return false;
      if (ShowInUi != other.ShowInUi) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (PagePrefab.Length != 0) hash ^= PagePrefab.GetHashCode();
      if (IconBg.Length != 0) hash ^= IconBg.GetHashCode();
      if (ShowInUi != false) hash ^= ShowInUi.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (PagePrefab.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PagePrefab);
      }
      if (IconBg.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(IconBg);
      }
      if (ShowInUi != false) {
        output.WriteRawTag(40);
        output.WriteBool(ShowInUi);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (PagePrefab.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PagePrefab);
      }
      if (IconBg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IconBg);
      }
      if (ShowInUi != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientCollectionPage other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.PagePrefab.Length != 0) {
        PagePrefab = other.PagePrefab;
      }
      if (other.IconBg.Length != 0) {
        IconBg = other.IconBg;
      }
      if (other.ShowInUi != false) {
        ShowInUi = other.ShowInUi;
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
            Name = input.ReadString();
            break;
          }
          case 26: {
            PagePrefab = input.ReadString();
            break;
          }
          case 34: {
            IconBg = input.ReadString();
            break;
          }
          case 40: {
            ShowInUi = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
