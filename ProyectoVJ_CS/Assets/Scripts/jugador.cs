using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{
    [SerializeField] float movimiento;
    [SerializeField] float salto;
    [SerializeField] Transform tPiso;
    [SerializeField] LayerMask lPiso;
    
    public float velocidad;
    public int salud;

    Rigidbody2D cuerpo;
    bool varDerecha = true;
    bool tocaPiso = false;
    float sPiso = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (movimiento>0 && !varDerecha){
            Girar();
        }
        else if (movimiento<0 && varDerecha){
            Girar();
        }
        tocaPiso = Physics2D.OverlapCircle(tPiso.position, sPiso, lPiso);
        cuerpo.velocity = new Vector2(movimiento*velocidad, cuerpo.velocity.y);
        if (!tocaPiso){
            return;
        }
        movimiento = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.Space)){
            cuerpo.AddForce(new Vector2(0, salto));
        }
    }

    void Girar(){
        varDerecha = !varDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }
}
