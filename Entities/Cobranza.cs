namespace INVERSER_Cobranza_API.Entities
{
    public class Cobranza
    {
        public int Id { get; set; }
        public string Asegurado { get; set; } = string.Empty;
        public int IdRamo { get; set; }
        public string NumPoliza { get; set; } = string.Empty;
        // public DateTime InicioPoliza { get; set; }
        // public DateTime TerminoPoliza { get; set; }
        // public int IdPeriodicidad { get; set; }
        // public int IdConducto { get; set; }
        // public int IdEstatusCobro { get; set; }
        // public int IdCompania { get; set; }
        // public string Plan { get; set; } = string.Empty;
        // public int IdEstatusPlan { get; set; }
        // public int IdTipoPoliza { get; set; }
        // public int IdMoneda { get; set; }
        // public string PrimaTotal { get; set; } = string.Empty;
        // public string PrimaNeta { get; set; } = string.Empty;
        // public string Psfp { get; set; } = string.Empty;

        // public string Usuario { get; set; } = string.Empty;
    }
}