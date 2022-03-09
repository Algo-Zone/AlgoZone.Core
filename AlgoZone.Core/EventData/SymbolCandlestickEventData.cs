using System;
using EasyNetQ;

namespace AlgoZone.Core.EventData
{
    [Serializable]
    [Queue(nameof(SymbolCandlestickEventData), ExchangeName = nameof(SymbolCandlestickEventData))]
    public class SymbolCandlestickEventData : SymbolEventData<SymbolCandlestick> { }
}