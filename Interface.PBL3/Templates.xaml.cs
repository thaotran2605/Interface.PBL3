namespace Interface.PBL3;

public partial class Templates : ResourceDictionary
{
    public Templates()
    {
        InitializeComponent();
    }

    private async void OnHomeTapped(object sender, EventArgs e)
        => await Shell.Current.GoToAsync("//MainPage");

    private async void OnOrderTapped(object sender, EventArgs e)
        => await Shell.Current.GoToAsync("//OrderPage");

    private async void OnOrderListTapped(object sender, EventArgs e)
        => await Shell.Current.GoToAsync("//DSOrderPage");

    private async void OnUuDaiTapped(object sender, EventArgs e)
        => await Shell.Current.GoToAsync("//UuDaiPage");

    private async void OnDoanhThuTapped(object sender, EventArgs e)
        => await Shell.Current.GoToAsync("//DoanhThuPage");
}
