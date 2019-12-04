using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetInventoryItemBatchInformationByIdsRequest
	{
        /// <summary>
        /// A list of stock item ids 
        /// </summary>
		public List<Guid> StockItemIds;

        /// <summary>
        /// The location to get the batch information from 
        /// </summary>
		public Guid? StockLocationId;

        /// <summary>
        /// Defines whether we should only return available items 
        /// </summary>
		public Boolean AvailableOnly;
	} 
}