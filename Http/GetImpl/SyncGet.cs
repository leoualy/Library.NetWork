/***************************************************************************
 * 文件名:            SyncPost.cs
 * 作者：              liuy
 * 日期：              2017-01-06
 * 描述：              派生的同步实现Get方法
***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Library.Network.Http
{
    internal class SyncGet : BaseGet
    {
        public override string Handle(string url, string encoding)
        {
            WebResponse resp = GetWResponse(url);
            if(resp==null)
            {
                throw new NullReferenceException();
            }
            return GetStringFromResponse(encoding,resp);
        }
    }
}
