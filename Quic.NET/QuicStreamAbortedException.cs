// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Fujin.Net.Quic
{
    public class QuicStreamAbortedException : QuicException
    {
        internal QuicStreamAbortedException(long errorCode)
            : this(string.Format(System.Net.Quic.SR.net_quic_streamaborted, errorCode), errorCode)
        {
        }

        public QuicStreamAbortedException(string message, long errorCode)
            : base(message)
        {
            ErrorCode = errorCode;
        }

        public long ErrorCode { get; }
    }
}
