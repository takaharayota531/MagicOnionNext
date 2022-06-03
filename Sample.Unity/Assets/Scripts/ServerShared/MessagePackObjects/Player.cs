using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MessagePack;

namespace Sample.Shared.MessagePackObjects
{
    /// <summary>
    ///MagicOnionを使用する場合、Client <=>サーバー間で使用するクラスはMessagePackObject として定義する
    /// →MessagePackObjectAttributeをクラスに振る
    /// →KeyAttributeをそれぞれに割り振る
    /// </summary>
    [MessagePackObject]
    public class Player
    {
        [Key(0)] public string Name { get; set; }
        [Key(1)] public Vector3 Position { get; set; }

        [Key(2)] public Quaternion Rotation { get; set; }
    }
}