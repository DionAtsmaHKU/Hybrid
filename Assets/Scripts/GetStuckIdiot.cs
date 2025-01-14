using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetStuckIdiot : MonoBehaviour
{
    [SerializeField] GameObject paddle;
    [SerializeField] Collider col;
    [SerializeField] Rigidbody boatRb;
    [SerializeField] BoatMovement boat;

    private void OnTriggerEnter(Collider other)
    {
        paddle.SetActive(true);
        col.enabled = true;
        boatRb.velocity = Vector3.zero;
        boat.speed = 0;
    }
}
