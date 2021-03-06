// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/Profession/ProfessionTier.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data.Profession {

  /// <summary>Holder for reflection information generated from WUProtos/Data/Profession/ProfessionTier.proto</summary>
  public static partial class ProfessionTierReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/Profession/ProfessionTier.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProfessionTierReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1XVVByb3Rvcy9EYXRhL1Byb2Zlc3Npb24vUHJvZmVzc2lvblRpZXIucHJv",
            "dG8SGFdVUHJvdG9zLkRhdGEuUHJvZmVzc2lvbiIxCg5Qcm9mZXNzaW9uVGll",
            "chIfChdyYW5rX3BvaW50c191cHBlcl9ib3VuZBgBIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.Profession.ProfessionTier), global::WUProtos.Data.Profession.ProfessionTier.Parser, new[]{ "RankPointsUpperBound" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProfessionTier : pb::IMessage<ProfessionTier> {
    private static readonly pb::MessageParser<ProfessionTier> _parser = new pb::MessageParser<ProfessionTier>(() => new ProfessionTier());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProfessionTier> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.Profession.ProfessionTierReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionTier() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionTier(ProfessionTier other) : this() {
      rankPointsUpperBound_ = other.rankPointsUpperBound_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionTier Clone() {
      return new ProfessionTier(this);
    }

    /// <summary>Field number for the "rank_points_upper_bound" field.</summary>
    public const int RankPointsUpperBoundFieldNumber = 1;
    private uint rankPointsUpperBound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint RankPointsUpperBound {
      get { return rankPointsUpperBound_; }
      set {
        rankPointsUpperBound_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProfessionTier);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProfessionTier other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RankPointsUpperBound != other.RankPointsUpperBound) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RankPointsUpperBound != 0) hash ^= RankPointsUpperBound.GetHashCode();
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
      if (RankPointsUpperBound != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(RankPointsUpperBound);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RankPointsUpperBound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RankPointsUpperBound);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProfessionTier other) {
      if (other == null) {
        return;
      }
      if (other.RankPointsUpperBound != 0) {
        RankPointsUpperBound = other.RankPointsUpperBound;
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
            RankPointsUpperBound = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
