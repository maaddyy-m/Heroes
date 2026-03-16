namespace Heroes.Core.Poderes;

public class SuperFuerza(ushort nivel) : Poder
{
    public ushort Nivel { get; private set; } = nivel;

    internal override void GanarPelea(Empleado oponente)
        => Nivel++;

    internal override ushort Potencia(Heroe heroe) => Nivel;
}
