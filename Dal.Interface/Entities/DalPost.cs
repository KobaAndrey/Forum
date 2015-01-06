﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Dal.Interface.Entities
{
    public class DalPost : IEntity
    {
        public long Id { get; set; }
        public long AuthorId { get; set; }
        public DateTime LastEdit { get; set; }
        public string Message { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public long ResponseTo { get; set; }
        public bool IsBlocked { get; set; }
        public long TopicId { get; set; }
    }
}