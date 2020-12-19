using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DSharpPlus.Net
{
    public class RestRequestOptions
    {
        public CancellationToken CancellationToken { internal get; set; } = CancellationToken.None;

        public RetryMode RetryMode { internal get; set; } = RetryMode.RetryIfRatelimited;
    }

    public enum RetryMode
    {
        RetryIfUnsuccessful,

        RetryIfRatelimited,
        
        ThrowIfUnsuccessful, 
    }
}
