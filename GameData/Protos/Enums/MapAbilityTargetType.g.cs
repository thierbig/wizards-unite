// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Enums/MapAbilityTargetType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Enums {

  /// <summary>Holder for reflection information generated from WUProtos/Enums/MapAbilityTargetType.proto</summary>
  public static partial class MapAbilityTargetTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Enums/MapAbilityTargetType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapAbilityTargetTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilXVVByb3Rvcy9FbnVtcy9NYXBBYmlsaXR5VGFyZ2V0VHlwZS5wcm90bxIO",
            "V1VQcm90b3MuRW51bXMq1AIKFE1hcEFiaWxpdHlUYXJnZXRUeXBlEg8KC1RB",
            "UkdFVF9OT05FEAASFQoRVEFSR0VUX0NIT09TRV9PTkUQARIYChRUQVJHRVRf",
            "Q0hPT1NFX0ZSSUVORBACEhcKE1RBUkdFVF9DSE9PU0VfRU5FTVkQAxIPCgtU",
            "QVJHRVRfU0VMRhAEEhAKDFRBUkdFVF9SQU5HRRAFEhsKF1RBUkdFVF9FTkVN",
            "SUVTX0lOX1JBTkdFEAYSGQoVVEFSR0VUX0VOVElSRV9GUklFTkRTEAcSFQoR",
            "VEFSR0VUX1JBTkRPTV9PTkUQCBIYChRUQVJHRVRfUkFORE9NX0ZSSUVORBAJ",
            "EhcKE1RBUkdFVF9SQU5ET01fRU5FTVkQChIZChVUQVJHRVRfRU5USVJFX0VO",
            "RU1JRVMQCxIhCh1UQVJHRVRfQ0hPT1NFX0ZSSUVORF9OT1RfU0VMRhAMYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::WUProtos.Enums.MapAbilityTargetType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum MapAbilityTargetType {
    [pbr::OriginalName("TARGET_NONE")] TargetNone = 0,
    [pbr::OriginalName("TARGET_CHOOSE_ONE")] TargetChooseOne = 1,
    [pbr::OriginalName("TARGET_CHOOSE_FRIEND")] TargetChooseFriend = 2,
    [pbr::OriginalName("TARGET_CHOOSE_ENEMY")] TargetChooseEnemy = 3,
    [pbr::OriginalName("TARGET_SELF")] TargetSelf = 4,
    [pbr::OriginalName("TARGET_RANGE")] TargetRange = 5,
    [pbr::OriginalName("TARGET_ENEMIES_IN_RANGE")] TargetEnemiesInRange = 6,
    [pbr::OriginalName("TARGET_ENTIRE_FRIENDS")] TargetEntireFriends = 7,
    [pbr::OriginalName("TARGET_RANDOM_ONE")] TargetRandomOne = 8,
    [pbr::OriginalName("TARGET_RANDOM_FRIEND")] TargetRandomFriend = 9,
    [pbr::OriginalName("TARGET_RANDOM_ENEMY")] TargetRandomEnemy = 10,
    [pbr::OriginalName("TARGET_ENTIRE_ENEMIES")] TargetEntireEnemies = 11,
    [pbr::OriginalName("TARGET_CHOOSE_FRIEND_NOT_SELF")] TargetChooseFriendNotSelf = 12,
  }

  #endregion

}

#endregion Designer generated code
