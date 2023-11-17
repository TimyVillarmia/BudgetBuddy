namespace BudgetBuddy.Models
{
    public interface IAccount
    {
        string Email { get; set; }
        string Fullname { get; set; }
        int Id { get; set; }
        string Password { get; set; }



    }
}