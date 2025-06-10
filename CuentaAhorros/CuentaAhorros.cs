namespace CuentaAhorrosNamespace
{
    public class CuentaAhorros 
    {
        public bool ValidarRetiro(bool cuentaActiva, decimal saldo, decimal montoSolicitado, decimal limiteRetiro, bool cuentaBloqueada, bool montoMultiploDe10)
        {
            if (!cuentaActiva)
                return false;

            if (saldo < montoSolicitado)
                return false;

            if (montoSolicitado > limiteRetiro)
                return false;

            if (cuentaBloqueada)
                return false;

            if (!montoMultiploDe10)
                return false;

            return true;
        }
    }
}
