using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMaster : MonoBehaviour
{
    [SerializeField] GameObject jugador;
    private int[] inventarioJugador;
    private int saludJugador;

    void Start()
    {
        inventarioJugador = jugador.GetComponent<jugador>().inventario;
    }

    // Update is called once per frame
    void Update()
    {
        if (comprobarDerrota()){
            Debug.Log("Has perdido");
        }
        if (comprobarVictoria()){
            Debug.Log("Has ganado");
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