using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jugador : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] float salto;
    [SerializeField] public int salud;
    [SerializeField] Transform tPiso;
    [SerializeField] LayerMask lPiso;
    [SerializeField] Slider barraSalud;
    [SerializeField] public Text contadorCodigos;
    [SerializeField] public Text listaCodigos;

    Animator anim;
    Rigidbody2D cuerpo;
    bool varDerecha = true;
    bool tocaPiso = false;
    float sPiso = 0.2f;
    float movimiento;

    public int codigosAcumulados;
    public int[] inventario = {0,0,0,0,0};

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        cuerpo = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        barraSalud.value = salud;
        anim.SetFloat("mov", Mathf.Abs(movimiento));
        anim.SetInteger("salud", salud);
        if (movimiento>0 && !varDerecha){
            Girar();
        }
        else if (movimiento<0 && varDerecha){
            Girar();
        }
        tocaPiso = Physics2D.OverlapCircle(tPiso.position, sPiso, lPiso);
        anim.SetBool("tocaPiso", tocaPiso);
        if (!tocaPiso){
            return;
        }
        cuerpo.velocity = new Vector2(movimiento*velocidad, cuerpo.velocity.y);
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

    public void sufrir(){
        anim.SetTrigger("recibeDano");
    }
}
