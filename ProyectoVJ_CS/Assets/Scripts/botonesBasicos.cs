using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botonesBasicos : MonoBehaviour
{
    [SerializeField] AudioSource efectos;

    public void Salir(){
        efectos.Play();
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void Menu(){
        efectos.Play();
        SceneManager.LoadScene("Scenes/menuPrincipal");
    }
}
