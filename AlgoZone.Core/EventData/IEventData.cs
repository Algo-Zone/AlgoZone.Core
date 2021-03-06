using System;

namespace AlgoZone.Core.EventData
{
    public interface IEventData
    {
        #region Properties

        /// <summary>
        /// The event data type.
        /// </summary>
        EventDataType EventDataType { get; set; }

        /// <summary>
        /// The original data that was received, only available when OutputOriginalData is set to true in the client options
        /// </summary>
        string OriginalData { get; set; }

        /// <summary>
        /// The timestamp the data was received
        /// </summary>
        DateTime Timestamp { get; set; }

        /// <summary>
        /// The topic of the update, what symbol/asset etc..
        /// </summary>
        string Topic { get; set; }

        #endregion
    }
}