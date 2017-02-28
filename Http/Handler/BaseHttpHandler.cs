using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Library.Network.Http
{
    public class BaseHttpHandler : IHttpHandler
    {
        internal IPost mPoster = null;
        internal IGet mGetor = null;
        public string Get(string url, string encoding)
        {
            return mGetor.Handle(url, encoding);
        }

        public void Post(string baseUrl, string method,string content, string encoding, string contentType, string accept)
        {
            mPoster.Handle(baseUrl, method,content, encoding, contentType, accept);
        }


        public void PostByGet(string baseUrl, string content, string encoding, string contentType, string accept, Action<Stream> action)
        {
            mPoster.GetHandle(baseUrl, content, encoding, contentType, accept, action);
        }
    }
       
}
