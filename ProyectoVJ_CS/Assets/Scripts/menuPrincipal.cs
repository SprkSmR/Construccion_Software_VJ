using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPrincipal : MonoBehaviour
{
    public void Comenzar(){
        SceneManager.LoadScene("Scenes/nivel1");
        Time.timeScale = 1f;
        tiempo.tiempoTranscurrido = 0;
    }

    public void Creditos(){
        SceneManager.LoadScene("Scenes/creditos");
        Time.timeScale = 1f;
    }
}
