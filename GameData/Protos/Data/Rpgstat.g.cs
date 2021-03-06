// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Rpgstat.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Rpgstat.proto</summary>
  public static partial class RpgstatReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Rpgstat.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RpgstatReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtXVVByb3Rvcy9EYXRhL1JwZ3N0YXQucHJvdG8SDVdVUHJvdG9zLkRhdGEi",
            "6QEKB1JwZ3N0YXQSCgoCaWQYASABKAkSNgoLc3RhdF9ib3VuZHMYAiABKAsy",
            "IS5XVVByb3Rvcy5EYXRhLlJwZ3N0YXQuUmFuZ2VJbnQ2NBomCgpSYW5nZUlu",
            "dDY0EgsKA21pbhgBIAEoAxILCgNtYXgYAiABKAMaJwoLUmFuZ2VVaW50MzIS",
            "CwoDbWluGAEgASgNEgsKA21heBgCIAEoDSJJCg9JY29uRGlzcGxheVR5cGUS",
            "CAoEQk9USBAAEg8KC1BMQVlFUl9WSUVXEAESDgoKRU5FTVlfVklFVxACEgsK",
            "B05FSVRIRVIQA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Rpgstat), global::WUProtos.Data.Rpgstat.Parser, new[]{ "Id", "StatBounds" }, null, new[]{ typeof(global::WUProtos.Data.Rpgstat.Types.IconDisplayType) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Rpgstat.Types.RangeInt64), global::WUProtos.Data.Rpgstat.Types.RangeInt64.Parser, new[]{ "Min", "Max" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Rpgstat.Types.RangeUint32), global::WUProtos.Data.Rpgstat.Types.RangeUint32.Parser, new[]{ "Min", "Max" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Rpgstat : pb::IMessage<Rpgstat> {
    private static readonly pb::MessageParser<Rpgstat> _parser = new pb::MessageParser<Rpgstat>(() => new Rpgstat());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Rpgstat> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.RpgstatReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Rpgstat() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Rpgstat(Rpgstat other) : this() {
      id_ = other.id_;
      statBounds_ = other.statBounds_ != null ? other.statBounds_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Rpgstat Clone() {
      return new Rpgstat(this);
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

    /// <summary>Field number for the "stat_bounds" field.</summary>
    public const int StatBoundsFieldNumber = 2;
    private global::WUProtos.Data.Rpgstat.Types.RangeInt64 statBounds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.Rpgstat.Types.RangeInt64 StatBounds {
      get { return statBounds_; }
      set {
        statBounds_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Rpgstat);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Rpgstat other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(StatBounds, other.StatBounds)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (statBounds_ != null) hash ^= StatBounds.GetHashCode();
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
      if (statBounds_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(StatBounds);
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
      if (statBounds_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StatBounds);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Rpgstat other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.statBounds_ != null) {
        if (statBounds_ == null) {
          StatBounds = new global::WUProtos.Data.Rpgstat.Types.RangeInt64();
        }
        StatBounds.MergeFrom(other.StatBounds);
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
            if (statBounds_ == null) {
              StatBounds = new global::WUProtos.Data.Rpgstat.Types.RangeInt64();
            }
            input.ReadMessage(StatBounds);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Rpgstat message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum IconDisplayType {
        [pbr::OriginalName("BOTH")] Both = 0,
        [pbr::OriginalName("PLAYER_VIEW")] PlayerView = 1,
        [pbr::OriginalName("ENEMY_VIEW")] EnemyView = 2,
        [pbr::OriginalName("NEITHER")] Neither = 3,
      }

      public sealed partial class RangeInt64 : pb::IMessage<RangeInt64> {
        private static readonly pb::MessageParser<RangeInt64> _parser = new pb::MessageParser<RangeInt64>(() => new RangeInt64());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<RangeInt64> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::WUProtos.Data.Rpgstat.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public RangeInt64() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public RangeInt64(RangeInt64 other) : this() {
          min_ = other.min_;
          max_ = other.max_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public RangeInt64 Clone() {
          return new RangeInt64(this);
        }

        /// <summary>Field number for the "min" field.</summary>
        public const int MinFieldNumber = 1;
        private long min_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long Min {
          get { return min_; }
          set {
            min_ = value;
          }
        }

        /// <summary>Field number for the "max" field.</summary>
        public const int MaxFieldNumber = 2;
        private long max_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long Max {
          get { return max_; }
          set {
            max_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as RangeInt64);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(RangeInt64 other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Min != other.Min) return false;
          if (Max != other.Max) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Min != 0L) hash ^= Min.GetHashCode();
          if (Max != 0L) hash ^= Max.GetHashCode();
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
          if (Min != 0L) {
            output.WriteRawTag(8);
            output.WriteInt64(Min);
          }
          if (Max != 0L) {
            output.WriteRawTag(16);
            output.WriteInt64(Max);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Min != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(Min);
          }
          if (Max != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(Max);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(RangeInt64 other) {
          if (other == null) {
            return;
          }
          if (other.Min != 0L) {
            Min = other.Min;
          }
          if (other.Max != 0L) {
            Max = other.Max;
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
                Min = input.ReadInt64();
                break;
              }
              case 16: {
                Max = input.ReadInt64();
                break;
              }
            }
          }
        }

      }

      public sealed partial class RangeUint32 : pb::IMessage<RangeUint32> {
        private static readonly pb::MessageParser<RangeUint32> _parser = new pb::MessageParser<RangeUint32>(() => new RangeUint32());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<RangeUint32> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::WUProtos.Data.Rpgstat.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public RangeUint32() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public RangeUint32(RangeUint32 other) : this() {
          min_ = other.min_;
          max_ = other.max_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public RangeUint32 Clone() {
          return new RangeUint32(this);
        }

        /// <summary>Field number for the "min" field.</summary>
        public const int MinFieldNumber = 1;
        private uint min_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public uint Min {
          get { return min_; }
          set {
            min_ = value;
          }
        }

        /// <summary>Field number for the "max" field.</summary>
        public const int MaxFieldNumber = 2;
        private uint max_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public uint Max {
          get { return max_; }
          set {
            max_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as RangeUint32);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(RangeUint32 other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Min != other.Min) return false;
          if (Max != other.Max) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Min != 0) hash ^= Min.GetHashCode();
          if (Max != 0) hash ^= Max.GetHashCode();
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
          if (Min != 0) {
            output.WriteRawTag(8);
            output.WriteUInt32(Min);
          }
          if (Max != 0) {
            output.WriteRawTag(16);
            output.WriteUInt32(Max);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Min != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Min);
          }
          if (Max != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Max);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(RangeUint32 other) {
          if (other == null) {
            return;
          }
          if (other.Min != 0) {
            Min = other.Min;
          }
          if (other.Max != 0) {
            Max = other.Max;
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
                Min = input.ReadUInt32();
                break;
              }
              case 16: {
                Max = input.ReadUInt32();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
