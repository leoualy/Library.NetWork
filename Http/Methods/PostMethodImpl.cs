using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.IO;

namespace Library.Network.Http.Methods
{
    internal class PostMethodImpl : AbMethod
    {
        public override void AsyncFun(HttpPkg pack)
        {
            
        }

        public override void SyncFun(HttpPkg pack)
        {
            if (pack == null)
            {
                throw new Exception("自定义Http包结构对象为null");
            }
            Encoding encoding = Encoding.GetEncoding(pack.EncodingName);
            int len = encoding.GetByteCount(pack.Content);
            byte[] buffer = encoding.GetBytes(pack.Content);
            HttpWebRequest req = GetRequestInstance(pack, len);
            try
            {
                using (Stream s = req.GetRequestStream())
                {
                    s.Write(buffer,0,len);
                    // HttpWebResponse response = req.GetResponse() as HttpWebResponse;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        private HttpWebRequest GetRequestInstance(HttpPkg pack,int len)
        {
            HttpWebRequest req = WebRequest.Create(pack.Url) as HttpWebRequest;

            // 设置Http头
            PrepareHttpHead(ref req, pack.Method, pack.ContentType, pack.AcceptType);
            req.ContentLength = len;
            return req;
        }


    }
}
