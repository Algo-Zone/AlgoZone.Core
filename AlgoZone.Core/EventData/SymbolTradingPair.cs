using System;

namespace AlgoZone.Core.EventData
{
    [Serializable]
    public class SymbolTradingPair : ISymbolData
    {
        #region Properties

        public string BaseAsset { get; set; }

        public string QuoteAsset { get; set; }

        public string Status { get; set; }

        /// <inheritdoc />
        public string Symbol { get; set; }

        #endregion
    }
}