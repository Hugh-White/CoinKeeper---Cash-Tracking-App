namespace CoinKeeper
{
    using CoinKeeper.MVVM.Views;
    using CoinKeeper.MVVM.Models;
    using CoinKeeper.Repositories;

    public partial class App : Application
    {
        public static BaseRepository<Transaction>? TransactionsRepo { get; private set; }
        public App(BaseRepository<Transaction> _transactionsRepo)
        {
            InitializeComponent();

            TransactionsRepo = _transactionsRepo;

            MainPage = new AppContainer();
        }
    }
}
