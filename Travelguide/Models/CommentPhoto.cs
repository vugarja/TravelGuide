﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travelguide.Models
{
    public class CommentPhoto
    {
        public int Id { get; set; }

        public int CommentId { get; set; }

        [StringLength(200)]
        public string Photo { get; set; }

        public Comment Comment { get; set; }
    }
}