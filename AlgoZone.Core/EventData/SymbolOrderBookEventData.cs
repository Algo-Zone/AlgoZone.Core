using System;
using EasyNetQ;

namespace AlgoZone.Core.EventData
{
    [Serializable]
    [Queue(nameof(SymbolOrderBookEventData), ExchangeName = nameof(SymbolOrderBookEventData))]
    public sealed class SymbolOrderBookEventData : SymbolEventData<SymbolOrderBook> { }
}