using System;

namespace LinnworksAPI
{
    public class RefundInfo
    {
        public Guid? pkRefundRowId;
        public string SKU;
        public string ItemTitle;
        public bool IsItem;
        public bool IsService;
        public double Amount;
        public string Reason;
        public bool Actioned;
        public DateTime? ActionDate;
        public string ReturnReference;
        public double? Cost;
        public RefundStatus RefundStatus;
        public bool IgnoredValidation;
        public Guid? fkOrderItemRowId;
        public bool ShouldSerializeChannelReason;
        public string ChannelReason;
        public bool ShouldSerializeChannelReasonSec;
        public string ChannelReasonSec;
        public bool IsNew;
    }
}