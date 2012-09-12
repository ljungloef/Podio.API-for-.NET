using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Conversation 
	{


		[DataMember(Name = "conversation_id", IsRequired=false)]
		public int ConversationId { get; set; }


		[DataMember(Name = "subject", IsRequired=false)]
		public string Subject { get; set; }


		[DataMember(Name = "text", IsRequired=false)]
		public string Text { get; set; }


		[DataMember(Name = "participants", IsRequired=false)]
		public string[] Participants { get; set; }


		[DataMember(Name = "file_ids", IsRequired=false)]
		public string[] FileIds { get; set; }


		[DataMember(Name = "embed_id", IsRequired=false)]
		public int EmbedId { get; set; }


		[DataMember(Name = "embed_file_id", IsRequired=false)]
		public int EmbedFileId { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public DateTime CreatedOn { get; set; }


		[DataMember(Name = "embed", IsRequired=false)]
		public Embed Embed { get; set; }


		[DataMember(Name = "embed_file", IsRequired=false)]
		public FileAttachment EmbedFile { get; set; }


		[DataMember(Name = "created_by", IsRequired=false)]
		public ByLine CreatedBy { get; set; }


		[DataMember(Name = "files", IsRequired=false)]
		public List<FileAttachment> Files { get; set; }


		[DataMember(Name = "messages", IsRequired=false)]
		public List<ConversationMessage> Messages { get; set; }


		[DataMember(Name = "participants_full", IsRequired=false)]
		public List<ConversationParticipant> ParticipantsFull { get; set; }


	}
}

