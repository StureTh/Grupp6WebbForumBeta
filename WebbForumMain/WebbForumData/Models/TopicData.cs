using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebbForumData.Models
{
    public class TopicData
    {
        [Key]
        public Guid TopicId { get; set; }
        public string TopicTitle { get; set; }

        public Guid SubForumid { get; set; }

    }
}