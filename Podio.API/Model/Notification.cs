using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Notification 
	{


		[DataMember(Name = "notification_id", IsRequired=false)]
		public int NotificationId { get; set; }


        //[DataMember(Name = "user", IsRequired=false)]
        //public Dictionary<string,string> User { get; set; }


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "viewed_on", IsRequired=false)]
		public DateTime ViewedOn { get; set; }


		[DataMember(Name = "subscription_id", IsRequired=false)]
		public int SubscriptionId { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public DateTime CreatedOn { get; set; }


		[DataMember(Name = "data", IsRequired=false)]
		public Dictionary<string,string> Data { get; set; }


		[DataMember(Name = "starred", IsRequired=false)]
		public bool Starred { get; set; }


		[DataMember(Name = "space", IsRequired=false)]
		public Dictionary<string,string> Space { get; set; }


		[DataMember(Name = "org", IsRequired=false)]
		public Dictionary<string,string> Org { get; set; }


		[DataMember(Name = "data_link", IsRequired=false)]
		public string DataLink { get; set; }


		[DataMember(Name = "context_type", IsRequired=false)]
		public string ContextType { get; set; }


		[DataMember(Name = "context_link", IsRequired=false)]
		public string ContextLink { get; set; }


		[DataMember(Name = "context", IsRequired=false)]
		public Dictionary<string,string> Context { get; set; }


		[DataMember(Name = "created_by", IsRequired=false)]
		public ByLine CreatedBy { get; set; }


		[DataMember(Name = "created_via", IsRequired=false)]
		public Via CreatedVia { get; set; }


		[DataMember(Name = "user", IsRequired=false)]
		public User User { get; set; }


	}
}

