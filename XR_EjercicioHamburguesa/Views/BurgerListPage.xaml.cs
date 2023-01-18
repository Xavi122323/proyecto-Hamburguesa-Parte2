using XR_EjercicioHamburguesa.Models;

namespace XR_EjercicioHamburguesa.Views;

public partial class BurgerListPage : ContentPage
{
    public BurgerListPage()
    {
        InitializeComponent();
        List<Burger> burger = App.XRBurgerRepo.GetAllBurgers();
        BindingContext = this;
        burgerList.ItemsSource = burger;
    }

    async void XROnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object>
        {
            ["Item"] = new Burger()
        });
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

    async void burgerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object>
        {
            ["Item"] = (Burger)e.CurrentSelection.FirstOrDefault()
        });

    }
}