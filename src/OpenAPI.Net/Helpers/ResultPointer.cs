﻿using Google.Protobuf;
using System;
using System.Threading;

namespace OpenAPI.Net.Helpers
{
    internal class ResultPointer : IDisposable
    {
        public IOAMessage Message;
        public AutoResetEvent WaitHandle = new AutoResetEvent(false);

        public void Dispose()
        {
            WaitHandle.Dispose();
        }
    }
}