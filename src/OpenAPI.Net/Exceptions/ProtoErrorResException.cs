﻿using ProtoOA.CommonMessages;
using ProtoOA.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAPI.Net.Exceptions
{
    internal class ProtoErrorResException : Exception
    {
        public ProtoErrorRes ProtoError;
        public override string Message { get => string.IsNullOrEmpty(ProtoError.Description) ? ProtoError.ErrorCode : $"{ProtoError.ErrorCode}({ProtoError.Description})"; }
        public ProtoErrorResException(ProtoErrorRes res)
        {
            ProtoError = new ProtoErrorRes(res);
        }
    }
}