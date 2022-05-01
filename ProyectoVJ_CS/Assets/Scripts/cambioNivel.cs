using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioNivel : MonoBehaviour
{
    [SerializeField] private string nombreEscena;
    [SerializeField] AudioSource efectos;

    private string cambioEscena = "Scenes/";
    
    public void Cambio(){
        efectos.Play();
        cambioEscena += nombreEscena;
        SceneManager.LoadScene(cambioEscena);
    }
}
