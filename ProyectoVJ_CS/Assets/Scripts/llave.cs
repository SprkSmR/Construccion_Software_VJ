using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class llave : MonoBehaviour
{
    [SerializeField] int numeroLlave;
    [SerializeField] string caracter;
    [SerializeField] Text campoFaltante;
    [SerializeField] AudioSource efectos;
    [SerializeField] AudioClip recogido;
    
    private void OnTriggerEnter2D(Collider2D other){
       if (other.tag == "Player"){
            efectos.clip = recogido;
            efectos.Play();
            other.GetComponent<jugador>().inventario[numeroLlave] = 1;
            other.GetComponent<jugador>().codigosAcumulados += 1;
            other.GetComponent<jugador>().contadorCodigos.text = other.GetComponent<jugador>().codigosAcumulados.ToString();
            other.GetComponent<jugador>().listaCodigos.text += caracter + " ";
            campoFaltante.text = caracter;
            Destroy(gameObject);
        }    
    }   
}
