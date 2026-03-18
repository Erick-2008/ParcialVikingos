namespace Vikingos;

public class AldeaAmurallada : Aldea
{
    private int minimoVikingos;

    public AldeaAmurallada(int crucifijos, int minimo) : base(crucifijos)
    {
        minimoVikingos = minimo;
    }

    public override bool ValeLaPena(Expedicion e)
    {
        return base.ValeLaPena(e) && e.CantidadVikingos() >= minimoVikingos;
    }
}