// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Map/MapIngredient.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Map {

  /// <summary>Holder for reflection information generated from WUProtos/Map/MapIngredient.proto</summary>
  public static partial class MapIngredientReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Map/MapIngredient.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapIngredientReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBXVVByb3Rvcy9NYXAvTWFwSW5ncmVkaWVudC5wcm90bxIMV1VQcm90b3Mu",
            "TWFwGidXVVByb3Rvcy9EYXRhL0xvb3QvTG9vdENvbGxlY3Rpb24ucHJvdG8i",
            "fwoNTWFwSW5ncmVkaWVudBIKCgJpZBgBIAEoCRIwCgRsb290GAIgASgLMiIu",
            "V1VQcm90b3MuRGF0YS5Mb290Lkxvb3RDb2xsZWN0aW9uEjAKBGNvc3QYAyAB",
            "KAsyIi5XVVByb3Rvcy5EYXRhLkxvb3QuTG9vdENvbGxlY3Rpb25iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Loot.LootCollectionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Map.MapIngredient), global::WUProtos.Map.MapIngredient.Parser, new[]{ "Id", "Loot", "Cost" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MapIngredient : pb::IMessage<MapIngredient> {
    private static readonly pb::MessageParser<MapIngredient> _parser = new pb::MessageParser<MapIngredient>(() => new MapIngredient());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MapIngredient> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Map.MapIngredientReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MapIngredient() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MapIngredient(MapIngredient other) : this() {
      id_ = other.id_;
      loot_ = other.loot_ != null ? other.loot_.Clone() : null;
      cost_ = other.cost_ != null ? other.cost_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MapIngredient Clone() {
      return new MapIngredient(this);
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

    /// <summary>Field number for the "loot" field.</summary>
    public const int LootFieldNumber = 2;
    private global::WUProtos.Data.Loot.LootCollection loot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Loot.LootCollection Loot {
      get { return loot_; }
      set {
        loot_ = value;
      }
    }

    /// <summary>Field number for the "cost" field.</summary>
    public const int CostFieldNumber = 3;
    private global::WUProtos.Data.Loot.LootCollection cost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Loot.LootCollection Cost {
      get { return cost_; }
      set {
        cost_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MapIngredient);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MapIngredient other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(Loot, other.Loot)) return false;
      if (!object.Equals(Cost, other.Cost)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (loot_ != null) hash ^= Loot.GetHashCode();
      if (cost_ != null) hash ^= Cost.GetHashCode();
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
      if (loot_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Loot);
      }
      if (cost_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Cost);
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
      if (loot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Loot);
      }
      if (cost_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Cost);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MapIngredient other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.loot_ != null) {
        if (loot_ == null) {
          Loot = new global::WUProtos.Data.Loot.LootCollection();
        }
        Loot.MergeFrom(other.Loot);
      }
      if (other.cost_ != null) {
        if (cost_ == null) {
          Cost = new global::WUProtos.Data.Loot.LootCollection();
        }
        Cost.MergeFrom(other.Cost);
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
            if (loot_ == null) {
              Loot = new global::WUProtos.Data.Loot.LootCollection();
            }
            input.ReadMessage(Loot);
            break;
          }
          case 26: {
            if (cost_ == null) {
              Cost = new global::WUProtos.Data.Loot.LootCollection();
            }
            input.ReadMessage(Cost);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
