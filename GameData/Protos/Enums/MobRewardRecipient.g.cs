// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Enums/MobRewardRecipient.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Enums {

  /// <summary>Holder for reflection information generated from WUProtos/Enums/MobRewardRecipient.proto</summary>
  public static partial class MobRewardRecipientReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Enums/MobRewardRecipient.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MobRewardRecipientReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidXVVByb3Rvcy9FbnVtcy9Nb2JSZXdhcmRSZWNpcGllbnQucHJvdG8SDldV",
            "UHJvdG9zLkVudW1zKpwBChJNb2JSZXdhcmRSZWNpcGllbnQSHgoaTU9CX1JF",
            "V0FSRF9SRUNJUElFTlRfVU5TRVQQABIfChtNT0JfUkVXQVJEX1JFQ0lQSUVO",
            "VF9QTEFZRVIQARIdChlNT0JfUkVXQVJEX1JFQ0lQSUVOVF9URUFNEAISJgoi",
            "TU9CX1JFV0FSRF9SRUNJUElFTlRfUkFORE9NX1BMQVlFUhADYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::WUProtos.Enums.MobRewardRecipient), }, null));
    }
    #endregion

  }
  #region Enums
  public enum MobRewardRecipient {
    [pbr::OriginalName("MOB_REWARD_RECIPIENT_UNSET")] Unset = 0,
    [pbr::OriginalName("MOB_REWARD_RECIPIENT_PLAYER")] Player = 1,
    [pbr::OriginalName("MOB_REWARD_RECIPIENT_TEAM")] Team = 2,
    [pbr::OriginalName("MOB_REWARD_RECIPIENT_RANDOM_PLAYER")] RandomPlayer = 3,
  }

  #endregion

}

#endregion Designer generated code
