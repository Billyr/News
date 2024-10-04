using CommunityToolkit.Mvvm.ComponentModel;

namespace News.ViewModels
{
    [ObservableObject]
    public abstract partial class BaseViewModel
    {
        public INavigate Navigation { get; init; }

        internal BaseViewModel(INavigate navigate) => Navigation = navigate;

    }
}
