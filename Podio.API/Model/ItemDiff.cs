using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class ItemDiff 
	{


		[DataMember(Name = "field_id", IsRequired=false)]
		public int FieldId { get; set; }


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "external_id", IsRequired=false)]
		public int ExternalId { get; set; }


		[DataMember(Name = "label", IsRequired=false)]
		public string Label { get; set; }


		[DataMember(Name = "from", IsRequired=false)]
		public string[] From { get; set; }


		[DataMember(Name = "to", IsRequired=false)]
		public string[] To { get; set; }


	}
}

