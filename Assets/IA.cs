using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class IA : MonoBehaviour {

    public GameObject Target;
   

    public Health healthScript;


    //[SerializeField] private Transform player;
   // [SerializeField] private Transform respawnpoint;


    // Use this for initialization
    /*void Start () {
		
	}
	
	// Update is called once per frame/*
	*/

    public float distance;

   /* IEnumerator OnTriggerEnter(Collider other)
    {

        healthScript.health = healthScript.health - 1;
    }*/
        void Update () {
           

            // Debug.Log();
            /*if (Vector3.Distance(Target.transform.position, transform.position) <= 2)
            {
                healthScript.health = healthScript.health - 1;
            }*/


        }
}
