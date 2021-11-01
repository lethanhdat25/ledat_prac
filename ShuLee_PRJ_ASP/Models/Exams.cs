using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShuLee_PRJ_ASP.Models
{
    public class Exams
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Không được thiếu Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Không được thiếu Time Start")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan? Start { get; set; }

        [Required(ErrorMessage = "Không được thiếu Exam Date")]
        [DataType(DataType.Date)]
        public DateTime ExamDate { get; set; }

        [Required(ErrorMessage = "Không được thiếu Duration")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "Không được thiếu Class")]
        public string ClassRoom { get; set; }

        [Required(ErrorMessage = "Không được thiếu Faculty")]
        public string Faculty { get; set; }
        
        [Required(ErrorMessage = "Không được thiếu Status")]
        public string Status { get; set; }
    }
}