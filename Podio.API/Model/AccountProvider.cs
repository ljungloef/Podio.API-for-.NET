using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class AccountProvider 
	{


		[DataMember(Name = "name", IsRequired=false)]
		public string Name { get; set; }


		[DataMember(Name = "connect_link", IsRequired=false)]
		public string ConnectLink { get; set; }


		[DataMember(Name = "humanized_name", IsRequired=false)]
		public string HumanizedName { get; set; }


		[DataMember(Name = "capabilities", IsRequired=false)]
		public string[] Capabilities { get; set; }


	}
}

