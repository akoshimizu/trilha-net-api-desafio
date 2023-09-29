using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrilhaApiDesafio.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Necessário incluir o título.")]
        [MinLength(3, ErrorMessage = "Quantidade min de caracteres: 3")]
        [StringLength(20, ErrorMessage = "Quantidade max de caracteres: 20")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Necessário incluir a descrição.")]
        [MinLength(5, ErrorMessage = "Quantidade max de caracteres: 5")]
        [StringLength(200, ErrorMessage = "Quantidade max de caracteres: 200")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Necessário incluir a data.")]
        [DataType(DataType.DateTime)]
        public DateTime Data { get; set; }
        [Required(ErrorMessage = "Necessário incluir o status.")]
        public EnumStatusTarefa Status { get; set; }
    }
}