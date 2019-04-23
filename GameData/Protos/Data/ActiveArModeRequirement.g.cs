// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/ActiveArModeRequirement.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/ActiveArModeRequirement.proto</summary>
  public static partial class ActiveArModeRequirementReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/ActiveArModeRequirement.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ActiveArModeRequirementReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitXVVByb3Rvcy9EYXRhL0FjdGl2ZUFyTW9kZVJlcXVpcmVtZW50LnByb3Rv",
            "Eg1XVVByb3Rvcy5EYXRhGhpXVVByb3Rvcy9EYXRhL0FSTW9kZS5wcm90bxol",
            "V1VQcm90b3MvRW51bXMvRXF1YWxpdHlPcGVyYXRvci5wcm90byJ1ChdBY3Rp",
            "dmVBck1vZGVSZXF1aXJlbWVudBImCgdhcl9tb2RlGAEgASgOMhUuV1VQcm90",
            "b3MuRGF0YS5BUk1vZGUSMgoIb3BlcmF0b3IYAiABKA4yIC5XVVByb3Rvcy5F",
            "bnVtcy5FcXVhbGl0eU9wZXJhdG9yYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.ARModeReflection.Descriptor, global::WUProtos.Enums.EqualityOperatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.ActiveArModeRequirement), global::WUProtos.Data.ActiveArModeRequirement.Parser, new[]{ "ArMode", "Operator" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ActiveArModeRequirement : pb::IMessage<ActiveArModeRequirement> {
    private static readonly pb::MessageParser<ActiveArModeRequirement> _parser = new pb::MessageParser<ActiveArModeRequirement>(() => new ActiveArModeRequirement());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ActiveArModeRequirement> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.ActiveArModeRequirementReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActiveArModeRequirement() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActiveArModeRequirement(ActiveArModeRequirement other) : this() {
      arMode_ = other.arMode_;
      operator_ = other.operator_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActiveArModeRequirement Clone() {
      return new ActiveArModeRequirement(this);
    }

    /// <summary>Field number for the "ar_mode" field.</summary>
    public const int ArModeFieldNumber = 1;
    private global::WUProtos.Data.ARMode arMode_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Data.ARMode ArMode {
      get { return arMode_; }
      set {
        arMode_ = value;
      }
    }

    /// <summary>Field number for the "operator" field.</summary>
    public const int OperatorFieldNumber = 2;
    private global::WUProtos.Enums.EqualityOperator operator_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Enums.EqualityOperator Operator {
      get { return operator_; }
      set {
        operator_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ActiveArModeRequirement);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ActiveArModeRequirement other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ArMode != other.ArMode) return false;
      if (Operator != other.Operator) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ArMode != 0) hash ^= ArMode.GetHashCode();
      if (Operator != 0) hash ^= Operator.GetHashCode();
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
      if (ArMode != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ArMode);
      }
      if (Operator != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Operator);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ArMode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ArMode);
      }
      if (Operator != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Operator);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ActiveArModeRequirement other) {
      if (other == null) {
        return;
      }
      if (other.ArMode != 0) {
        ArMode = other.ArMode;
      }
      if (other.Operator != 0) {
        Operator = other.Operator;
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
            ArMode = (global::WUProtos.Data.ARMode) input.ReadEnum();
            break;
          }
          case 16: {
            Operator = (global::WUProtos.Enums.EqualityOperator) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code