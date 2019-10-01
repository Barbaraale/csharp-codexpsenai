using System;

namespace Cadastrar_mvc.Models
{
    public class BaseModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataCriacao { get; set; }
    }
}