using System;

namespace AlgoZone.Core.EventData
{
    [Serializable]
    public sealed class SymbolTick : ISymbolData
    {
        #region Properties

        /// <summary>
        /// The best ask price in the order book
        /// </summary>
        public decimal AskPrice { get; set; }

        /// <summary>
        /// The size of the best ask price in the order book
        /// </summary>
        public decimal AskQuantity { get; set; }

        /// <summary>
        /// The best bid price in the order book
        /// </summary>
        public decimal BidPrice { get; set; }

        /// <summary>
        /// The size of the best bid price in the order book
        /// </summary>
        public decimal BidQuantity { get; set; }

        /// <summary>
        /// The close price 24 hours ago
        /// </summary>
        public decimal PrevDayClosePrice { get; set; }

        /// <inheritdoc />
        public string Symbol { get; set; }

        #endregion
    }
}