namespace Heroes.Core.Poderes;

public abstract class Poder
{
    internal abstract ushort Potencia(Heroe heroe);
    internal abstract void GanarPelea(Empleado oponente);
}
