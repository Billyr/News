namespace News.ViewModels
{
    public interface INavigate
    {
        Task NavigateTo(string route);
        Task PushModel(Page page);
        Task PopModal();
    }
}
