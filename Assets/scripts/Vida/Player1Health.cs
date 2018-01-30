using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Health : MonoBehaviour
{

    public float max_Health = 100f;     //Vida maxima del personaje
    public float cur_Health = 0f;       //Vida actual del personaje
    public GameObject healthBar;        //Añadir seleccion de objeto vida(bar) en el inspector


    // Use this for initialization
    void Start()
    {
        cur_Health = max_Health; //Fija vida actual al comienzo del combate con vida maxima
        InvokeRepeating("OnCollisionEnter", 1f, 1f); //Probar que baja la vida


    }

    // Update is called once per frame
    void Update()
    {

    }

    //Esta funcion se utiliza para que cuando la llamas pierde vida
    /*void decreasehealth()
    {
        cur_Health -= 2f; //cada vez que se llama resta esta vida
        float calc_Health = cur_Health / max_Health;  // si cur es 80 de 100, la sethealthbar se queda en 0.8f
        SetHealthBar(calc_Health); //envia el resultado a la funcion sethealthbar
    }*/

    //sirve para establecer la nueva posicion de la barra de vida
    public void SetHealthBar(float myHealth)
    {
        //myHealth tiene que tener un valor entre 0 y 1, Mathf.Clamp se usa para que no sobrepase los limites
        healthBar.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
    void OnCollisionEnter(Collision dataFromCollision) //Utiliza sistema de colisiones en vez de el trigger que usabamos antes
    {
        /*if (dataFromCollision.gameObject.name == "Player_1") //Utiliza el player para que le baje la vida
        {
            cur_Health -= 2f; //cada vez que se llama resta esta vida
            float calc_Health = cur_Health / max_Health;  // si cur es 80 de 100, la sethealthbar se queda en 0.8f
            SetHealthBar(calc_Health); //envia el resultado a la funcion sethealthbar
            Debug.Log("Vida_Player_1_-2HP"); //Muestra quien quita vida
        }*/
        if (dataFromCollision.gameObject.name == "Player_2") //Utiliza el player para que le baje la vida
        {
            cur_Health -= 4f; //cada vez que se llama resta esta vida
            float calc_Health = cur_Health / max_Health;  // si cur es 80 de 100, la sethealthbar se queda en 0.8f
            SetHealthBar(calc_Health); //envia el resultado a la funcion sethealthbar
            Debug.Log("Vida_Player_2_-4HP"); //Muestra quien quita vida
        }
    }

}