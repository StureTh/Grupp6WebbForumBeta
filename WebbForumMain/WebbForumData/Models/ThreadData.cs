using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebbForumData.Models
{
    public class ThreadData
    {
        [Key]
        public Guid ThreadId { get; set; }
        public string ThreadTitle { get; set; }

        public Guid Topicid { get; set; }
        

    }
}