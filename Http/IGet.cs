/***************************************************************************
 * 文件名:            IGet.cs
 * 作者：              liuy
 * 日期：              2017-01-06
 * 描述：              Get方法的实现
***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Network.Http
{
    internal interface IGet
    {
        /// <summary>
        /// 处理Http Get方法
        /// </summary>
        /// <param name="url"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        string Handle(string url,string encoding);
    }
}
