/***************************************************************************
 * 文件名:            SyncPost.cs
 * 作者：              liuy
 * 日期：              2017-01-06
 * 描述：              派生的同步实现Post的方法
***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Net.Security;
using System.DirectoryServices;


namespace Library.Network.Http
{
    internal sealed class SyncPost : BasePost
    {
        public override void Handle(string baseUrl,string method, string content, string encoding, string contentType, string accept)
        {
            // 根据给定的编码格式将字符串转化为字节数组
            byte[] buffer = Encoding.GetEncoding(encoding).GetBytes(content);

            HttpWebRequest req = WebRequest.Create(baseUrl) as HttpWebRequest;
            if(req==null)
            {
                throw new NullReferenceException();
            }
            
            PrepareRequest(ref req, contentType, accept);
            req.Method = method;
            req.ContentLength = buffer.Length;
            try
            {
                using (Stream stream = req.GetRequestStream())
                {
                    
                    // 可以优化为异步投递
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
            catch(Exception eReq)
            {
                
                throw eReq;
            }
            HttpWebResponse response = req.GetResponse() as HttpWebResponse;
            HttpStatusCode code = response.StatusCode;
            
        }



        public override void GetHandle(string baseUrl, string content, string encoding, string contentType, string accept,Action<Stream> action)
        {
            // throw new NotImplementedException();
            // 根据给定的编码格式将字符串转化为字节数组
            // byte[] buffer = Encoding.GetEncoding(encoding).GetBytes(content);
            // Encoding mEncoding=Encoding.GetEncoding(encoding);

            string address = null;

            if (content != null)
            {
                address=string.Format("{0}?{1}", baseUrl, content);
            }
            else
            {
                address = baseUrl;
            }


            HttpWebRequest req = WebRequest.Create(address) as HttpWebRequest;
            if (req == null)
            {
                throw new NullReferenceException();
            }
            // PrepareRequest(ref req, contentType, accept);
            req.Accept = "*";
            req.Method = "GET";
            
            try
            {
                using (WebResponse rep = req.GetResponse())
                {
                    //Stream stream = rep.GetResponseStream();
                    //if (action != null)
                    //{
                    //    action(stream);
                    //}
                }
            }
            catch (Exception eReq)
            {
                throw eReq;
            }
            

        }
    }
}
