using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;
using Unity.VisualScripting;

public class RaycastAttack : NetworkBehaviour
{
    public float Damage = 10;
    public PlayerMovement playerMovement;


    // Update is called once per frame
    void Update()
    {
        if(!HasStateAuthority)
            return;

        Ray ray = playerMovement.Camera.ScreenPointToRay(Input.mousePosition);
        ray.origin += playerMovement.Camera.transform.forward;

        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.DrawRay(ray.origin, ray.direction * 10, Color.red, 1.0f);

            if(Physics.Raycast(ray.origin, ray.direction, out var hit))
            {
                if(hit.transform.TryGetComponent<Health>(out var health))
                {
                    health.DealDamageRpc(Damage);
                }
            }
        }
        
    }
}