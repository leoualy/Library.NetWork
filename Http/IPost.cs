/***************************************************************************
 * 文件名:            IPost.cs
 * 作者：              liuy
 * 日期：              2017-01-06
 * 描述：              提交数据的实现
***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Network.Http
{
    interface IPost
    {
        /// <summary>
        /// 处理Post方法
        /// </summary>
        /// <param name="baseUrl">远程基本url</param>
        /// <param name="content">Post的内容</param>
        /// <param name="encoding">编码名称</param>
        /// <param name="contentType">内容类型</param>
        /// <param name="accept">接受类型</param>
        void Handle(string baseUrl, string method, string content, string encoding, string contentType, string accept);
        void GetHandle(string baseUrl, string content, string encoding, string contentType, string accept,Action<System.IO.Stream> action);
    }
}
