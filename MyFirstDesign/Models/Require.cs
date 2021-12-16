using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyFirstDesign.Models
{
    [Keyless]
    public class Require
    {
        [DisplayName ("Student Name")]
        public string StudentName { get; set; }
        [DisplayName ("Request Id")]
        public int RequestId{ get; set; } 
        public string Subject { get; set; } = null!;
        [DisplayName ("Created On")]
        public DateTime CreatedOn { get; set; }
        [DisplayName ("Created By")]
        public string CreatedBy { get; set; } = null!;
        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }
        public string Status { get; set; } = null!;
        public string Action { get; set; } = null!;
    }
}
