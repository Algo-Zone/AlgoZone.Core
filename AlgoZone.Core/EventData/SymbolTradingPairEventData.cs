using System;
using EasyNetQ;

namespace AlgoZone.Core.EventData
{
    [Serializable]
    [Queue(nameof(SymbolTradingPairEventData), ExchangeName = nameof(SymbolTradingPairEventData))]
    public class SymbolTradingPairEventData : SymbolEventData<SymbolTradingPair> { }
}