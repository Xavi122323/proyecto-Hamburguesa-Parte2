using XR_EjercicioHamburguesa.Data;

namespace XR_EjercicioHamburguesa;

public partial class App : Application
{
    public static XRBurgerDatabase XRBurgerRepo { get; private set; }

    public App(XRBurgerDatabase repo)
    {
        InitializeComponent();

        MainPage = new AppShell();

        XRBurgerRepo = repo;
    }
}
