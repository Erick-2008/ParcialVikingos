namespace Vikingos;

public class Granjero : Vikingo
{
    public int Hijos { get; set; }
    public int Hectareas { get; set; }

    public Granjero(Casta casta, int hijos, int hectareas) : base(casta)
    {
        Hijos = hijos;
        Hectareas = hectareas;
    }

    public override bool EsProductivo()
    {
        return Hectareas >= Hijos * 2;
    }

    public bool PuedeAlimentarHijos()
    {
        return Hectareas >= Hijos * 2;
    }

    public void AgregarHijo()
    {
        Hijos++;
    }
}