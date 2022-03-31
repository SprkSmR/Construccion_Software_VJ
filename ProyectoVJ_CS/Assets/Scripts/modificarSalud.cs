using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modificarSalud : MonoBehaviour
{
    [SerializeField] public float tiempoInicioEfecto;
    [SerializeField] int efecto;

    private float tiempoEntreEfecto;
    

    private void OnTriggerStay2D(Collider2D other) {
        if (other.tag == "Player"){
            provocarEfecto(ref other.GetComponent<jugador>().salud);
        }   
    }

    private void OnCollisionStay2D(Collision2D other) {
        if (other.gameObject.tag == "Player"){
            provocarEfecto(ref other.gameObject.GetComponent<jugador>().salud);
        }   
    }

    private void provocarEfecto(ref int saludJugador){
        if (tiempoEntreEfecto <= 0){
            new WaitForSeconds(0.32f);
            saludJugador -= efecto;
            tiempoEntreEfecto = tiempoInicioEfecto;
        }
        else{
            tiempoEntreEfecto -= Time.deltaTime;
        }
    }
}