// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace StreamJsonRpc
{
    using System.Diagnostics.Tracing;

    [EventSource(Name = "Microsoft-VisualStudio-StreamJsonRpc")]
    internal sealed class JsonRpcEventSource : EventSource
    {
        /// <summary>
        /// The singleton instance used for logging.
        /// </summary>
        internal static readonly JsonRpcEventSource Instance = new JsonRpcEventSource();

        private const int AttachStreamsAndStartListeningStartEvent = 1;

        private const int AttachStreamsAndStartListeningStopEvent = 2;

        private const int GenerateProxyUsingStreamsAndStartListeningStartEvent = 3;

        private const int GenerateProxyUsingStreamsAndStartListeningStopEvent = 4;

        private const int GenerateProxyAndStartListeningStartEvent = 5;

        private const int GenerateProxyAndStartListeningStopEvent = 6;

        private const int GenerateProxyStartEvent = 7;

        private const int GenerateProxyStopEvent = 8;

        private const int InvokeRpcMethodFireAndForgetEvent = 20;

        private const int InvokeRpcMethodStartEvent = 21;

        private const int InvokeRpcMethodEndEvent = 22;

        [Event(AttachStreamsAndStartListeningStartEvent, Level = EventLevel.Verbose)]
        public void AttachStreamsAndStartListeningStart(string sendingStreamTypeFullName, string receivingStreamTypeFullName)
        {
            this.WriteEvent(AttachStreamsAndStartListeningStartEvent, sendingStreamTypeFullName, receivingStreamTypeFullName);
        }

        [Event(AttachStreamsAndStartListeningStopEvent, Level = EventLevel.Verbose)]
        public void AttachStreamsAndStartListeningStop(string sendingStreamTypeFullName, string receivingStreamTypeFullName)
        {
            this.WriteEvent(AttachStreamsAndStartListeningStopEvent, sendingStreamTypeFullName, receivingStreamTypeFullName);
        }

        [Event(GenerateProxyUsingStreamsAndStartListeningStartEvent, Level = EventLevel.Verbose)]
        public void GenerateProxyUsingStreamsAndStartListeningStart(string typeFullName)
        {
            this.WriteEvent(GenerateProxyUsingStreamsAndStartListeningStartEvent, typeFullName);
        }

        [Event(GenerateProxyUsingStreamsAndStartListeningStopEvent, Level = EventLevel.Verbose)]
        public void GenerateProxyUsingStreamsAndStartListeningStop(string typeFullName)
        {
            this.WriteEvent(GenerateProxyUsingStreamsAndStartListeningStopEvent, typeFullName);
        }

        [Event(GenerateProxyAndStartListeningStartEvent, Level = EventLevel.Verbose)]
        public void GenerateProxyAndStartListeningStart(string typeFullName)
        {
            this.WriteEvent(GenerateProxyAndStartListeningStartEvent, typeFullName);
        }

        [Event(GenerateProxyAndStartListeningStopEvent, Level = EventLevel.Verbose)]
        public void GenerateProxyAndStartListeningStop(string typeFullName)
        {
            this.WriteEvent(GenerateProxyAndStartListeningStopEvent, typeFullName);
        }

        [Event(GenerateProxyStartEvent, Level = EventLevel.Verbose)]
        public void GenerateProxyStart(string typeFullName)
        {
            this.WriteEvent(GenerateProxyStartEvent, typeFullName);
        }

        [Event(GenerateProxyStopEvent, Level = EventLevel.Verbose)]
        public void GenerateProxyStop(string typeFullName)
        {
            this.WriteEvent(GenerateProxyStopEvent, typeFullName);
        }

        [Event(InvokeRpcMethodFireAndForgetEvent, Level = EventLevel.Verbose)]
        public void InvokeRpcMethodFireAndForget(string id, string targetName, string arguments, bool isParameterObject)
        {
            this.WriteEvent(InvokeRpcMethodFireAndForgetEvent, id, targetName, arguments, isParameterObject);
        }

        [Event(InvokeRpcMethodStartEvent, Level = EventLevel.Verbose)]
        public void InvokeRpcMethodStart(string id, string targetName, string arguments, bool isParameterObject)
        {
            this.WriteEvent(InvokeRpcMethodStartEvent, id, targetName, arguments, isParameterObject);
        }

        [Event(InvokeRpcMethodEndEvent, Level = EventLevel.Verbose)]
        public void InvokeRpcMethodEnd(string id, string targetName, string arguments, bool isParameterObject, bool requestSuccessful, bool connectionLost, bool errorOccurred)
        {
            this.WriteEvent(InvokeRpcMethodEndEvent, id, targetName, arguments, isParameterObject, requestSuccessful, connectionLost, errorOccurred);
        }
    }
}
