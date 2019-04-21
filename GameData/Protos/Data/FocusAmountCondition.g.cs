// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/FocusAmountCondition.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/FocusAmountCondition.proto</summary>
  public static partial class FocusAmountConditionReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/FocusAmountCondition.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FocusAmountConditionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihXVVByb3Rvcy9EYXRhL0ZvY3VzQW1vdW50Q29uZGl0aW9uLnByb3RvEg1X",
            "VVByb3Rvcy5EYXRhGidXVVByb3Rvcy9FbnVtcy9Db21wYXJpc29uT3BlcmF0",
            "b3IucHJvdG8ieAoURm9jdXNBbW91bnRDb25kaXRpb24SPwoTY29tcGFyaXNv",
            "bl9vcGVyYXRvchgBIAEoDjIiLldVUHJvdG9zLkVudW1zLkNvbXBhcmlzb25P",
            "cGVyYXRvchIfChd0YXJnZXRfY29tcGFyaXNvbl92YWx1ZRgCIAEoBWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Enums.ComparisonOperatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.FocusAmountCondition), global::WUProtos.Data.FocusAmountCondition.Parser, new[]{ "ComparisonOperator", "TargetComparisonValue" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FocusAmountCondition : pb::IMessage<FocusAmountCondition> {
    private static readonly pb::MessageParser<FocusAmountCondition> _parser = new pb::MessageParser<FocusAmountCondition>(() => new FocusAmountCondition());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FocusAmountCondition> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.FocusAmountConditionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FocusAmountCondition() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FocusAmountCondition(FocusAmountCondition other) : this() {
      comparisonOperator_ = other.comparisonOperator_;
      targetComparisonValue_ = other.targetComparisonValue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FocusAmountCondition Clone() {
      return new FocusAmountCondition(this);
    }

    /// <summary>Field number for the "comparison_operator" field.</summary>
    public const int ComparisonOperatorFieldNumber = 1;
    private global::WUProtos.Enums.ComparisonOperator comparisonOperator_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Enums.ComparisonOperator ComparisonOperator {
      get { return comparisonOperator_; }
      set {
        comparisonOperator_ = value;
      }
    }

    /// <summary>Field number for the "target_comparison_value" field.</summary>
    public const int TargetComparisonValueFieldNumber = 2;
    private int targetComparisonValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TargetComparisonValue {
      get { return targetComparisonValue_; }
      set {
        targetComparisonValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FocusAmountCondition);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FocusAmountCondition other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ComparisonOperator != other.ComparisonOperator) return false;
      if (TargetComparisonValue != other.TargetComparisonValue) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ComparisonOperator != 0) hash ^= ComparisonOperator.GetHashCode();
      if (TargetComparisonValue != 0) hash ^= TargetComparisonValue.GetHashCode();
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
      if (ComparisonOperator != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ComparisonOperator);
      }
      if (TargetComparisonValue != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(TargetComparisonValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ComparisonOperator != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ComparisonOperator);
      }
      if (TargetComparisonValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TargetComparisonValue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FocusAmountCondition other) {
      if (other == null) {
        return;
      }
      if (other.ComparisonOperator != 0) {
        ComparisonOperator = other.ComparisonOperator;
      }
      if (other.TargetComparisonValue != 0) {
        TargetComparisonValue = other.TargetComparisonValue;
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
            ComparisonOperator = (global::WUProtos.Enums.ComparisonOperator) input.ReadEnum();
            break;
          }
          case 16: {
            TargetComparisonValue = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
