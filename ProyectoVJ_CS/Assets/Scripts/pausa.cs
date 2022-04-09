using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausa : MonoBehaviour
{
    bool juegoPausado = false;
    [SerializeField] GameObject panel;

    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Escape)){
            return;
        }

        if (juegoPausado){
            Reanudar();
        }
        else{
            Pausar();
        }
    }

    public void Reanudar(){
        panel.SetActive(false);
        juegoPausado = false;
        Time.timeScale = 1f;
    }

    public void Pausar(){
        panel.SetActive(true);
        juegoPausado = true;
        Time.timeScale = 0f;
    }

    public void Menu(){
        SceneManager.LoadScene("Scenes/menuPrincipal");
    }

    public void Salir(){
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
