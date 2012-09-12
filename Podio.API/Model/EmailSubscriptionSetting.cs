using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class EmailSubscriptionSetting 
	{


		[DataMember(Name = "digest", IsRequired=false)]
		public bool Digest { get; set; }


		[DataMember(Name = "bulletin", IsRequired=false)]
		public bool Bulletin { get; set; }


		[DataMember(Name = "reference", IsRequired=false)]
		public bool Reference { get; set; }


		[DataMember(Name = "message", IsRequired=false)]
		public bool Message { get; set; }


		[DataMember(Name = "reminder", IsRequired=false)]
		public bool Reminder { get; set; }


		[DataMember(Name = "space", IsRequired=false)]
		public bool Space { get; set; }


		[DataMember(Name = "subscription", IsRequired=false)]
		public bool Subscription { get; set; }


		[DataMember(Name = "push_notification", IsRequired=false)]
		public bool PushNotification { get; set; }


		[DataMember(Name = "push_notification_sound", IsRequired=false)]
		public bool PushNotificationSound { get; set; }


		[DataMember(Name = "push_notification_browser", IsRequired=false)]
		public bool PushNotificationBrowser { get; set; }


	}
}

