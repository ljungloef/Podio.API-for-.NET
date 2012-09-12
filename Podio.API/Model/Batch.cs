using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Batch 
	{


		[DataMember(Name = "batch_id", IsRequired=false)]
		public int BatchId { get; set; }


		[DataMember(Name = "name", IsRequired=false)]
		public string Name { get; set; }


		[DataMember(Name = "plugin", IsRequired=false)]
		public string Plugin { get; set; }


		[DataMember(Name = "status", IsRequired=false)]
		public string Status { get; set; }


		[DataMember(Name = "completed", IsRequired=false)]
		public int Completed { get; set; }


		[DataMember(Name = "skipped", IsRequired=false)]
		public int Skipped { get; set; }


		[DataMember(Name = "failed", IsRequired=false)]
		public int Failed { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public DateTime CreatedOn { get; set; }


		[DataMember(Name = "started_on", IsRequired=false)]
		public DateTime StartedOn { get; set; }


		[DataMember(Name = "ended_on", IsRequired=false)]
		public DateTime EndedOn { get; set; }


		[DataMember(Name = "file", IsRequired=false)]
		public FileAttachment File { get; set; }


		[DataMember(Name = "app", IsRequired=false)]
		public Application App { get; set; }


		[DataMember(Name = "space", IsRequired=false)]
		public Space Space { get; set; }


	}
}

