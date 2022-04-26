using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMaster : MonoBehaviour
{
    [SerializeField] GameObject jugador;
    [SerializeField] GameObject panelDerrota;
    [SerializeField] GameObject panelVictoria;
    private int[] inventarioJugador;
    private int saludJugador;

    void Start()
    {
        Time.timeScale = 1f;
        inventarioJugador = jugador.GetComponent<jugador>().inventario;
    }

    // Update is called once per frame
    void Update()
    {
        if (comprobarDerrota()){
            panelDerrota.SetActive(true);
            Time.timeScale = 0f;
        }
        if (comprobarVictoria()){
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