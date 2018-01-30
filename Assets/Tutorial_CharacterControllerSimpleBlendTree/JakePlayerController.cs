using UnityEngine;
using System.Collections;

public class JakePlayerController : MonoBehaviour {

    public float speed = 7.0f;
    public float turnSpeed = 300.0f;

    public Rigidbody rg;
    public float jumpSpeed;
    public LayerMask groundLayers;

    public bool isGrounded = true;


    Animator anim;

    public string ejeh = "Horizontal_1";

    public KeyCode salto = KeyCode.Space;

    public string attack_1 = "c";
    public string attack_2 = "v";
<<<<<<< HEAD
=======

>>>>>>> 7ca4aae2e865686553dc28edb32c344092b90d11

    public GameObject respawnpoint;
    



    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        rg = GetComponent<Rigidbody>();
<<<<<<< HEAD
=======

>>>>>>> 7ca4aae2e865686553dc28edb32c344092b90d11


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

        // Aplicamos data al movimiento del personaje (GameObject)
        //if (giro != 0)		transform.Rotate (0, giro * turnSpeed * Time.deltaTime, 0);

        if (avance != 0 /*&& isGrounded*/) transform.Translate(0, 0, avance * speed * Time.deltaTime);

        // Pasa el valor para la animacion
        anim.SetFloat("speed", avance);

        if (Input.GetKey(salto))
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
        if (isGrounded)
        {
            Vector3 atas = new Vector3(0, 1, 0);
            rg.AddForce(atas * jumpSpeed);
            isGrounded = false;
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;

    }

<<<<<<< HEAD
 
    public void Respawn()
    {
        this.transform.position = respawnpoint.transform.position;
        rg.velocity = new Vector3(0, 0, 0);
        
    }
=======



>>>>>>> 7ca4aae2e865686553dc28edb32c344092b90d11
}
