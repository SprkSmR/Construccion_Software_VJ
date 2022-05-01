using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour
{
    [SerializeField] GameObject jugador;
    [SerializeField] GameObject panelDerrota;
    [SerializeField] GameObject panelVictoria;
    [SerializeField] Text contadorTiempo;
    private int[] inventarioJugador;
    private int saludJugador;
    private float tiempoNivel;

    void Start()
    {   
        tiempoNivel = 0f;
        Time.timeScale = 1f;
        inventarioJugador = jugador.GetComponent<jugador>().inventario;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0f){
            return;
        }
        tiempoNivel += Time.deltaTime;
        contadorTiempo.text = tiempoNivel.ToString() + " s";
        if (comprobarDerrota()){
            tiempo.tiempoTranscurrido += tiempoNivel;
            panelDerrota.SetActive(true);
            Time.timeScale = 0f;
        }
        if (comprobarVictoria()){
            tiempo.tiempoTranscurrido += tiempoNivel;
            panelVictoria.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    bool comprobarVictoria()
    {
        for (int i = 0; i < 5; i++){
            if (inventarioJugador[i] == 0){
                return false;
            }
        }
        return true;
    }

    bool comprobarDerrota()
    {
        saludJugador = jugador.GetComponent<jugador>().salud;
        if (saludJugador <= 0){
            return true;
        }
        return false;
    }
}