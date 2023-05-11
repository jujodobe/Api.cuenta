namespace api.cuentas.Models
{
    public class CuentaModel
    {
        public int id { get; set; }
        public string nombreCuenta { get; set; }
        public string numeroCuenta { get; set; }
        public double saldo { get; set; }
        public string moneda { get; set; }
        public double promedio { get; set; }
        public double limite { get; set; }
        public string estado { get; set; }
        public PersonaModel titular { get; set; }
    }
}
