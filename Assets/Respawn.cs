using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Respawn : MonoBehaviour {
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnpoint;
    public Health healthScript;


    public Text time;

    
    void Start ()
    {
        SendMessage("OnTriggerEnter");
    }
    IEnumerator OnTriggerEnter(Collider other)
    {

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

        player.transform.position = respawnpoint.transform.position;
        yield return new WaitForSeconds(2);



    }
}
