using System.ComponentModel.DataAnnotations;

namespace CustomerFeedback.Data
{
    public class CustomerFeedback
    {
        [Key]
        public int FeedbackID { get; set; }
        public string CustomerName { get; set; }
        public string FeedbackMessage { get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}
