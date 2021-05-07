namespace corCineEnCasa.Entidades
{
    class Peliculas
    {
        //NOTA
        //atajo en vs code --> prop
        public string titulo { get; set; }
        public string url { get; set; }
        public string imagen { get; set; }
        public double puntaje { get; set; }
        public string trailer { get; set; }
        public TiposDePeliculas tipo { get; set; }

        public Peliculas(string titulo)
        {
            this.titulo = titulo;
        }

    }
}