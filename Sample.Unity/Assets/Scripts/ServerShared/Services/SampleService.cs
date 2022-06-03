using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MagicOnion;

namespace Sample.Shared.Services
{
    /// <summary>
    /// 普通のAPI通信を試してみる
    /// </summary>
    public interface ISampleService : IService<ISampleService>
    {
        UnaryResult<int> SumAsync(int x, int y); //足し算をしてくれるAPI
        UnaryResult<int> ProductAsync(int x, int y); //掛け算をしてくれるAPI
    }
}