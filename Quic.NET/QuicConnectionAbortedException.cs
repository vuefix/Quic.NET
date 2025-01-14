// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Fujin.Net.Quic
{
    public class QuicConnectionAbortedException : QuicException
    {
        internal QuicConnectionAbortedException(long errorCode)
            : this(string.Format(System.Net.Quic.SR.net_quic_connectionaborted, errorCode), errorCode)
        {
        }

        public QuicConnectionAbortedException(string message, long errorCode)
            : base(message)
        {
            ErrorCode = errorCode;
        }

        public long ErrorCode { get; }
    }
}
