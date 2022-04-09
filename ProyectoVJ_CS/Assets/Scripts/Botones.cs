using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public void Comenzar(){
        SceneManager.LoadScene("Scenes/nivelPruebas");
        Time.timeScale = 1f;
    }

    public void Salir(){
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
