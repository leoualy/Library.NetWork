using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Network.Http
{
    public sealed class HttpHandlerSync : BaseHttpHandler
    {
        public HttpHandlerSync()
        {
            mPoster = new SyncPost();
            mGetor = new SyncGet();
        }
    }
}
