using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Grant 
	{


		[DataMember(Name = "ref_type", IsRequired=false)]
		public string RefType { get; set; }


		[DataMember(Name = "ref_id", IsRequired=false)]
		public int RefId { get; set; }


		[DataMember(Name = "people", IsRequired=false)]
		public Dictionary<string,string> People { get; set; }


		[DataMember(Name = "action", IsRequired=false)]
		public string Action { get; set; }


		[DataMember(Name = "message", IsRequired=false)]
		public string Message { get; set; }


	}
}

