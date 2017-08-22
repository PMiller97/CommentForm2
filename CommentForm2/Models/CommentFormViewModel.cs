using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommentForm2.Models
{
    public class CommentFormViewModel
    {
        public Comments Comments { get; set; }
        public Procedure Procedure { get; set; }
    }
}