// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Enums/StorePackConfigSize.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Enums {

  /// <summary>Holder for reflection information generated from WUProtos/Enums/StorePackConfigSize.proto</summary>
  public static partial class StorePackConfigSizeReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Enums/StorePackConfigSize.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StorePackConfigSizeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihXVVByb3Rvcy9FbnVtcy9TdG9yZVBhY2tDb25maWdTaXplLnByb3RvEg5X",
            "VVByb3Rvcy5FbnVtcypGChNTdG9yZVBhY2tDb25maWdTaXplEg4KClNJWkVf",
            "U01BTEwQABIPCgtTSVpFX01FRElVTRABEg4KClNJWkVfTEFSR0UQAmIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::WUProtos.Enums.StorePackConfigSize), }, null));
    }
    #endregion

  }
  #region Enums
  public enum StorePackConfigSize {
    [pbr::OriginalName("SIZE_SMALL")] SizeSmall = 0,
    [pbr::OriginalName("SIZE_MEDIUM")] SizeMedium = 1,
    [pbr::OriginalName("SIZE_LARGE")] SizeLarge = 2,
  }

  #endregion

}

#endregion Designer generated code
