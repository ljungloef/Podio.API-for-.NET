using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Item 
	{


		[DataMember(Name = "item_id", IsRequired=false)]
		public int ItemId { get; set; }


		[DataMember(Name = "app", IsRequired=false)]
		public Dictionary<string,string> App { get; set; }


		[DataMember(Name = "external_id", IsRequired=false)]
		public string ExternalId { get; set; }


		[DataMember(Name = "title", IsRequired=false)]
		public string Title { get; set; }


		[DataMember(Name = "fields", IsRequired=false)]
		public string[] Fields { get; set; }


		[DataMember(Name = "rights", IsRequired=false)]
		public string[] Rights { get; set; }


		[DataMember(Name = "ratings", IsRequired=false)]
		public Dictionary<string,string> Ratings { get; set; }


		[DataMember(Name = "conversations", IsRequired=false)]
		public string[] Conversations { get; set; }


		[DataMember(Name = "tasks", IsRequired=false)]
		public string[] Tasks { get; set; }


		[DataMember(Name = "references", IsRequired=false)]
		public string[] References { get; set; }


		[DataMember(Name = "refs", IsRequired=false)]
		public string[] Refs { get; set; }


		[DataMember(Name = "tags", IsRequired=false)]
		public string[] Tags { get; set; }


		[DataMember(Name = "subscribed", IsRequired=false)]
		public bool Subscribed { get; set; }


		[DataMember(Name = "user_ratings", IsRequired=false)]
		public Dictionary<string,string> UserRatings { get; set; }


		[DataMember(Name = "link", IsRequired=false)]
		public string Link { get; set; }


		[DataMember(Name = "invite", IsRequired=false)]
		public Dictionary<string,string> Invite { get; set; }


		[DataMember(Name = "participants", IsRequired=false)]
		public Dictionary<string,string> Participants { get; set; }


		[DataMember(Name = "linked_account_id", IsRequired=false)]
		public int LinkedAccountId { get; set; }


		/// <summary>
		///   # linked item
		/// </summary>
		[DataMember(Name = "ref", IsRequired=false)]
		public Dictionary<string,string> Ref { get; set; }


		[DataMember(Name = "priority", IsRequired=false)]
		public float Priority { get; set; }


		[DataMember(Name = "comment_count", IsRequired=false)]
		public int CommentCount { get; set; }


		[DataMember(Name = "task_count", IsRequired=false)]
		public int TaskCount { get; set; }


		[DataMember(Name = "file_ids", IsRequired=false)]
		public string[] FileIds { get; set; }


		[DataMember(Name = "initial_revision", IsRequired=false)]
		public ItemRevision InitialRevision { get; set; }


		[DataMember(Name = "current_revision", IsRequired=false)]
		public ItemRevision CurrentRevision { get; set; }


		[DataMember(Name = "reminder", IsRequired=false)]
		public Reminder Reminder { get; set; }


		[DataMember(Name = "recurrence", IsRequired=false)]
		public Recurrence Recurrence { get; set; }


		[DataMember(Name = "linked_account_data", IsRequired=false)]
		public LinkedAccountData LinkedAccountData { get; set; }


		[DataMember(Name = "revisions", IsRequired=false)]
		public List<ItemRevision> Revisions { get; set; }


		[DataMember(Name = "files", IsRequired=false)]
		public List<FileAttachment> Files { get; set; }


		[DataMember(Name = "comments", IsRequired=false)]
		public List<Comment> Comments { get; set; }


		[DataMember(Name = "shares", IsRequired=false)]
		public List<AppStoreShare> Shares { get; set; }


	}
}

