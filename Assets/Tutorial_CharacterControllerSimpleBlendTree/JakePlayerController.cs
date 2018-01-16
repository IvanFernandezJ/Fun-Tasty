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
        


		// Recogemos data del input
		float giro = Input.GetAxis ("Horizontal");
		float avance = Input.GetAxis ("Vertical");

		// Aplicamos data al movimiento del personaje (GameObject)
		if (giro != 0)		transform.Rotate (0, giro * turnSpeed * Time.deltaTime, 0);
		if (avance != 0)	transform.Translate (0,0, avance * speed * Time.deltaTime);

		// Pasa el valor para la animacion
		anim.SetFloat ("speed", avance);

        if (Input.GetKey(KeyCode.Space))
        {
            jump();
            
        }
    

        Vector3 gerak = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rg.AddForce(gerak * speed);



        
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
