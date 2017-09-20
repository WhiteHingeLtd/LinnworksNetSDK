using System;

namespace LinnworksAPI
{
    public class ReturnsRefundsWeb
    {
        public int Row;
        public Guid pkOrderID;
        public string cShippingAddress;
        public DateTime dProcessedOn;
        public double fPostageCost;
        public double fTotalCharge;
        public double PostageCostExTax;
        public double Subtotal;
        public double fTax;
        public double TotalDiscount;
        public double CountryTaxRate;
        public int nOrderId;
        public string cCurrency;
        public string PostalTrackingNumber;
        public string cCountry;
        public string Source;
        public string PostalServiceName;
        public string PostalServiceCode;
        public string Vendor;
        public string ReferenceNum;
        public string SecondaryReference;
        public string ExternalReference;
        public string Address1;
        public string Address2;
        public string Address3;
        public string Town;
        public string Region;
        public string BuyerPhoneNumber;
        public string Company;
        public string SubSource;
        public string ChannelBuyerName;
        public string AccountName;
        public string cFullName;
        public string cEmailAddress;
        public string cPostCode;
        public DateTime dPaidOn;
        public string cBillingAddress;
        public string BillingName;
        public string BillingCompany;
        public string BillingAddress1;
        public string BillingAddress2;
        public string BillingAddress3;
        public string BillingTown;
        public string BillingRegion;
        public string BillingPostCode;
        public string BillingCountryName;
        public string BillingPhoneNumber;
        public string cItemNumber;
        public string cItemName;
        public int pkReturnId;
        public string RowType;
        public string ReturnReference;
        public double PendingRefundAmount;
        public DateTime LastDate;
        public string Reason;
        public string ChannelReason;
        public string ChannelReasonSec;
        public string Category;
        public int ReturnQty;
        public Guid fkReturnLocationId;
        public bool Scrapped;
        public int? ScrapQty;
        public DateTime ReturnDate;
        public string Location;
        public string ItemNumber;
        public string ItemTitle;
        public int NewQty;
        public string RefundReference;
        public Guid pkRefundRowId;
        public double Amount;
        public DateTime CreateDate;
        public int CancellationQuantity;
        public Guid fkOrderItemReturnId;
        public DateTime ActionDate;
<<<<<<< HEAD
        public int RefundStatus;
=======
        public PostSaleStatusType RefundStatus;
>>>>>>> refs/remotes/LinnSystems/master
    }
}