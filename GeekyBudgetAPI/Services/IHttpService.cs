namespace GeekyBudgetAPI;

public interface IHttpService
{
    Task<string> ReadAsync();
}
