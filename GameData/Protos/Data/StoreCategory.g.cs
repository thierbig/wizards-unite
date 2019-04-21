// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/StoreCategory.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/StoreCategory.proto</summary>
  public static partial class StoreCategoryReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/StoreCategory.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StoreCategoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFXVVByb3Rvcy9EYXRhL1N0b3JlQ2F0ZWdvcnkucHJvdG8SDVdVUHJvdG9z",
            "LkRhdGEaGVdVUHJvdG9zL0RhdGEvQ29sb3IucHJvdG8ioAIKDVN0b3JlQ2F0",
            "ZWdvcnkSEQoJaWNvbl9wYXRoGAEgASgJEg0KBXRpdGxlGAIgASgJEg4KBmhl",
            "YWRlchgDIAEoCRIqCgxoZWFkZXJfY29sb3IYBCABKAsyFC5XVVByb3Rvcy5E",
            "YXRhLkNvbG9yEhIKCmJhY2tncm91bmQYBSABKAkSLgoQYmFja2dyb3VuZF9j",
            "b2xvchgGIAEoCzIULldVUHJvdG9zLkRhdGEuQ29sb3ISGwoTc3RvcmVfc3Vi",
            "Y2F0ZWdvcmllcxgHIAMoCRIVCg1oZWFkZXJfcHJlZmFiGAggASgJEigKCml0",
            "ZW1fY29sb3IYCSABKAsyFC5XVVByb3Rvcy5EYXRhLkNvbG9yEg8KB2VuYWJs",
            "ZWQYCiABKAhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.ColorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.StoreCategory), global::WUProtos.Data.StoreCategory.Parser, new[]{ "IconPath", "Title", "Header", "HeaderColor", "Background", "BackgroundColor", "StoreSubcategories", "HeaderPrefab", "ItemColor", "Enabled" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StoreCategory : pb::IMessage<StoreCategory> {
    private static readonly pb::MessageParser<StoreCategory> _parser = new pb::MessageParser<StoreCategory>(() => new StoreCategory());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StoreCategory> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.StoreCategoryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoreCategory() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoreCategory(StoreCategory other) : this() {
      iconPath_ = other.iconPath_;
      title_ = other.title_;
      header_ = other.header_;
      headerColor_ = other.headerColor_ != null ? other.headerColor_.Clone() : null;
      background_ = other.background_;
      backgroundColor_ = other.backgroundColor_ != null ? other.backgroundColor_.Clone() : null;
      storeSubcategories_ = other.storeSubcategories_.Clone();
      headerPrefab_ = other.headerPrefab_;
      itemColor_ = other.itemColor_ != null ? other.itemColor_.Clone() : null;
      enabled_ = other.enabled_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoreCategory Clone() {
      return new StoreCategory(this);
    }

    /// <summary>Field number for the "icon_path" field.</summary>
    public const int IconPathFieldNumber = 1;
    private string iconPath_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string IconPath {
      get { return iconPath_; }
      set {
        iconPath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 2;
    private string title_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 3;
    private string header_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Header {
      get { return header_; }
      set {
        header_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "header_color" field.</summary>
    public const int HeaderColorFieldNumber = 4;
    private global::WUProtos.Data.Color headerColor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Color HeaderColor {
      get { return headerColor_; }
      set {
        headerColor_ = value;
      }
    }

    /// <summary>Field number for the "background" field.</summary>
    public const int BackgroundFieldNumber = 5;
    private string background_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Background {
      get { return background_; }
      set {
        background_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "background_color" field.</summary>
    public const int BackgroundColorFieldNumber = 6;
    private global::WUProtos.Data.Color backgroundColor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Color BackgroundColor {
      get { return backgroundColor_; }
      set {
        backgroundColor_ = value;
      }
    }

    /// <summary>Field number for the "store_subcategories" field.</summary>
    public const int StoreSubcategoriesFieldNumber = 7;
    private static readonly pb::FieldCodec<string> _repeated_storeSubcategories_codec
        = pb::FieldCodec.ForString(58);
    private readonly pbc::RepeatedField<string> storeSubcategories_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> StoreSubcategories {
      get { return storeSubcategories_; }
    }

    /// <summary>Field number for the "header_prefab" field.</summary>
    public const int HeaderPrefabFieldNumber = 8;
    private string headerPrefab_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string HeaderPrefab {
      get { return headerPrefab_; }
      set {
        headerPrefab_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "item_color" field.</summary>
    public const int ItemColorFieldNumber = 9;
    private global::WUProtos.Data.Color itemColor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Color ItemColor {
      get { return itemColor_; }
      set {
        itemColor_ = value;
      }
    }

    /// <summary>Field number for the "enabled" field.</summary>
    public const int EnabledFieldNumber = 10;
    private bool enabled_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Enabled {
      get { return enabled_; }
      set {
        enabled_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StoreCategory);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StoreCategory other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IconPath != other.IconPath) return false;
      if (Title != other.Title) return false;
      if (Header != other.Header) return false;
      if (!object.Equals(HeaderColor, other.HeaderColor)) return false;
      if (Background != other.Background) return false;
      if (!object.Equals(BackgroundColor, other.BackgroundColor)) return false;
      if(!storeSubcategories_.Equals(other.storeSubcategories_)) return false;
      if (HeaderPrefab != other.HeaderPrefab) return false;
      if (!object.Equals(ItemColor, other.ItemColor)) return false;
      if (Enabled != other.Enabled) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IconPath.Length != 0) hash ^= IconPath.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (Header.Length != 0) hash ^= Header.GetHashCode();
      if (headerColor_ != null) hash ^= HeaderColor.GetHashCode();
      if (Background.Length != 0) hash ^= Background.GetHashCode();
      if (backgroundColor_ != null) hash ^= BackgroundColor.GetHashCode();
      hash ^= storeSubcategories_.GetHashCode();
      if (HeaderPrefab.Length != 0) hash ^= HeaderPrefab.GetHashCode();
      if (itemColor_ != null) hash ^= ItemColor.GetHashCode();
      if (Enabled != false) hash ^= Enabled.GetHashCode();
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
      if (IconPath.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(IconPath);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Title);
      }
      if (Header.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Header);
      }
      if (headerColor_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(HeaderColor);
      }
      if (Background.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Background);
      }
      if (backgroundColor_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(BackgroundColor);
      }
      storeSubcategories_.WriteTo(output, _repeated_storeSubcategories_codec);
      if (HeaderPrefab.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(HeaderPrefab);
      }
      if (itemColor_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(ItemColor);
      }
      if (Enabled != false) {
        output.WriteRawTag(80);
        output.WriteBool(Enabled);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IconPath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IconPath);
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (Header.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Header);
      }
      if (headerColor_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HeaderColor);
      }
      if (Background.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Background);
      }
      if (backgroundColor_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BackgroundColor);
      }
      size += storeSubcategories_.CalculateSize(_repeated_storeSubcategories_codec);
      if (HeaderPrefab.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HeaderPrefab);
      }
      if (itemColor_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ItemColor);
      }
      if (Enabled != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StoreCategory other) {
      if (other == null) {
        return;
      }
      if (other.IconPath.Length != 0) {
        IconPath = other.IconPath;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.Header.Length != 0) {
        Header = other.Header;
      }
      if (other.headerColor_ != null) {
        if (headerColor_ == null) {
          HeaderColor = new global::WUProtos.Data.Color();
        }
        HeaderColor.MergeFrom(other.HeaderColor);
      }
      if (other.Background.Length != 0) {
        Background = other.Background;
      }
      if (other.backgroundColor_ != null) {
        if (backgroundColor_ == null) {
          BackgroundColor = new global::WUProtos.Data.Color();
        }
        BackgroundColor.MergeFrom(other.BackgroundColor);
      }
      storeSubcategories_.Add(other.storeSubcategories_);
      if (other.HeaderPrefab.Length != 0) {
        HeaderPrefab = other.HeaderPrefab;
      }
      if (other.itemColor_ != null) {
        if (itemColor_ == null) {
          ItemColor = new global::WUProtos.Data.Color();
        }
        ItemColor.MergeFrom(other.ItemColor);
      }
      if (other.Enabled != false) {
        Enabled = other.Enabled;
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
            IconPath = input.ReadString();
            break;
          }
          case 18: {
            Title = input.ReadString();
            break;
          }
          case 26: {
            Header = input.ReadString();
            break;
          }
          case 34: {
            if (headerColor_ == null) {
              HeaderColor = new global::WUProtos.Data.Color();
            }
            input.ReadMessage(HeaderColor);
            break;
          }
          case 42: {
            Background = input.ReadString();
            break;
          }
          case 50: {
            if (backgroundColor_ == null) {
              BackgroundColor = new global::WUProtos.Data.Color();
            }
            input.ReadMessage(BackgroundColor);
            break;
          }
          case 58: {
            storeSubcategories_.AddEntriesFrom(input, _repeated_storeSubcategories_codec);
            break;
          }
          case 66: {
            HeaderPrefab = input.ReadString();
            break;
          }
          case 74: {
            if (itemColor_ == null) {
              ItemColor = new global::WUProtos.Data.Color();
            }
            input.ReadMessage(ItemColor);
            break;
          }
          case 80: {
            Enabled = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
