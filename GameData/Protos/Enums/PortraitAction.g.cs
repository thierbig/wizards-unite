// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Enums/PortraitAction.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Enums {

  /// <summary>Holder for reflection information generated from WUProtos/Enums/PortraitAction.proto</summary>
  public static partial class PortraitActionReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Enums/PortraitAction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PortraitActionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNXVVByb3Rvcy9FbnVtcy9Qb3J0cmFpdEFjdGlvbi5wcm90bxIOV1VQcm90",
            "b3MuRW51bXMqfgoOUG9ydHJhaXRBY3Rpb24SGQoVUE9SVFJBVEVfQUNUSU9O",
            "X1VOU0VUEAASGAoUUE9SVFJBSVRfQUNUSU9OX1NBVkUQARIcChhQT1JUUkFJ",
            "VF9BQ1RJT05fRE9XTkxPQUQQAhIZChVQT1JUUkFJVF9BQ1RJT05fU0hBUkUQ",
            "A2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::WUProtos.Enums.PortraitAction), }, null));
    }
    #endregion

  }
  #region Enums
  public enum PortraitAction {
    [pbr::OriginalName("PORTRATE_ACTION_UNSET")] PortrateActionUnset = 0,
    [pbr::OriginalName("PORTRAIT_ACTION_SAVE")] Save = 1,
    [pbr::OriginalName("PORTRAIT_ACTION_DOWNLOAD")] Download = 2,
    [pbr::OriginalName("PORTRAIT_ACTION_SHARE")] Share = 3,
  }

  #endregion

}

#endregion Designer generated code