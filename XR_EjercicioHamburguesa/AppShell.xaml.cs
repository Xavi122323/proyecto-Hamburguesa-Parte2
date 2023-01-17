using XR_EjercicioHamburguesa.Views;

namespace XR_EjercicioHamburguesa;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(BurgerItemPage), typeof(BurgerItemPage));
    }
}
