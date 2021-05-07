using System;
using corCineEnCasa.Entidades;

namespace hola_mundo
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var peli = new Peliculas("Jurassic World: Fallen Kingdom (2018)");
            //peli.titulo = "Jurassic World: Fallen Kingdom (2018)";
            peli.url = "https://ytstvmovies.xyz/jurassic-world-fallen-kingdom-2018";
            peli.imagen = "https://image.tmdb.org/t/p/w185/c9XxwwhPHdaImA2f1WEfEsbhaFB.jpg";
            peli.puntaje = 6.2;
            peli.trailer = "https://youtu.be/vn9mMeWcgoM";
            peli.tipo = TiposDePeliculas.CienciaFiccion;
            Console.WriteLine("La ultima de jurassic: " + peli.titulo);
        }
    }
}
