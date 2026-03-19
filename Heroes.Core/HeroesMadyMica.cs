using Microsoft.VisualStudio.TestTools.UnitTesting;

// Que CalcularPotencia() devuelva el nivel de entrenamiento
// Test para Individuo
public class IndividuoTest 
{
    [TestMethod]
    public void CalcularPotenciaDevuelveNivelDeEntrenamiento()
    {
        Individuo i = new Individuo();
        i.NivelDeEntrenamiento = 10;

        int resultado = i.CalcularPotencia();

        Assert.AreEqual(10, resultado);
    }
}

// Que el método realmente aumente el entrenamiento
// Test para MejorarPoder
public void MejorarPoderAumentaNivelDeEntrenamiento()
{
    Individuo i = new Individuo();
    i.NivelDeEntrenamiento = 5;

    i.MejorarPoder();

    Assert.AreEqual(6, i.NivelDeEntrenamiento);
}

// Que la potencia sea: potencia del poder + entrenamiento del héroe
// Test de Superfuerza
public void SuperfuerzaSumaPotenciaYEntrenamiento()
{
    Heroe h = new Heroe();
    h.NivelDeEntrenamiento = 10;

    Superfuerza sf = new Superfuerza();
    sf.Potencia = 5;

    int resultado = sf.CalcularPotencia(h);

    Assert.AreEqual(15, resultado);
}
//Test de PoderMistico
public void PoderMisticoSumaTodosLosPoderes()
{
    Heroe h = new Heroe();
    h.NivelDeEntrenamiento = 10;

    Superfuerza sf = new Superfuerza();
    sf.Potencia = 5;

    Sabiduria sab = new Sabiduria();

    PoderMistico pm = new PoderMistico();
    pm.AgregarPoder(sf);
    pm.AgregarPoder(sab);

    int resultado = pm.CalcularPotencia(h);

    Assert.AreEqual(35, resultado);
}

// Que el arma realmente se agregue a la lista
// Test para AgregarArma
public void AgregarArmaLaAgregaALaLista()
{
    Compania c = new Compania();
    Arma a = new Arma();

    c.AgregarArma(a);

    Assert.AreEqual(1, c.ArmasDispo.Count);
}