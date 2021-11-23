using System;

namespace AlgoZone.Core.EventData
{
    [Serializable]
    public class SymbolOrderBookEntry
    {
        #region Properties

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        #endregion
    }
}