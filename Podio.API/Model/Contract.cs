using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Contract 
	{


		[DataMember(Name = "contract_id", IsRequired=false)]
		public int ContractId { get; set; }


		[DataMember(Name = "org_id", IsRequired=false)]
		public int OrgId { get; set; }


		[DataMember(Name = "status", IsRequired=false)]
		public string Status { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public DateTime CreatedOn { get; set; }


		[DataMember(Name = "started_on", IsRequired=false)]
		public DateTime StartedOn { get; set; }


		[DataMember(Name = "ended_on", IsRequired=false)]
		public DateTime EndedOn { get; set; }


		[DataMember(Name = "item_prices", IsRequired=false)]
		public Dictionary<string,string> ItemPrices { get; set; }


		[DataMember(Name = "item_limits", IsRequired=false)]
		public Dictionary<string,string> ItemLimits { get; set; }


		[DataMember(Name = "payment_id", IsRequired=false)]
		public string PaymentId { get; set; }


		[DataMember(Name = "payment_status", IsRequired=false)]
		public string PaymentStatus { get; set; }


		[DataMember(Name = "accounting_id", IsRequired=false)]
		public string AccountingId { get; set; }


		[DataMember(Name = "full", IsRequired=false)]
		public bool Full { get; set; }


		[DataMember(Name = "premium_emp_network", IsRequired=false)]
		public bool PremiumEmpNetwork { get; set; }


		[DataMember(Name = "premium_spaces", IsRequired=false)]
		public string[] PremiumSpaces { get; set; }


		[DataMember(Name = "premium_space_ids", IsRequired=false)]
		public string[] PremiumSpaceIds { get; set; }

		[DataMember(Name = "next_period_start, :datetime", IsRequired=false)]
		public DateTime NextPeriodStart { get; set; }

		[DataMember(Name = "next_period_end, :datetime", IsRequired=false)]
		public DateTime NextPeriodEnd { get; set; }


		[DataMember(Name = "invoice_interval", IsRequired=false)]
		public int InvoiceInterval { get; set; }


		[DataMember(Name = "invoicing_mode", IsRequired=false)]
		public string InvoicingMode { get; set; }


		[DataMember(Name = "ended_reason", IsRequired=false)]
		public string EndedReason { get; set; }


		[DataMember(Name = "ended_comment", IsRequired=false)]
		public string EndedComment { get; set; }


		[DataMember(Name = "billing_mail", IsRequired=false)]
		public string BillingMail { get; set; }


		[DataMember(Name = "model", IsRequired=false)]
		public string Model { get; set; }


		[DataMember(Name = "org", IsRequired=false)]
		public Organization Org { get; set; }


		[DataMember(Name = "user", IsRequired=false)]
		public User User { get; set; }


		[DataMember(Name = "price", IsRequired=false)]
		public ContractPrice Price { get; set; }


        //[DataMember(Name = "premium_spaces", IsRequired=false)]
        //public List<Space> PremiumSpaces { get; set; }


	}
}

