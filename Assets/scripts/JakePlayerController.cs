using UnityEngine;
using System.Collections;
using System;

public class JakePlayerController : MonoBehaviour {

    public float speed = 7.0f;
    public float turnSpeed = 300.0f;

    public Rigidbody rg;
    public float jumpSpeed;
    public LayerMask groundLayers;

    public bool isGrounded = true;


    private Player1Health Player1Health;

    Animator anim;

    public string ejeh = "Horizontal_1";

    public KeyCode salto = KeyCode.Space;

    public string attack_1 = "c";
    public string attack_2 = "v";

    public GameObject respawnpoint ;
    public bool DoubleJump;
    public float delayBeforeDoubleJump;







    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        rg = GetComponent<Rigidbody>();


    }

 

    void Update()
    {

        if (Input.GetButton("C")) //Esto registra que se presiona un boton
        {
            Debug.Log("Golpe 1_Player_1"); //Esto registra que el personaje golpea
        }
        if (Input.GetButton("V"))
        {
            Debug.Log("Golpe 2_Player_1");
        }
        if (Input.GetButton(","))
        {
            Debug.Log("Golpe 1_Player_2");
        }
        if (Input.GetButton("."))
        {
            Debug.Log("Golpe 2_Player_2");
        }
        if (Input.GetMouseButtonDown(0)) //Esto registra que se pulsa el raton
        {
            Debug.Log("Golpe 3");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Golpe 4");
        }
        if (Input.GetKeyDown("1")) //Esto registra que se pula una tecla numerica
        {
            Debug.Log("Golpe 5");
        }


        // Recogemos data del input
        //float giro = Input.GetAxis ("Horizontal");
        float avance = Input.GetAxis(ejeh);
        avance = (Mathf.Abs(avance));


        if (avance != 0 /*&& isGrounded*/) transform.Translate(0, 0, avance * speed * Time.deltaTime);

        // Pasa el valor para la animacion
        anim.SetFloat("speed", avance);

        //single jump
        if (Input.GetKey(salto)&& isGrounded)
        {
            jump();


        }
        //doublejump
        if (Input.GetKey(salto) && DoubleJump)
        {
            jump();


        }

        //Para repetir salto
        Vector3 gerak = new Vector3(Input.GetAxis(ejeh), 0, 0);
        rg.AddForce(gerak * speed);


        //Para girar al pj
        Vector3 facingrotation = Vector3.Normalize(new Vector3(Input.GetAxis(ejeh), 0f, 0f));
        if (facingrotation != Vector3.zero)
        {
            transform.forward = facingrotation;

        }


    }


    void jump()
    {
        //single jump
        if (isGrounded)
        {
            Vector3 atas = new Vector3(0, 1, 0);
            rg.AddForce(atas * jumpSpeed);
            isGrounded = false;
            //StartCoroutine("waittwoseconds");  
            Invoke("EnableDobleJump", delayBeforeDoubleJump);
        }
        //doublejump
        if (DoubleJump)
        {
            Vector3 atas = new Vector3(0, 1, 0);
            rg.AddForce(atas * jumpSpeed);
            DoubleJump = false;
        }
    }

    void EnableDobleJump()
    {
        DoubleJump = true;
    }

    /*IEnumerator waittwoseconds()
    {
        yield return new WaitForSeconds(2);
        
    }*/



    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
        DoubleJump = false;

    }


    public void Respawn()
    {
        this.transform.position = respawnpoint.transform.position;
        rg.velocity = new Vector3(0, 0, 0);

    }



}