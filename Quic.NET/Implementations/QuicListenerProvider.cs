// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Fujin.Net.Quic.Implementations
{
    internal abstract class QuicListenerProvider : IDisposable
    {
        internal abstract IPEndPoint ListenEndPoint { get; }

        internal abstract ValueTask<QuicConnectionProvider> AcceptConnectionAsync(CancellationToken cancellationToken = default);

        public abstract void Dispose();
    }
}
