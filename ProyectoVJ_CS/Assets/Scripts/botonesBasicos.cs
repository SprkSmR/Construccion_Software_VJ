using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botonesBasicos : MonoBehaviour
{
    public void Salir(){
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void Menu(){
        SceneManager.LoadScene("Scenes/menuPrincipal");
    }
}
