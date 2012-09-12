using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class QuestionOption 
	{


		[DataMember(Name = "question_option_id", IsRequired=false)]
		public int QuestionOptionId { get; set; }


		[DataMember(Name = "text", IsRequired=false)]
		public string Text { get; set; }


	}
}

