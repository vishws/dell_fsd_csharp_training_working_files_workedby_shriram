﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginAPI.Models
{
    public class GetLikesDTO
    {
        public int LikeID { get; set; }
        public int UserID { get; set; }

        public int TweetID { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}