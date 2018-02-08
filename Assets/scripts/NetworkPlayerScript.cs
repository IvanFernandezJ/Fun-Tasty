using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class NetworkPlayerScript : NetworkBehaviour {

    public JakePlayerController Controlador;
    public Player1Health Empujometro;

    public override void OnStartLocalPlayer()
    {
        Controlador.enabled = true;
        Empujometro.enabled = true;

        gameObject.name = "LOCAL Player";
        base.OnStartLocalPlayer();
    }


}
