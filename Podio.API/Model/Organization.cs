using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Organization 
	{


		[DataMember(Name = "org_id", IsRequired=false)]
		public int OrgId { get; set; }


		[DataMember(Name = "name", IsRequired=false)]
		public string Name { get; set; }


		[DataMember(Name = "logo", IsRequired=false)]
		public int Logo { get; set; }


		[DataMember(Name = "image", IsRequired=false)]
		public Dictionary<string,string> Image { get; set; }


		[DataMember(Name = "spaces", IsRequired=false)]
		public Dictionary<string,string> Spaces { get; set; }


		[DataMember(Name = "url", IsRequired=false)]
		public string Url { get; set; }


		[DataMember(Name = "url_label", IsRequired=false)]
		public string UrlLabel { get; set; }


		[DataMember(Name = "premium", IsRequired=false)]
		public bool Premium { get; set; }


		[DataMember(Name = "role", IsRequired=false)]
		public string Role { get; set; }


		[DataMember(Name = "status", IsRequired=false)]
		public string Status { get; set; }


		[DataMember(Name = "sales_agent_id", IsRequired=false)]
		public int SalesAgentId { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public DateTime CreatedOn { get; set; }


		[DataMember(Name = "user_limit", IsRequired=false)]
		public int UserLimit { get; set; }


		[DataMember(Name = "member_count", IsRequired=false)]
		public int MemberCount { get; set; }


		[DataMember(Name = "contact_count", IsRequired=false)]
		public int ContactCount { get; set; }


		[DataMember(Name = "billing_interval", IsRequired=false)]
		public int BillingInterval { get; set; }


		[DataMember(Name = "rights", IsRequired=false)]
		public string[] Rights { get; set; }


		/// <summary>
		///  # TODO: Remove this, it's deprecate
		/// </summary>
		[DataMember(Name = "verified_domain", IsRequired=false)]
		public string VerifiedDomain { get; set; }


		[DataMember(Name = "domains", IsRequired=false)]
		public string[] Domains { get; set; }


		[DataMember(Name = "rank", IsRequired=false)]
		public int Rank { get; set; }


		[DataMember(Name = "contract_status", IsRequired=false)]
		public string ContractStatus { get; set; }


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "segment", IsRequired=false)]
		public string Segment { get; set; }


		[DataMember(Name = "segment_size", IsRequired=false)]
		public int SegmentSize { get; set; }


		[DataMember(Name = "created_by", IsRequired=false)]
		public ByLine CreatedBy { get; set; }


	}
}

