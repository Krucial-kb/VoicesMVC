﻿using System;
using System.Collections.Generic;

namespace VoicesWebUI.Entities
{
    public partial class Users
    {
        public Users()
        {
            PostDetails = new HashSet<PostDetails>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? ProfilePic { get; set; }
        public int? Posts { get; set; }

        public virtual PostData PostsNavigation { get; set; }
        public virtual PictureData ProfilePicNavigation { get; set; }
        public virtual ICollection<PostDetails> PostDetails { get; set; }
    }
}
