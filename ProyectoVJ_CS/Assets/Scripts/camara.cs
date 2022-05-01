using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    [SerializeField] GameObject objetivo;
    [SerializeField] float velocidadCamara;
    [SerializeField] float alejamiento;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(objetivo.transform.position.x, objetivo.transform.position.y, alejamiento);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(objetivo.transform.position.x, objetivo.transform.position.y, alejamiento), velocidadCamara * Time.deltaTime);
        if (objetivo.tag != "Player"){
            return;
        }
        if (objetivo.GetComponent<jugador>().tocaPiso){
            this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(objetivo.transform.position.x, objetivo.transform.position.y + 0.314f, alejamiento), velocidadCamara * Time.deltaTime);
            //this.transform.position = new Vector3(Jugador.transform.position.x, Jugador.transform.position.y + 0.314f, -10f);
        }
    }
}
