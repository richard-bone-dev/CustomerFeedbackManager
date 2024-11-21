namespace CustomerFeedback.Data
{
    public interface ICustomerFeedbackRepository
    {
        Task<List<CustomerFeedback>> GetAllCustomerFeedbackAsync();
    }
}
