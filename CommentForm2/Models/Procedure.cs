using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CommentForm2
{
    public class Procedure
    {
        [Key]
        public int ProcedureID { get; set; }

        public string Name { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public int Priority { get; set; }

       
    }
}