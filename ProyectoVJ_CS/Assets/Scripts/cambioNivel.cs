using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioNivel : MonoBehaviour
{
    [SerializeField] private string nombreEscena;
    private string cambioEscena = "Scenes/";
    
    public void Cambio(){
        cambioEscena += nombreEscena;
        SceneManager.LoadScene(cambioEscena);
    }
}
