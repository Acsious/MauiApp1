using MauiApp1.ViewModels;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        private readonly ProductsViewModel _viewModel;

        public MainPage(ProductsViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindingContext = viewModel;


        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.LoadProductAsync();
        }
    }
}