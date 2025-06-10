using NUnit.Framework;
using CuentaAhorrosNamespace; 

[TestFixture]
public class CuentaAhorrosTests
{
    private CuentaAhorros _cuentaAhorros;  // Usamos la clase dentro del espacio de nombres

    [SetUp]
    public void SetUp()
    {
        _cuentaAhorros = new CuentaAhorros();  // Aquí creamos una instancia de la clase CuentaAhorros
    }

    [Test]
    public void TC1_CuentaActivaYSuficienteSaldo()
    {
        bool resultado = _cuentaAhorros.ValidarRetiro(true, 5000, 100, 1000, false, true);
        Assert.IsTrue(resultado);
    }

    [Test]
    public void TC2_CuentaInactiva()
    {
        bool resultado = _cuentaAhorros.ValidarRetiro(false, 5000, 100, 1000, false, true);
        Assert.IsFalse(resultado);
    }

    [Test]
    public void TC3_SaldoInsuficiente()
    {
        bool resultado = _cuentaAhorros.ValidarRetiro(true, 50, 100, 1000, false, true);
        Assert.IsFalse(resultado);
    }

    [Test]
    public void TC4_LimiteExcedido()
    {
        bool resultado = _cuentaAhorros.ValidarRetiro(true, 5000, 2000, 1000, false, true);
        Assert.IsFalse(resultado);
    }

    [Test]
    public void TC5_CuentaBloqueadaPorFraude()
    {
        bool resultado = _cuentaAhorros.ValidarRetiro(true, 5000, 100, 1000, true, true);
        Assert.IsFalse(resultado);
    }

    [Test]
    public void TC6_MontoNoMultiploDe10()
    {
        bool resultado = _cuentaAhorros.ValidarRetiro(true, 5000, 25, 1000, false, false);
        Assert.IsFalse(resultado);
    }
}
