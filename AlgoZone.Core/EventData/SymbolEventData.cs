using System;

namespace AlgoZone.Core.EventData
{
    [Serializable]
    public abstract class SymbolEventData<TSymbolData> : ISymbolEventData<TSymbolData>
        where TSymbolData : ISymbolData
    {
        #region Properties

        /// <inheritdoc />
        public TSymbolData Data { get; set; }

        /// <inheritdoc />
        public EventDataType EventDataType { get; set; }

        /// <inheritdoc />
        public string OriginalData { get; set; }

        /// <inheritdoc />
        public DateTime Timestamp { get; set; }

        /// <inheritdoc />
        public string Topic { get; set; }

        #endregion
    }
}