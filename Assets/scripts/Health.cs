﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{

    public Text vida;
    public Text counter;
    public int health;

    public void Menos()
    {
        health = health - 1;
    }
    public void Resta_vida ()
    {
       
        
        if (health >= 1)
        {
            //health = health - 1;
            counter.text = health.ToString();
            
        }
        else
        {
            vida.text = "Estas muerto";
            counter.text = health.ToString();
            //Hacer que el pj no reaparezca y mostrar el panel del ganador.

        }
    }



    public void Consultar_Vida()
    {
        
        /*if (health < 1)
        {
            vida.text = "Estas muerto";
            //Hacer que el pj no reaparezca y mostrar el panel del ganador.
        }*/

    }
    

    // Use this for initialization
    void Start ()
    {
        vida.text = "Vidas: ";
        counter.text = health.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
        //vida.text = "Vidas: " + health.ToString();


        /*if (health < 1)
        {
            vida.text = "Estas muerto";
            //Hacer que el pj no reaparezca y mostrar el panel del ganador.
        }*/
    }

    /*
     void Start()
    {
        SendMessage("OnTimeEnd");
    }


    IEnumerator OnTimeEnd()
    {
        
        
        yield return new WaitForSeconds(2);
        tiempo.text = "6";
        yield return new WaitForSeconds(1);
        tiempo.text = "5";
        yield return new WaitForSeconds(1);
        tiempo.text = "4";
        yield return new WaitForSeconds(1);
        tiempo.text = "3";
        yield return new WaitForSeconds(1);
        tiempo.text = "2";
        yield return new WaitForSeconds(1);
        tiempo.text = "1";
        yield return new WaitForSeconds(1);
        tiempo.text = "FINAL!";
        yield return new WaitForSeconds(2);
        tiempo.text = "MUERTE SUBITA";
        yield return new WaitForSeconds(1);
        tiempo.text = "menos 5";
        yield return new WaitForSeconds(1);
        tiempo.text = "menos 4";
        yield return new WaitForSeconds(1);
        tiempo.text = "menos 3";
        yield return new WaitForSeconds(1);
        tiempo.text = "menos 2";
        yield return new WaitForSeconds(1);
        tiempo.text = "menos 1";
        yield return new WaitForSeconds(1);
        tiempo.text = "FINAL!";
        //time.text = "PELEA! " + time.ToString();
       
        
        yield return new WaitForSeconds(2);

     */

}

