using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.ExternalIntercept.Models
{
    public sealed class LeavingViewModel
    {
        public LeavingViewModel(string uri, Uri referrer = null)
        {
            this.ExternalUri = new Uri(uri);
            this.Referrer = referrer;
        }

        public Uri ExternalUri { get; }
        public Uri Referrer { get; }
    }
}
