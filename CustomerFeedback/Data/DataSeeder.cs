using Microsoft.EntityFrameworkCore;

namespace CustomerFeedback.Data
{
    public static class DataSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                context.Database.Migrate();

                if (!context.CustomerFeedbackEntries.Any())
                {
                    context.CustomerFeedbackEntries.AddRange(
                        new CustomerFeedback
                        {
                            CustomerName = "Lester",
                            FeedbackMessage = "Feedback Message 1",
                            DateSubmitted = DateTime.Now.AddDays(-5)
                        },
                        new CustomerFeedback
                        {
                            CustomerName = "Chester",
                            FeedbackMessage = "Feedback Message 2",
                            DateSubmitted = DateTime.Now.AddDays(-3)
                        },
                        new CustomerFeedback
                        {
                            CustomerName = "Barney",
                            FeedbackMessage = "Feedback Message 3",
                            DateSubmitted = DateTime.Now.AddDays(-2)
                        },
                        new CustomerFeedback
                        {
                            CustomerName = "Dyson",
                            FeedbackMessage = "Feedback Message 4",
                            DateSubmitted = DateTime.Now.AddDays(-1)
                        }
                    );

                    context.SaveChanges();
                }
            }
        }
    }
}
