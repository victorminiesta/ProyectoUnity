using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject botonjugar;
    public GameObject inicioff;
    public Text jugador1, jugador2,numero;
    bool sepuedejugar,aviso22 = false ;
    public GameObject empezarjuego;
    public GameObject aviso,aviso2;
    int numeror;
    public GameObject dado1, dado2, dado3;
    public Text nombrejugador1, nombrejugador2;
    public GameObject activarpreguntas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(jugador1.text != ""&& jugador2.text !="")
        {
             sepuedejugar = true;

        }
        else
        {
            sepuedejugar = false;
          
        }
        if (jugador1.text.Equals(jugador2.text))
        {
            sepuedejugar = false;
            aviso22 = true;

        }
        if (!jugador1.text.Equals(jugador2.text))
        {
            
            aviso22 = false;

        }

        

    }
    public void fuera()
    {
        Application.Quit();
    }
    public void jugar()
    {
        inicioff.SetActive(false);
        botonjugar.SetActive(true);

    }
    public void volveralinicion()
    {
        inicioff.SetActive(true);
        botonjugar.SetActive(false);
    }
    public void empezar() { 
        if (sepuedejugar == true)
        {
            botonjugar.SetActive(false);
            empezarjuego.SetActive(true);
            aviso.SetActive(false);
            nombrejugador1.text= jugador1.text;
            nombrejugador2.text = jugador2.text;
        }
        else if (aviso22 == false)
        {
            aviso.SetActive(true);
            aviso2.SetActive(false);

        }
        if(aviso22 == true)
        {
            aviso2.SetActive(true);
            aviso.SetActive(false);
        }
        
    }
    public void girardado()
    {
        numeror = Random.Range(1, 4);
        numero.text = numeror.ToString();
        dado1.SetActive(false);
        dado2.SetActive(false);
        dado3.SetActive(false);
        Invoke("realizar", 2f);
    }
    public void imagendado()
    {

        switch (numeror)
        {
            case 1: dado1.SetActive(true);
                break;
            case 2:
                dado2.SetActive(true);
                break;
            case 3:
                dado3.SetActive(true);
                break;
        }
    }
    public void realizar()
    {
        activarpreguntas.SetActive(true);
        empezarjuego.SetActive(false);
    }

    public class Pregunta 
    {
        public string pregunta;
        public string[] respuestas;
        public int respuestasCorrectas;
    }

    /*// Crear una instancia de la clase Random
    Random preguntaAleatoria = new Random();

    // Obtener una pregunta aleatoria de la lista de Geografía
    int index = preguntaAleatoria.Next(preguntasGeografia.Count);
    Pregunta preguntaGeografia = preguntasGeografia[index];

    // Obtener una pregunta aleatoria de la lista de Biología
    index = preguntaAleatoria.Next(preguntasBiologia.Count);
    Pregunta preguntaBiologia = preguntasBiologia[index];

    // Obtener una pregunta aleatoria de la lista de Videojuegos
    index = preguntaAleatoria.Next(preguntasVideojuegos.Count);
    Pregunta preguntaVideojuegos = preguntasVideojuegos[index];
    */
    public List<Pregunta> preguntasGeografia = new List <Pregunta>()
    {
        new Pregunta(){
            pregunta = "¿Cuál es el río más largo de España?",
            respuestas = new string[] { "Ebro", "Tajo", "Duero", "Guadalquivir"},
            respuestasCorrectas = 1,
        },
        new Pregunta(){
            pregunta = "¿Cuál es la montaña más alta de la Península Ibérica?",
            respuestas = new string[] { "Monte Perdido", "Aneto", "Mulhacén", "Teide"},
            respuestasCorrectas = 3,
        },
        new Pregunta(){
            pregunta = "¿Cuál es el volcán más alto de España?",
            respuestas = new string[] { "Monte Gorbea", "Teide", "Sierra de Cebollera", "Monte Pico Viejo"},
            respuestasCorrectas = 2,
        },
    };

    public List<Pregunta> preguntasBiologia = new List <Pregunta>()
    {
        new Pregunta(){
            pregunta = "¿Qué es la fotosíntesis y en qué organismos se lleva a cabo?",
            respuestas = new string[] { "El proceso mediante el cual los organismos producen dióxido de carbono a partir de la energía solar. Se lleva a cabo en animales y plantas.", "El proceso mediante el cual los organismos producen oxígeno a partir de la energía solar. Se lleva a cabo en animales y plantas.", "El proceso mediante el cual los organismos producen energía a partir de la glucosa. Se lleva a cabo en animales y plantas.", "El proceso mediante el cual los organismos producen glucosa a partir de la energía solar. Se lleva a cabo en las plantas y en algunas bacterias."},
            respuestasCorrectas = 4,
        },
        new Pregunta(){
            pregunta = "¿Cuál es la montaña más alta de la Península Ibérica?",
            respuestas = new string[] { "Monte Perdido", "Aneto", "Mulhacén", "Teide"},
            respuestasCorrectas = 4,
        },
        new Pregunta(){
            pregunta = "¿Cuál es el pigmento que da color a la piel humana?",
            respuestas = new string[] { "Clorofila", "Melanina", "Hemoglobina", "Caroteno"},
            respuestasCorrectas = 2,
        },
    };

    public List<Pregunta> preguntasVideojuegos = new List <Pregunta>()
    {
        new Pregunta(){
            pregunta = "¿Qué videojuego se centra en la construcción de estructuras con bloques?",
            respuestas = new string[] { "Fortnite", "Minecraft", "Apex Legends", "Call of Duty"},
            respuestasCorrectas = 2,
        },
        new Pregunta(){
            pregunta = "¿Cuál es el personaje principal en el videojuego de aventura 'The Legend of Zelda'?",
            respuestas = new string[] { "Luigi", "Donkey Kong", "Link", "Zelda"},
            respuestasCorrectas = 3,
        },
        new Pregunta(){
            pregunta = "¿Cuál es el juego de carreras más popular en la serie de videojuegos 'Mario Kart'?",
            respuestas = new string[] { "Mario Kart 64", "Mario Kart: Double Dash", "Mario Kart Wii", "Mario Kart 8"},
            respuestasCorrectas = 4,
        },
    };
}
