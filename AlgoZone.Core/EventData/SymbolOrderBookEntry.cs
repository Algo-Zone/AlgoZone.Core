using System;

namespace AlgoZone.Core.EventData
{
    [Serializable]
    public sealed class SymbolOrderBookEntry
    {
        #region Properties

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        #endregion
    }
}