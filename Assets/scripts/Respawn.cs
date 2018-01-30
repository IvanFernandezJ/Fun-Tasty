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

    
 
    IEnumerator OnTriggerEnter(Collider Player)
    {
        //Player.GetComponent<JakePlayerController>();

        if (Player.GetComponent<JakePlayerController>() != null)
        {
            Debug.Log("hola");
            healthScript.health = healthScript.health - 1;
            yield return new WaitForSeconds(2);
            time.text = "Reapareceras en " + "3";
            yield return new WaitForSeconds(1);
            time.text = "Reapareceras en " + "2";
            yield return new WaitForSeconds(1);
            time.text = "Reapareceras en " + "1";
            yield return new WaitForSeconds(1);
            time.text = "PELEA!";
            //GameObject.Find(respawn).GetComponent <JakePlayerController>)
            //time.text = "PELEA! " + time.ToString();
            Player.GetComponent<JakePlayerController>().Respawn();

        }






    }

<<<<<<< HEAD
   /*IEnumerator OnTriggerEnte(Collider Player_2)
=======
    /*IEnumerator OnTriggerEnte(Collider Player_2)
>>>>>>> 7ca4aae2e865686553dc28edb32c344092b90d11
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
}
