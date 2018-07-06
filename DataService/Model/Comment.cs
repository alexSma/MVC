﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Model
{
    public class Comment
    {
        public int Id { set; get; }
        public DateTime CreatedAt { set; get; }
        public string Body { set; get; }
        public int UserId { set; get; }
        public int PostId { set; get; }
        public int Likes { set; get; }
    }
}
