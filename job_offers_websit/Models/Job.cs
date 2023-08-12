using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace job_offers_websit.Models
{
    public class Job
    {
        public int Id { get; set; }
        [DisplayName("إسم الوظيفة")]
        public string JobTitle { get; set; }
        [DisplayName("وصف الوظيفة")]
        public string JobContent { get; set; }
        [DisplayName("صورة الوظيفة")]
        public string JobImage { get; set; }
        [DisplayName("نوع الوظيفة")]
        public int CategoryId { get; set; }// categoryId is a forgen key from category table

        public virtual Category Category { get; set; }//linking category table with jobs table (one to many) part
    }
}