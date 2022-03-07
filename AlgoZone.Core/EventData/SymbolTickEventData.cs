using System;
using EasyNetQ;

namespace AlgoZone.Core.EventData
{
    [Serializable]
    [Queue(nameof(SymbolTickEventData), ExchangeName = nameof(SymbolTickEventData))]
    public class SymbolTickEventData : SymbolEventData<SymbolTick> { }
}