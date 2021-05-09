using System.Text.Json;
using System.Text.Json.Serialization;

namespace cineEnCasaMVC.Entidades
{
    public class Pelicula
    {
        //NOTA
        //atajo en vs code --> prop
        public string titulo { get; set; }
        public string url { get; set; }
        public string imagen { get; set; }
        public double puntaje { get; set; }
        public string trailer { get; set; }
        public TiposDePelicula tipo { get; set; }
        public string id { get; set; }
        public Pelicula(string titulo)
        {
            this.titulo = titulo;
        }

        public override string ToString()
        {
            string jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            });
            //return $"Titulo:{titulo}  url:{url}" ;
            return jsonString;
        }

    }
}