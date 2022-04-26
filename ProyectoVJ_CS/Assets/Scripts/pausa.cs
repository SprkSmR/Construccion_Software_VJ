using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausa : MonoBehaviour
{
    [SerializeField] KeyCode botonPausa = KeyCode.Escape;
    [SerializeField] GameObject panel;

    bool juegoPausado = false;
    
    void Start() {
        panel.SetActive(false);
        juegoPausado = false; 
    }

    void Update()
    {
        if (!Input.GetKeyDown(botonPausa)){
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
        if (Time.timeScale == 1f){
            panel.SetActive(true);
            juegoPausado = true;
            Time.timeScale = 0f;
        }
    }
}
