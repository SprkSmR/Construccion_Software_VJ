using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jugador : MonoBehaviour
{
    [SerializeField] public float velocidad;
    [SerializeField] public int salud;
    [SerializeField] public Text contadorCodigos;
    [SerializeField] public Text listaCodigos;
    [SerializeField] float salto;
    [SerializeField] Transform tPiso;
    [SerializeField] LayerMask lPiso;
    [SerializeField] Slider barraSalud;
    [SerializeField] AudioSource efectos;
    [SerializeField] AudioClip dolor;
    [SerializeField] AudioClip saltar;
    [SerializeField] AudioClip caminar;

    public bool tocaPiso = false;

    float movimiento;
    Animator anim;
    Rigidbody2D cuerpo;
    bool varDerecha = true;
    float sPiso = 0.1f;

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
        if (movimiento != 0){
            efectos.clip = caminar;
            efectos.Play();
        }
        else if (movimiento == 0 && efectos.clip == caminar){
            efectos.Pause();
        }
        if (Input.GetKey(KeyCode.Space)){
            efectos.clip = saltar;
            efectos.Play();
            tocaPiso = false;
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
        efectos.clip = dolor;
        efectos.Play();
        anim.SetTrigger("recibeDano");
    }
}
