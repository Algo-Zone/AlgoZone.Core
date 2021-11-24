using System;
using System.Collections.Generic;

namespace AlgoZone.Core.EventData
{
    [Serializable]
    public sealed class SymbolOrderBook : ISymbolData
    {
        #region Properties

        public ICollection<SymbolOrderBookEntry> Asks { get; set; }

        public ICollection<SymbolOrderBookEntry> Bids { get; set; }

        public DateTime EventTime { get; set; }

        public long? FirstUpdatedId { get; set; }

        public long LastUpdateId { get; set; }

        /// <inheritdoc />
        public string Symbol { get; set; }

        #endregion
    }
}