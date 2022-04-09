using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    [SerializeField] protected float velocidadMovimiento;
    [SerializeField] private float rangoMovimiento;
    [SerializeField] protected bool patrullando;
    private bool puedeGirar;
    [SerializeField] private float distanciaAlejado;
    [SerializeField] private float rangoAbsoluto;
    private float distanciaOrigen {get => transform.position.x - transform.parent.position.x;}
    private Rigidbody2D rb;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update(){
        if (!patrullando){
            return;
        }
        distanciaAlejado = Mathf.Abs(distanciaOrigen);
        rangoAbsoluto = Mathf.Abs(rangoMovimiento);
        if (distanciaAlejado >= rangoAbsoluto){
            regresar();
            return;
        }
        moverse();
    }

    private void moverse(){
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.parent.position.x + rangoMovimiento, transform.position.y), velocidadMovimiento * Time.deltaTime);
        puedeGirar = true;
    }

    public void regresar(){
        if (!puedeGirar){
            return;
        }
        puedeGirar = !puedeGirar;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
        rangoMovimiento *= -1;
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.parent.position.x, transform.position.y), velocidadMovimiento * Time.deltaTime);
        patrullando = true;
    }
}