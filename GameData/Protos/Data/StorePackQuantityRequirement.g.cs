// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/StorePackQuantityRequirement.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/StorePackQuantityRequirement.proto</summary>
  public static partial class StorePackQuantityRequirementReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/StorePackQuantityRequirement.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StorePackQuantityRequirementReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBXVVByb3Rvcy9EYXRhL1N0b3JlUGFja1F1YW50aXR5UmVxdWlyZW1lbnQu",
            "cHJvdG8SDVdVUHJvdG9zLkRhdGEaJ1dVUHJvdG9zL0VudW1zL0NvbXBhcmlz",
            "b25PcGVyYXRvci5wcm90byKDAQocU3RvcmVQYWNrUXVhbnRpdHlSZXF1aXJl",
            "bWVudBIVCg1zdG9yZV9wYWNrX2lkGAEgASgJEj8KE2NvbXBhcmlzb25fb3Bl",
            "cmF0b3IYAiABKA4yIi5XVVByb3Rvcy5FbnVtcy5Db21wYXJpc29uT3BlcmF0",
            "b3ISCwoDcXR5GAMgASgDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Enums.ComparisonOperatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Data.StorePackQuantityRequirement), global::WUProtos.Data.StorePackQuantityRequirement.Parser, new[]{ "StorePackId", "ComparisonOperator", "Qty" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StorePackQuantityRequirement : pb::IMessage<StorePackQuantityRequirement> {
    private static readonly pb::MessageParser<StorePackQuantityRequirement> _parser = new pb::MessageParser<StorePackQuantityRequirement>(() => new StorePackQuantityRequirement());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StorePackQuantityRequirement> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Data.StorePackQuantityRequirementReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StorePackQuantityRequirement() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StorePackQuantityRequirement(StorePackQuantityRequirement other) : this() {
      storePackId_ = other.storePackId_;
      comparisonOperator_ = other.comparisonOperator_;
      qty_ = other.qty_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StorePackQuantityRequirement Clone() {
      return new StorePackQuantityRequirement(this);
    }

    /// <summary>Field number for the "store_pack_id" field.</summary>
    public const int StorePackIdFieldNumber = 1;
    private string storePackId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StorePackId {
      get { return storePackId_; }
      set {
        storePackId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "comparison_operator" field.</summary>
    public const int ComparisonOperatorFieldNumber = 2;
    private global::WUProtos.Enums.ComparisonOperator comparisonOperator_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Enums.ComparisonOperator ComparisonOperator {
      get { return comparisonOperator_; }
      set {
        comparisonOperator_ = value;
      }
    }

    /// <summary>Field number for the "qty" field.</summary>
    public const int QtyFieldNumber = 3;
    private long qty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Qty {
      get { return qty_; }
      set {
        qty_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StorePackQuantityRequirement);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StorePackQuantityRequirement other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StorePackId != other.StorePackId) return false;
      if (ComparisonOperator != other.ComparisonOperator) return false;
      if (Qty != other.Qty) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (StorePackId.Length != 0) hash ^= StorePackId.GetHashCode();
      if (ComparisonOperator != 0) hash ^= ComparisonOperator.GetHashCode();
      if (Qty != 0L) hash ^= Qty.GetHashCode();
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
      if (StorePackId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(StorePackId);
      }
      if (ComparisonOperator != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ComparisonOperator);
      }
      if (Qty != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Qty);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (StorePackId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StorePackId);
      }
      if (ComparisonOperator != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ComparisonOperator);
      }
      if (Qty != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Qty);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StorePackQuantityRequirement other) {
      if (other == null) {
        return;
      }
      if (other.StorePackId.Length != 0) {
        StorePackId = other.StorePackId;
      }
      if (other.ComparisonOperator != 0) {
        ComparisonOperator = other.ComparisonOperator;
      }
      if (other.Qty != 0L) {
        Qty = other.Qty;
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
            StorePackId = input.ReadString();
            break;
          }
          case 16: {
            ComparisonOperator = (global::WUProtos.Enums.ComparisonOperator) input.ReadEnum();
            break;
          }
          case 24: {
            Qty = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
