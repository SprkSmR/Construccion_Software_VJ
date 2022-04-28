using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modificarSalud : MonoBehaviour
{
    [SerializeField] public float tiempoEfecto;
    [SerializeField] int efecto;

    private float tiempoRestante;
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player"){
            other.GetComponent<jugador>().salud -= efecto;
            other.GetComponent<jugador>().sufrir();
        }   
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player"){
            other.gameObject.GetComponent<jugador>().salud -= efecto;
            other.gameObject.GetComponent<jugador>().sufrir();
        }   
    }

    private void OnTriggerStay2D(Collider2D other) {
        if (other.tag == "Player"){
            provocarEfecto(ref other.GetComponent<jugador>().salud);
            other.GetComponent<jugador>().sufrir();
        }   
    }

    private void OnCollisionStay2D(Collision2D other) {
        if (other.gameObject.tag == "Player"){
            provocarEfecto(ref other.gameObject.GetComponent<jugador>().salud);
            other.gameObject.GetComponent<jugador>().sufrir();
        }   
    }

    private void provocarEfecto(ref int saludJugador){
        if (tiempoRestante <= 0){
            saludJugador -= efecto;
            tiempoRestante = tiempoEfecto;
        }
        else{
            tiempoRestante -= Time.deltaTime;
        }
    }
}