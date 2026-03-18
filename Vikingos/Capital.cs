namespace Vikingos;

public class Capital : Lugar
{
    private int defensores;
    private double riquezaTierra;

    public Capital(int defensores, double riqueza)
    {
        this.defensores = defensores;
        riquezaTierra = riqueza;
    }

    public override double CalcularBotin(Expedicion e)
    {
        int derrotados = e.CantidadVikingos();
        return derrotados * riquezaTierra;
    }

    public override bool ValeLaPena(Expedicion e)
    {
        double botin = CalcularBotin(e);
        return botin >= 3 * e.CantidadVikingos();
    }
}