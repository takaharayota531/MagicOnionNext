using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicOnion;

using MagicOnion.Server;
using Sample.Shared.Services;

namespace Sample.Server.Services
{
    /// <summary>
    /// サーバー側でAPIを実装する
    /// </summary>
public class SampleService : ServiceBase<ISampleService>, ISampleService
    {
        /// <summary>
        /// 足し算の定義
        /// </summary>
        /// <param name="x">整数</param>
        /// <param name="y">整数</param>
        /// <returns></returns>
        public UnaryResult<int>SumAsync(int x,int y)
        {
            return UnaryResult(x + y);
        }
        /// <summary>
        /// 掛け算の定義
        /// </summary>
        /// <param name="x">整数</param>
        /// <param name="y">整数</param>
        /// <returns></returns>
        public UnaryResult<int> ProductAsync(int x,int y)
        {
            return UnaryResult(x * y);
        }

    }
}
