using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectarColision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Piso" || other.tag == "Enemigo"){
            transform.parent.gameObject.GetComponent<jugador>().tocaPiso = true;
        }   
    }

    private void OnTriggerStay2D(Collider2D other) {
        if (other.tag == "Piso" || other.tag == "Enemigo"){
            transform.parent.gameObject.GetComponent<jugador>().tocaPiso = true;
        }   
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Piso" || other.tag == "Enemigo"){
            transform.parent.gameObject.GetComponent<jugador>().tocaPiso = false;
        }   
    }
}
