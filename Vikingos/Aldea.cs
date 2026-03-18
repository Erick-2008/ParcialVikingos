namespace Vikingos;

public class Aldea : Lugar
{
    protected int crucifijos;

    public Aldea(int crucifijos)
    {
        this.crucifijos = crucifijos;
    }

    public override double CalcularBotin(Expedicion e)
    {
        return crucifijos;
    }

    public override bool ValeLaPena(Expedicion e)
    {
        return CalcularBotin(e) >= 15;
    }
}