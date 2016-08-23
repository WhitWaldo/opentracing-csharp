using System;

namespace OpenTracing.NullTracer
{
    public class NullSpan : ISpan
    {
        internal static readonly NullSpan Instance = new NullSpan(NullSpanContext.Instance);

        public ISpanContext Context { get; }

        private NullSpan(ISpanContext context)
        {
            Context = context;
        }

        public ISpan SetTag(string key, object value)
        {
            return this;
        }

        public ISpan LogEvent(string eventName, object payload = null)
        {
            return this;
        }

        public ISpan LogEvent(DateTimeOffset timestamp, string eventName, object payload = null)
        {
            return this;
        }

        public ISpan SetBaggageItem(string key, string value)
        {
            return this;
        }

        public string GetBaggageItem(string key)
        {
            return null;
        }

        public void Finish(DateTimeOffset? finishTimestamp = null)
        {
        }

        public void Dispose()
        {
        }
    }
}