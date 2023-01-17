using XR_EjercicioHamburguesa.Models;

namespace XR_EjercicioHamburguesa.Views;

public partial class BurgerListPage : ContentPage
{
    public BurgerListPage()
    {
        InitializeComponent();
        List<Burger> burger = App.XRBurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }

    async void XROnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BurgerItemPage));
    }

    public void XRUpdate()
    {
        List<Burger> burger = App.XRBurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        {
            XRUpdate();
        }
    }
}