// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Fujin.Net.Quic
{
    public class QuicOperationAbortedException : QuicException
    {
        internal QuicOperationAbortedException()
            : base(System.Net.Quic.SR.net_quic_operationaborted)
        {
        }

        public QuicOperationAbortedException(string message) : base(message)
        {
        }
    }
}
