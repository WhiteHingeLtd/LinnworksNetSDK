using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CancellationRequest
	{
		public Boolean IsRetry { get; set; }

		public Boolean IsChannelCancellation { get; set; }

		public Boolean IsChannelCancellationConfirmed { get; set; }

		public Boolean IsFreeText { get; set; }

		public String FreeTextOrNote { get; set; }

		public String ReasonTag { get; set; }

		public String SubReasonTag { get; set; }

		public Boolean CreateFullRefund { get; set; }

		public Int32 HeaderId { get; set; }

		public Guid OrderId { get; set; }

		public ActionForm ActionForm { get; set; }
	} 
}