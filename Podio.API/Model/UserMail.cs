using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class UserMail 
	{


		[DataMember(Name = "mail", IsRequired=false)]
		public string Mail { get; set; }


		[DataMember(Name = "verified", IsRequired=false)]
		public bool Verified { get; set; }


		[DataMember(Name = "primary", IsRequired=false)]
		public bool Primary { get; set; }


		[DataMember(Name = "disabled", IsRequired=false)]
		public bool Disabled { get; set; }


	}
}

