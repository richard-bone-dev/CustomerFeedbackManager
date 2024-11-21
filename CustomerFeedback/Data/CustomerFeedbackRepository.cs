using Microsoft.EntityFrameworkCore;

namespace CustomerFeedback.Data
{
    public class CustomerFeedbackRepository : ICustomerFeedbackRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CustomerFeedbackRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CustomerFeedback>> GetAllCustomerFeedbackAsync()
        {
            return await _dbContext.CustomerFeedbackEntries.ToListAsync();
        }
    }
}
