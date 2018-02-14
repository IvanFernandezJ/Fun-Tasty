using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Respawn : MonoBehaviour {
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnpoint;
    [SerializeField] private Transform respawnpoint2;
    public Health healthScript;




    //public JakePlayerController Player;



    public Text time;
    public Text final;



    IEnumerator OnTriggerEnter(Collider Player)
    {
        //Player.GetComponent<JakePlayerController>();

        if (Player.GetComponent<JakePlayerController>() != null )//&& healthScript.health > 1)
        {
            /*if (Player.GetComponent<Health>() != null)
            {
                void Consultar_Vida

            }*/
            Debug.Log(healthScript.health + "ifgetcomponent");

            if (healthScript.health >= 1)
            {
                Debug.Log(healthScript.health + "INICIO_IF");

                Player.GetComponent<Health>().Menos();

                Player.GetComponent<Health>().Resta_vida();
                



                yield return new WaitForSeconds(2);
                time.text = "Reapareceras en " + "3";
                yield return new WaitForSeconds(1);
                time.text = "Reapareceras en " + "2";
                yield return new WaitForSeconds(1);
                time.text = "Reapareceras en " + "1";
                yield return new WaitForSeconds(1);
                time.text = "PELEA!";


                Player.GetComponent<JakePlayerController>().Respawn();
                Debug.Log(healthScript.health + "FINAL_IF");

                
            }
            /*else
            {
                final.text = "final";

            }*/
       }

 
         
        }








    }

   /*IEnumerator OnTriggerEnte(Collider Player_2)
    {
        Debug.Log("hola2");
        healthScript.health = healthScript.health - 1;
        yield return new WaitForSeconds(2);
        time.text = "Reapareceras en " + "3";
        yield return new WaitForSeconds(1);
        time.text = "Reapareceras en " + "2";
        yield return new WaitForSeconds(1);
        time.text = "Reapareceras en " + "1";
        yield return new WaitForSeconds(1);
        time.text = "PELEA! ";

        //time.text = "PELEA! " + time.ToString();

        Player_2.transform.position = respawnpoint2.transform.position;
        Player_2.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(2);



    }*/

