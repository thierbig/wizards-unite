// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Enums/PoiAccessibility.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Enums {

  /// <summary>Holder for reflection information generated from WUProtos/Enums/PoiAccessibility.proto</summary>
  public static partial class PoiAccessibilityReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Enums/PoiAccessibility.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PoiAccessibilityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVXVVByb3Rvcy9FbnVtcy9Qb2lBY2Nlc3NpYmlsaXR5LnByb3RvEg5XVVBy",
            "b3Rvcy5FbnVtcypYChBQb2lBY2Nlc3NpYmlsaXR5EhUKEVVOS05PV05fUE9J",
            "X1NUQVRFEAASDAoIUE9JX09QRU4QARIOCgpQT0lfQ0xPU0VEEAISDwoLUE9J",
            "X0NMT1NJTkcQA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::WUProtos.Enums.PoiAccessibility), }, null));
    }
    #endregion

  }
  #region Enums
  public enum PoiAccessibility {
    [pbr::OriginalName("UNKNOWN_POI_STATE")] UnknownPoiState = 0,
    [pbr::OriginalName("POI_OPEN")] PoiOpen = 1,
    [pbr::OriginalName("POI_CLOSED")] PoiClosed = 2,
    [pbr::OriginalName("POI_CLOSING")] PoiClosing = 3,
  }

  #endregion

}

#endregion Designer generated code
