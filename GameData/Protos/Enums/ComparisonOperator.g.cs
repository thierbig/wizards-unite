// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Enums/ComparisonOperator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Enums {

  /// <summary>Holder for reflection information generated from WUProtos/Enums/ComparisonOperator.proto</summary>
  public static partial class ComparisonOperatorReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Enums/ComparisonOperator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ComparisonOperatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidXVVByb3Rvcy9FbnVtcy9Db21wYXJpc29uT3BlcmF0b3IucHJvdG8SDldV",
            "UHJvdG9zLkVudW1zKoEBChJDb21wYXJpc29uT3BlcmF0b3ISFgoSQ09NUEFS",
            "SVNPTl9VTktOT1dOEAASCQoFRVFVQUwQARIQCgxHUkVBVEVSX1RIQU4QAhIN",
            "CglMRVNTX1RIQU4QAxIUChBHUkVBVEVSX09SX0VRVUFMEAQSEQoNTEVTU19P",
            "Ul9FUVVBTBAFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::WUProtos.Enums.ComparisonOperator), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ComparisonOperator {
    [pbr::OriginalName("COMPARISON_UNKNOWN")] ComparisonUnknown = 0,
    [pbr::OriginalName("EQUAL")] Equal = 1,
    [pbr::OriginalName("GREATER_THAN")] GreaterThan = 2,
    [pbr::OriginalName("LESS_THAN")] LessThan = 3,
    [pbr::OriginalName("GREATER_OR_EQUAL")] GreaterOrEqual = 4,
    [pbr::OriginalName("LESS_OR_EQUAL")] LessOrEqual = 5,
  }

  #endregion

}

#endregion Designer generated code
