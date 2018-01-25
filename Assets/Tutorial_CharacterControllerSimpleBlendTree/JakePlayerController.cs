using UnityEngine;
using System.Collections;

public class JakePlayerController : MonoBehaviour {

	public	float		speed		= 7.0f;
	public	float		turnSpeed 	= 300.0f;

    public Rigidbody rg;
    public float jumpSpeed;
    public LayerMask groundLayers;

    public bool isGrounded = true;
    

	Animator	anim;

    
    

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

        if (Input.GetButton("C"))
        {
            Debug.Log("Golpe 1");
        }
        if (Input.GetButton("V"))
        {
            Debug.Log("Golpe 2");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Golpe 3");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Golpe 4");
        }

        // Recogemos data del input
        //float giro = Input.GetAxis ("Horizontal");
        float avance = Input.GetAxis ("Horizontal");
        avance=(Mathf.Abs(avance));

        // Aplicamos data al movimiento del personaje (GameObject)
        //if (giro != 0)		transform.Rotate (0, giro * turnSpeed * Time.deltaTime, 0);
        if (avance != 0)	transform.Translate (0,0, avance * speed * Time.deltaTime);

		// Pasa el valor para la animacion
		anim.SetFloat ("speed", avance);

        if (Input.GetKey(KeyCode.Space))
        {
            jump();
            
        }
    
        //Para repetir salto
        Vector3 gerak = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rg.AddForce(gerak * speed);


        //Para girar al pj
        Vector3 facingrotation = Vector3.Normalize(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")));
        if(facingrotation != Vector3.zero)
        {
            transform.forward = facingrotation;

        }

        
	}

    void jump()
    {
        if(isGrounded == true)
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


}
