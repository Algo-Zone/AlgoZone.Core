namespace AlgoZone.Core.EventData
{
    public interface ISymbolEventData<TSymbolData> : IEventData
    {
        #region Properties

        /// <summary>
        /// The received data deserialized into an object
        /// </summary>
        TSymbolData Data { get; set; }

        #endregion
    }
}