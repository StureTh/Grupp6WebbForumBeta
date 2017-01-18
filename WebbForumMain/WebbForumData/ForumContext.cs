using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebbForumData.Models;

namespace WebbForumData
{
    public class ForumContext: DbContext
    {
        public DbSet<SubForumData> SubForums { get; set; }

        public DbSet<TopicData> Topics { get; set; }

        public DbSet<ThreadData> Threads { get; set; }

    }
}