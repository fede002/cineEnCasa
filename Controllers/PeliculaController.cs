using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using cineEnCasaMVC.Models;
using cineEnCasaMVC.Entidades;

namespace cineEnCasaMVC.Controllers
{
    public class PeliculaController : Controller
    {
        public IActionResult Index()
        {
            List<Pelicula> peliculas = new List<Pelicula>();
            for (int i = 0; i < 50; i++)
            {
                var peli = new Pelicula("Jurassic World: Fallen Kingdom (2018)");
                //peli.titulo = "Jurassic World: Fallen Kingdom (2018)";
                peli.url = "https://ytstvmovies.xyz/jurassic-world-fallen-kingdom-2018";
                peli.imagen = "https://image.tmdb.org/t/p/w185/c9XxwwhPHdaImA2f1WEfEsbhaFB.jpg";
                peli.puntaje = 6.2;
                peli.trailer = "https://youtu.be/vn9mMeWcgoM";
                peli.id = System.Guid.NewGuid().ToString();
                peli.tipo = TiposDePelicula.CienciaFiccion;
                peliculas.Add(peli);
            }            

            ViewBag.cantidadPeliculas = peliculas.Count;
            return View(peliculas);
        }

    }
}