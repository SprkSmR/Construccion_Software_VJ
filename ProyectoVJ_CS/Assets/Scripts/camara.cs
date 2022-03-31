using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform Jugador;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(Jugador.position.x, Jugador.position.y, -10f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(Jugador.position.x, Jugador.position.y, -10f);
    }
}
