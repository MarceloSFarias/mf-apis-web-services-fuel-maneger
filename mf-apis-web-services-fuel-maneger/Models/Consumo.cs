using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_apis_web_services_fuel_maneger.Models
{
    [Table("Consumo")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public string Valor { get; set;}
        [Required]
        public  tipoCombustivel Tipo { get; set;}

        [Required]
        public int VeiculoId { get;set;}

        public Veiculo Veiculo { get; set; }

    }

    public enum tipoCombustivel
    {
        Diesel,
        Etanol,
        Gasolina
    }
}
