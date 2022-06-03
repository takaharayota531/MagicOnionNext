using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MagicOnion;
using Sample.Shared.MessagePackObjects;
using System.Threading.Tasks;

namespace Sample.Shared.Hubs
{
    /// <summary>
    /// リアルタイム通信用のAPI
    /// Client→Server
    /// </summary>
    public interface ISampleHub : IStreamingHub<ISampleHub, ISampleHubReceiver>
    {
        /// <summary>
        /// ゲームに接続することをサーバーに伝える
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        Task JoinAsync(Player player);

        /// <summary>
        /// ゲーム切断をサーバに伝える
        /// </summary>
        /// <returns></returns>
        Task LeaveAsync();

        /// <summary>
        /// メッセージをサーバに伝える
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Task SendMessageAsync(string message);

        /// <summary>
        /// 移動したことをサーバーに伝える
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        Task MovePositionAsync(Vector3 position);
    }

    /// <summary>
    /// server→ClientのAPI
    /// </summary>
    public interface ISampleHubReceiver
    {
        /// <summary>
        /// 誰かがゲームに接続したことをクライアントに伝える
        /// </summary>
        /// <param name="name"></param>
        void OnJoin(string name);

        /// <summary>
        /// 誰かが退室したことをクライアントに伝える
        /// </summary>
        /// <param name="name"></param>
        void OnLeave(string name);

        /// <summary>
        /// 誰かが発言したことをクライアントに伝える
        /// </summary>
        /// <param name="name"></param>
        /// <param name="message"></param>
        void OnSendMessage(string name, string message);

        /// <summary>
        /// 誰かが移動したことをクライアントに伝える
        /// </summary>
        /// <param name="player"></param>
        void OnMovePosition(Player player);
    }
}