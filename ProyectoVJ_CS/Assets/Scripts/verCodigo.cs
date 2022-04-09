using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class verCodigo : MonoBehaviour
{
    bool juegoPausado = false;
    [SerializeField] GameObject panel;

    void Start(){
        VerCodigo();
    }

    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.E)){
            return;
        }

        if (juegoPausado){
            Reanudar();
        }
        else{
            VerCodigo();
        }
    }

    public void Reanudar(){
        panel.SetActive(false);
        juegoPausado = false;
        Time.timeScale = 1f;
    }

    public void VerCodigo(){
        panel.SetActive(true);
        juegoPausado = true;
        Time.timeScale = 0f;
    }
}
