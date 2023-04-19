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
        int numeror;
        numeror = Random.Range(1, 3);
        numero.text = numeror.ToString();
    }

}
