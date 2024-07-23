using CoinKeeper.MVVM.ViewModels;

namespace CoinKeeper.MVVM.Views;

public partial class StatisticsPage : ContentPage
{
	public StatisticsPage()
	{
		InitializeComponent();
		BindingContext = new StatisticsViewModel();
	}

    protected override void OnAppearing()
    {
        var vm = (StatisticsViewModel)BindingContext;
        vm.GetTransactionSummary();
    }
}