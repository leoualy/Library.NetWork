/***************************************************************************
 * 文件名:            IHttpHandler.cs
 * 作者：              liuy
 * 日期：              2017-01-06
 * 描述：              处理http操作的接口
***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library.Network.Http
{
    public interface IHttpHandler
    {
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="url">远程url</param>
        /// <param name="encoding">编码类型</param>
        /// <returns>获取的串数据</returns>
        string Get(string url, string encoding);
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="baseUrl">基本的url</param>
        /// <param name="content">提交的内容串</param>
        /// <param name="encoding">提交内容编码名称</param>
        /// <param name="contentType">提交的内容类型</param>
        /// <param name="accept">接收的类型</param>
        void Post(string baseUrl,string method, string content, string encoding, string contentType, string accept);
        void PostByGet(string baseUrl, string content, string encoding, string contentType, string accept, Action<Stream> action);
    }
}
