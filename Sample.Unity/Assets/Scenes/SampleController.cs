using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grpc.Core;
using Sample.Shared.Services;
using System.Threading.Tasks;
using Grpc.Core;
using MagicOnion.Client;


/// <summary>
/// サーバーへ接続するためのスクリプト
/// </summary>
public class SampleController : MonoBehaviour
{
    private Channel channel;
    private ISampleService sampleService;

    //スタートでサーバーへ接続
    void Start()
    {
        this.channel = new Channel("localhost:12345", ChannelCredentials.Insecure);
        this.sampleService = MagicOnionClient.Create<ISampleService>(channel);
        this.SampleServiceTest(1, 2); //サーバーtest
    }

    /// <summary>
    /// serverの接続テストを行っている
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    async void SampleServiceTest(int x, int y)
    {
        var sumResult = await this.sampleService.SumAsync(x, y);
        Debug.Log($"{nameof(sumResult)}:{sumResult}");
        var productResult = await this.sampleService.ProductAsync(x, y);
        Debug.Log($"{nameof(productResult)}:{productResult}");
    }

    /// <summary>
    /// サーバーを切断
    /// </summary>
    async void OnDestroy()
    {
        await this.channel.ShutdownAsync();
    }
}