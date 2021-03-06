using System;

namespace AlgoZone.Core.EventData
{
    [Serializable]
    public class SymbolCandlestick : ISymbolData
    {
        #region Properties

        /// <summary>
        /// The close price of the candlestick.
        /// </summary>
        public decimal Close { get; set; }

        /// <summary>
        /// The highest price of the candlestick.
        /// </summary>
        public decimal High { get; set; }

        /// <summary>
        /// The lowest price of the candlestick.
        /// </summary>
        public decimal Low { get; set; }

        /// <summary>
        /// The open price of the candlestick.
        /// </summary>
        public decimal Open { get; set; }

        /// <inheritdoc />
        public string Symbol { get; set; }

        /// <summary>
        /// The timestamp of the candlestick.
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// The volume of the candlestick.
        /// </summary>
        public decimal Volume { get; set; }

        #endregion
    }
}