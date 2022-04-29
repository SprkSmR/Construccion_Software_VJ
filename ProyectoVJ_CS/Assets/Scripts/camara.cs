using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    [SerializeField] GameObject Jugador;

    private float velocidadCamara;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(Jugador.transform.position.x, Jugador.transform.position.y, -10f);
    }

    // Update is called once per frame
    void Update()
    {
        velocidadCamara = Jugador.GetComponent<jugador>().velocidad;
        if (Jugador.GetComponent<jugador>().tocaPiso){
            this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(Jugador.transform.position.x, Jugador.transform.position.y + 0.314f, -10f), velocidadCamara * Time.deltaTime);
            //this.transform.position = new Vector3(Jugador.transform.position.x, Jugador.transform.position.y + 0.314f, -10f);
        }
        else{
            this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(Jugador.transform.position.x, Jugador.transform.position.y, -10f), velocidadCamara * Time.deltaTime);
            //this.transform.position = new Vector3(Jugador.transform.position.x, Jugador.transform.position.y, -10f);
        }
    }
}
