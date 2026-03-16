using Heroes.Core.Poderes;
namespace Heroes.Core;

public class Heroe : Empleado
{
    public Poder Poder { get; set; }
    public Heroe(Poder poder) => Poder = poder;
    public override void GanarPelea(Empleado oponente)
        => Poder.GanarPelea(oponente);
    public override ushort Potencia()
        => (ushort)(base.Potencia() + Poder.Potencia(this));
    public override Poder OtorgarPorDerrota()
        => Poder;
}
