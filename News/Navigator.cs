using News.ViewModels;

namespace News
{
    public class Navigator : INavigate
    {
        public async Task NavigateTo(string route) => await Shell.Current.GoToAsync(route);
        

        public async Task PopModal() => await Shell.Current.Navigation.PopModalAsync();
        

        public async Task PushModel(Page page)
        {
            await Shell.Current.Navigation.PushModalAsync(page);
        }
    }
}
