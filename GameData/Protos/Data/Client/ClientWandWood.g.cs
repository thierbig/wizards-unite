// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Client/ClientWandWood.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Client {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Client/ClientWandWood.proto</summary>
  public static partial class ClientWandWoodReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Client/ClientWandWood.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientWandWoodReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilXVVByb3Rvcy9EYXRhL0NsaWVudC9DbGllbnRXYW5kV29vZC5wcm90bxIU",
            "V1VQcm90b3MuRGF0YS5DbGllbnQiYQoOQ2xpZW50V2FuZFdvb2QSDAoEbmFt",
            "ZRgBIAEoCRIQCghidG5faWNvbhgCIAEoCRIMCgRpY29uGAMgASgJEg8KB3Rl",
            "eHR1cmUYBCABKAkSEAoIbWF0ZXJpYWwYBSABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Client.ClientWandWood), global::WUProtos.Data.Client.ClientWandWood.Parser, new[]{ "Name", "BtnIcon", "Icon", "Texture", "Material" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientWandWood : pb::IMessage<ClientWandWood> {
    private static readonly pb::MessageParser<ClientWandWood> _parser = new pb::MessageParser<ClientWandWood>(() => new ClientWandWood());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientWandWood> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Client.ClientWandWoodReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientWandWood() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientWandWood(ClientWandWood other) : this() {
      name_ = other.name_;
      btnIcon_ = other.btnIcon_;
      icon_ = other.icon_;
      texture_ = other.texture_;
      material_ = other.material_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientWandWood Clone() {
      return new ClientWandWood(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "btn_icon" field.</summary>
    public const int BtnIconFieldNumber = 2;
    private string btnIcon_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BtnIcon {
      get { return btnIcon_; }
      set {
        btnIcon_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "icon" field.</summary>
    public const int IconFieldNumber = 3;
    private string icon_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Icon {
      get { return icon_; }
      set {
        icon_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "texture" field.</summary>
    public const int TextureFieldNumber = 4;
    private string texture_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Texture {
      get { return texture_; }
      set {
        texture_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "material" field.</summary>
    public const int MaterialFieldNumber = 5;
    private string material_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Material {
      get { return material_; }
      set {
        material_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientWandWood);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientWandWood other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (BtnIcon != other.BtnIcon) return false;
      if (Icon != other.Icon) return false;
      if (Texture != other.Texture) return false;
      if (Material != other.Material) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (BtnIcon.Length != 0) hash ^= BtnIcon.GetHashCode();
      if (Icon.Length != 0) hash ^= Icon.GetHashCode();
      if (Texture.Length != 0) hash ^= Texture.GetHashCode();
      if (Material.Length != 0) hash ^= Material.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (BtnIcon.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BtnIcon);
      }
      if (Icon.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Icon);
      }
      if (Texture.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Texture);
      }
      if (Material.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Material);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (BtnIcon.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BtnIcon);
      }
      if (Icon.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Icon);
      }
      if (Texture.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Texture);
      }
      if (Material.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Material);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientWandWood other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.BtnIcon.Length != 0) {
        BtnIcon = other.BtnIcon;
      }
      if (other.Icon.Length != 0) {
        Icon = other.Icon;
      }
      if (other.Texture.Length != 0) {
        Texture = other.Texture;
      }
      if (other.Material.Length != 0) {
        Material = other.Material;
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            BtnIcon = input.ReadString();
            break;
          }
          case 26: {
            Icon = input.ReadString();
            break;
          }
          case 34: {
            Texture = input.ReadString();
            break;
          }
          case 42: {
            Material = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
