using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;


namespace Library.Network.Http
{
    internal abstract class BasePost : IPost
    {
        public abstract void Handle(string baseUrl,string method, string content, string encoding, string contentType,string accept);
        /// <summary>
        /// 受保护的准备Request的方法
        /// </summary>
        /// <param name="req">HttpWebRequest对象</param>
        /// <param name="contentType">内容类型</param>
        /// <param name="accept">接受类型</param>
        protected void PrepareRequest(ref HttpWebRequest req,string contentType, string accept)
        {
            req.Accept = accept;
            req.ContentType = contentType;
        }


        public abstract void GetHandle(string baseUrl, string content, string encoding, string contentType, string accept,Action<System.IO.Stream> action);
    }
}
