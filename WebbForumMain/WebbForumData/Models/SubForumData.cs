﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WebbForumData.Models
{
    public class SubForumData
    {
        [Key]
        public Guid SubForumId { get; set; }

        public string SubForumTitle { get; set; }


    }
}