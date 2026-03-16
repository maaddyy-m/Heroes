using Heroes.Core.Poderes;
namespace Heroes.Core;

public abstract class Empleado
{
    public IEnumerable<Empleado> Oponentes { get; set; } = [];
    public ushort Entrenamiento { get; set; } = 0;
    public IEnumerable<Arma> Armas { get; set; } = [];
    public abstract void GanarPelea(Empleado oponente);
    public virtual ushort Potencia()
        => (ushort)(Entrenamiento + ArmaMasPoderosa().Potencia);
    public Arma ArmaMasPoderosa()
    {
        var maxima =  Armas.MaxBy(a => a.Potencia);
        if (maxima is null)
            throw new InvalidOperationException("No hay armas");
        return maxima;
    }
    public abstract Poder OtorgarPorDerrota();
    public Empleado OponenteMasPoderoso
        => Oponentes.MaxBy(o=>o.Potencia()) ??
        throw new InvalidOperationException("No hay oponentes");
}   