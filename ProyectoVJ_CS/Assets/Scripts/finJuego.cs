using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finJuego : MonoBehaviour
{
    [SerializeField] Text contadorTiempo;
    [SerializeField] Text mensaje;
    // Start is called before the first frame update
    void Start()
    {
        contadorTiempo.text = tiempo.tiempoTranscurrido.ToString() + " s";
        if (tiempo.tiempoTranscurrido <= 5f){
            mensaje.text = "No tengo idea de como hiciste eso, pero felicidades.";
        }
        else if (tiempo.tiempoTranscurrido > 5f && tiempo.tiempoTranscurrido <= 10f){
            mensaje.text = "Muy bien hecho.";
        }
        else if (tiempo.tiempoTranscurrido > 10f && tiempo.tiempoTranscurrido <= 15f){
            mensaje.text = "Buena.";
        }
        else if (tiempo.tiempoTranscurrido > 15f && tiempo.tiempoTranscurrido <= 25f){
            mensaje.text = "Nada mal, puede mejorar.";
        }
        else if (tiempo.tiempoTranscurrido > 25f && tiempo.tiempoTranscurrido <= 60f){
            mensaje.text = "Aceptable.";
        }
        else if (tiempo.tiempoTranscurrido > 60f){
            mensaje.text = "Puedes mejorar tu tiempo.";
        }
    }
}
