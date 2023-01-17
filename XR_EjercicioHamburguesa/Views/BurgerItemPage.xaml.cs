using XR_EjercicioHamburguesa.Models;
using XR_EjercicioHamburguesa.Data;

namespace XR_EjercicioHamburguesa.Views;

public partial class BurgerItemPage : ContentPage
{
    Burger Item = new Burger();
    BurgerListPage list = new BurgerListPage();
    bool _flag;
    public BurgerItemPage()
    {
        InitializeComponent();
    }
    private void XROnSaveClicked(object sender, EventArgs e)
    {
        Item.XRName = XRnameB.Text;
        Item.XRDescription = XRdescB.Text;
        Item.XRWithExtraCheese = _flag;
        App.XRBurgerRepo.AddNewBurger(Item);
        list.XRUpdate();
        Shell.Current.GoToAsync("///BurgerListPage");
    }

    private void XROnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("///BurgerListPage");
        list.XRUpdate();
    }

    private void XROnCheckBoxCheckedChanged(object sender,CheckedChangedEventArgs e)
    {
        _flag = e.Value;
    }
}