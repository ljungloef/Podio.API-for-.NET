using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Connection 
	{


		[DataMember(Name = "connection_id", IsRequired=false)]
		public int ConnectionId { get; set; }


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "name", IsRequired=false)]
		public string Name { get; set; }


		[DataMember(Name = "last_load_on", IsRequired=false)]
		public DateTime LastLoadOn { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public DateTime CreatedOn { get; set; }


		[DataMember(Name = "contact_count", IsRequired=false)]
		public int ContactCount { get; set; }


	}
}

