using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class News 
	{


		[DataMember(Name = "news_id", IsRequired=false)]
		public int NewsId { get; set; }


		[DataMember(Name = "title", IsRequired=false)]
		public string Title { get; set; }


		[DataMember(Name = "content", IsRequired=false)]
		public string Content { get; set; }


		[DataMember(Name = "link", IsRequired=false)]
		public string Link { get; set; }


		[DataMember(Name = "more", IsRequired=false)]
		public bool More { get; set; }


		[DataMember(Name = "priority", IsRequired=false)]
		public int Priority { get; set; }


		[DataMember(Name = "target_group", IsRequired=false)]
		public string TargetGroup { get; set; }


		[DataMember(Name = "locale", IsRequired=false)]
		public string Locale { get; set; }


		[DataMember(Name = "run_from", IsRequired=false)]
		public DateTime RunFrom { get; set; }


		[DataMember(Name = "run_to", IsRequired=false)]
		public DateTime RunTo { get; set; }


		[DataMember(Name = "stream_display", IsRequired=false)]
		public bool StreamDisplay { get; set; }


		[DataMember(Name = "email_display", IsRequired=false)]
		public bool EmailDisplay { get; set; }


		[DataMember(Name = "email_views", IsRequired=false)]
		public int EmailViews { get; set; }


		[DataMember(Name = "stream_views", IsRequired=false)]
		public int StreamViews { get; set; }


		[DataMember(Name = "email_clicks", IsRequired=false)]
		public int EmailClicks { get; set; }


		[DataMember(Name = "stream_clicks", IsRequired=false)]
		public int StreamClicks { get; set; }


	}
}

