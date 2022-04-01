using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llave : MonoBehaviour
{
    
    [SerializeField] int numeroLlave;
    
    private void OnTriggerEnter2D(Collider2D other){
       if (other.tag == "Player"){
            other.GetComponent<jugador>().inventario[numeroLlave] = 1;
            Destroy(gameObject);
        }    
    }   
}
