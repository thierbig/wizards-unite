// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Enums/PortraitType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Enums {

  /// <summary>Holder for reflection information generated from WUProtos/Enums/PortraitType.proto</summary>
  public static partial class PortraitTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Enums/PortraitType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PortraitTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFXVVByb3Rvcy9FbnVtcy9Qb3J0cmFpdFR5cGUucHJvdG8SDldVUHJvdG9z",
            "LkVudW1zKk8KDFBvcnRyYWl0VHlwZRIXChNQT1JUUkFJVF9UWVBFX1VOU0VU",
            "EAASEgoOUE9SVFJBSVRfUEhPVE8QARISCg5QT1JUUkFJVF9WSURFTxACYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::WUProtos.Enums.PortraitType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum PortraitType {
    [pbr::OriginalName("PORTRAIT_TYPE_UNSET")] Unset = 0,
    [pbr::OriginalName("PORTRAIT_PHOTO")] PortraitPhoto = 1,
    [pbr::OriginalName("PORTRAIT_VIDEO")] PortraitVideo = 2,
  }

  #endregion

}

#endregion Designer generated code
