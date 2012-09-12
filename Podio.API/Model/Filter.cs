using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Filter 
	{


		[DataMember(Name = "filter_id", IsRequired=false)]
		public int FilterId { get; set; }


		[DataMember(Name = "name", IsRequired=false)]
		public string Name { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public DateTime CreatedOn { get; set; }


		[DataMember(Name = "items", IsRequired=false)]
		public int Items { get; set; }


		[DataMember(Name = "sort_by", IsRequired=false)]
		public string SortBy { get; set; }


		[DataMember(Name = "sort_desc", IsRequired=false)]
		public string SortDesc { get; set; }


		[DataMember(Name = "filters", IsRequired=false)]
		public Dictionary<string,string> Filters { get; set; }


		[DataMember(Name = "created_by", IsRequired=false)]
		public User CreatedBy { get; set; }


	}
}

