using Interface.PBL3.Pages;

namespace Interface.PBL3
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(OrderPage), typeof(OrderPage));
            Routing.RegisterRoute(nameof(DSOrderPage), typeof(DSOrderPage));
            Routing.RegisterRoute(nameof(UuDaiPage), typeof(UuDaiPage));
            Routing.RegisterRoute(nameof(DoanhThuPage), typeof(DoanhThuPage));
        }
    }
}
