// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Enums/UpdateType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Enums {

  /// <summary>Holder for reflection information generated from WUProtos/Enums/UpdateType.proto</summary>
  public static partial class UpdateTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Enums/UpdateType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UpdateTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9XVVByb3Rvcy9FbnVtcy9VcGRhdGVUeXBlLnByb3RvEg5XVVByb3Rvcy5F",
            "bnVtcyqJAQoKVXBkYXRlVHlwZRIHCgNBREQQABIKCgZNT0RJRlkQARIKCgZS",
            "RU1PVkUQAhIUChBQUkVESUNURURfTU9ESUZZEAMSFAoQUFJFRElDVEVEX1JF",
            "TU9WRRAEEhYKElJPTExFRF9CQUNLX01PRElGWRAFEhYKElJPTExFRF9CQUNL",
            "X1JFTU9WRRAGYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::WUProtos.Enums.UpdateType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum UpdateType {
    [pbr::OriginalName("ADD")] Add = 0,
    [pbr::OriginalName("MODIFY")] Modify = 1,
    [pbr::OriginalName("REMOVE")] Remove = 2,
    [pbr::OriginalName("PREDICTED_MODIFY")] PredictedModify = 3,
    [pbr::OriginalName("PREDICTED_REMOVE")] PredictedRemove = 4,
    [pbr::OriginalName("ROLLED_BACK_MODIFY")] RolledBackModify = 5,
    [pbr::OriginalName("ROLLED_BACK_REMOVE")] RolledBackRemove = 6,
  }

  #endregion

}

#endregion Designer generated code
