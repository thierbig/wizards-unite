// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Data/ARMode.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Data {

  /// <summary>Holder for reflection information generated from WUProtos/Data/ARMode.proto</summary>
  public static partial class ARModeReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Data/ARMode.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ARModeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpXVVByb3Rvcy9EYXRhL0FSTW9kZS5wcm90bxINV1VQcm90b3MuRGF0YSo/",
            "CgZBUk1vZGUSEQoNQVJfTU9ERV9VTlNFVBAAEgwKCGFkdmFuY2VkEAESCgoG",
            "c2ltcGxlEAISCAoEcGFyaxADYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::WUProtos.Data.ARMode), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ARMode {
    [pbr::OriginalName("AR_MODE_UNSET")] Unset = 0,
    [pbr::OriginalName("advanced")] Advanced = 1,
    [pbr::OriginalName("simple")] Simple = 2,
    [pbr::OriginalName("park")] Park = 3,
  }

  #endregion

}

#endregion Designer generated code
