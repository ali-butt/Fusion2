using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class PlayerColor : NetworkBehaviour
{
    public MeshRenderer meshRenderer;
    [Networked] public Color NetworkedColor { get; set; }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (HasStateAuthority && Input.GetKeyDown(KeyCode.E))
        {
            // Changing the material color here directly does not work since this code is only executed on the client pressing the button and not on every client.
            NetworkedColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1);


        }
        meshRenderer.material.color = NetworkedColor;
    }
}