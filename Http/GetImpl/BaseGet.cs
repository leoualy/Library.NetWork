using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Library.Network.Http
{
    internal abstract class BaseGet : IGet
    {
        public abstract string Handle(string url, string encoding);
        protected WebResponse GetWResponse(string url)
        {
            WebRequest wrqt = WebRequest.Create(url);
            try
            {
                return wrqt.GetResponse();
            }
            catch (Exception eWrqt)
            {
                throw eWrqt;
            }
        }
        protected string GetStringFromResponse(string encoding,WebResponse resp)
        {
            Encoding encodingTmp=Encoding.GetEncoding(encoding);
            using(Stream stream=resp.GetResponseStream())
            {
                using(StreamReader sr=new StreamReader(stream,encodingTmp))
                {
                    return sr.ReadToEnd();
                }
            }
        }
    }
}
