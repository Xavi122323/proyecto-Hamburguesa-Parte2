using XR_EjercicioHamburguesa.Models;
using XR_EjercicioHamburguesa.Data;

namespace XR_EjercicioHamburguesa.Views;
[QueryProperty("Item", "Item")]
public partial class BurgerItemPage : ContentPage
{
    public Burger Item
    {
        get => BindingContext as Burger;
        set => BindingContext = value;
    }
    public BurgerItemPage()
    {
        InitializeComponent();
    }
    private void XROnSaveClicked(object sender, EventArgs e)
    {
        App.XRBurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("///BurgerListPage");
    }

    private void XROnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("///BurgerListPage");
    }

    private void XROnDeleteClicked(object sender, EventArgs e)
    {
        
        Shell.Current.GoToAsync("///BurgerListPage");
    }
}