using NuevaAplicacionMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NuevaAplicacionMVC.Services
{
    public class DebateService
    {
        public List<Debate> ObtenerDebate(){
            var Debate1 = new Debate()
            {
                titulo = "Goku",
                contenido ="Goku es un ssj al que le gusta pelear",
                contenidoPreview = "<b>Goku es un ssj al que le gusta pelear</b>",
                imagen = "http://d3cprjxvoejtmm.cloudfront.net/images/2017/05/09102114/goku.png",
                autor = "Jose",
                fecha = "10-1-2017",
                destacar =true

            };
            var Debate2 = new Debate()
            {
                titulo = "vegeta",
                contenido = "Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear Vegeta es un ssj al que le gusta pelear ",
                contenidoPreview = "Vegueta es un ssj al que le gusta pelear",
                imagen = "https://vignette.wikia.nocookie.net/epicrapbattlesofhistory/images/6/6a/Ssj_vegeta_by_aznfanaticwarrior.png",
                autor = "Jose",
                fecha = "10-1-2017",
                destacar = true
            };
            var Debate3 = new Debate()
            {
                titulo = "Piccolo",
                contenido = "Piccolo es un Namekusei",
                contenidoPreview = "Piccolo es un Namekusei",
                imagen = "https://otakukart.com/wp-content/uploads/2018/01/Piccolo.jpg",
                autor = "Jose",
                fecha = "10-1-2017",
                destacar = false

            };
            var Debate4 = new Debate()
            {
                titulo = "Nappa",
                contenido = "Nappa era un ssj",
                contenidoPreview = "Nappa era un ssj",
                imagen = "https://cdn.hobbyconsolas.com/sites/navi.axelspringer.es/public/media/image/2017/10/nappa.jpg",
                autor = "Jose",
                fecha = "10-1-2017",
                destacar = false

            };
            var Debate5 = new Debate()
            {
                titulo = "Gohan",
                contenido = "Gohan es un ssj al que no le gusta pelear Gohan es un ssj al que no le gusta pelear Gohan es un ssj al que no le gusta pelear Gohan es un ssj al que no le gusta pelear Gohan es un ssj al que no le gusta pelear Gohan es un ssj al que no le gusta pelear Gohan es un ssj al que no le gusta pelear Gohan es un ssj al que no le gusta pelear Gohan es un ssj al que no le gusta pelear Gohan es un ssj al que no le gusta pelear Gohan es un ssj al que no le gusta pelear Gohan es un ssj al que no le gusta pelear Gohan es un ssj al que no le gusta pelear Gohan es un ssj al que no le gusta pelear",
                contenidoPreview = "Gohan es un ssj al que no le gusta pelear",
                imagen = "https://vignette.wikia.nocookie.net/dragonball/images/5/5c/Gohan_SSJ2_2_by_FMontel.jpg/revision/latest?cb=20120227131451",
                autor = "Jose",
                fecha = "10-1-2017",
                destacar = true

            };
            var Debate6 = new Debate()
            {
                titulo = "Krilin",
                contenido = "Krilin es un coge golpe",
                contenidoPreview = "Krilin es un coge golpe",
                imagen = "http://static.alfabetajuega.com/abj_public_files/multimedia/imagenes/201607/157465.alfabetajuega-dragon-ball-z-kai-krilin-240716.jpg",
                autor = "Jose",
                fecha = "10-1-2017",
                destacar = false

            };
            var Debate7 = new Debate()
            {
                titulo = "Freezer",
                contenido = "Freezer queria las Dragon Balls",
                contenidoPreview = "Freezer queria las Dragon Balls",
                imagen = "https://ugc.kn3.net/i/origin/http://animeclubgt.com/stuff/regalogeek/wp-content/uploads/2017/02/frieza_vector_by_elfaceitoso.png",
                autor = "Jose",
                fecha = "10-1-2017",
                destacar = true

            };
            var Debate8 = new Debate()
            {
                titulo = "Cell",
                contenido = "Cell queria ser perfecto",
                contenidoPreview = "Cell queria ser perfecto",
                imagen = "https://static.zerochan.net/Cell.%28DRAGON.BALL%29.full.454171.jpg",
                autor = "Jose",
                fecha = "10-1-2017",
                destacar = false

            };
            var Debate9 = new Debate()
            {
                titulo = "Cell perfecto",
                contenido = "Cell logro la perfeccion",
                contenidoPreview = "Cell logro la perfeccion",
                imagen = "https://otakukart.com/animeblog/wp-content/uploads/2017/01/Dragon-Ball-Super-Episode-76-Otakukart.jpg",
                autor = "Jose",
                fecha = "10-1-2017",
                destacar = true

            };
            return new List<Debate> { Debate1, Debate2, Debate3, Debate4, Debate5, Debate6, Debate7, Debate8, Debate9 };
    }
    }
}