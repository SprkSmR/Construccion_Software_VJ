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
        if (tiempo.tiempoTranscurrido <= 30f){
            mensaje.text = "No tengo idea de como hiciste eso, pero felicidades.";
        }
        else if (tiempo.tiempoTranscurrido > 30f && tiempo.tiempoTranscurrido <= 45f){
            mensaje.text = "Excelente.";
        }
        else if (tiempo.tiempoTranscurrido > 45f && tiempo.tiempoTranscurrido <= 60f){
            mensaje.text = "Muy bien hecho.";
        }
        else if (tiempo.tiempoTranscurrido > 60f && tiempo.tiempoTranscurrido <= 75f){
            mensaje.text = "Buen tiempo.";
        }
        else if (tiempo.tiempoTranscurrido > 75f && tiempo.tiempoTranscurrido <= 90f){
            mensaje.text = "Nada mal, puede mejorar.";
        }
        else if (tiempo.tiempoTranscurrido > 90f){
            mensaje.text = "Puedes mejorar tu tiempo.";
        }
    }
}
