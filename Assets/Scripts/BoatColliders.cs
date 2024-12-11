using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatColliders : MonoBehaviour
{
    [SerializeField] Collider col;
    [SerializeField] Collider otherCol;
    [SerializeField] BoatMovement boat;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Paddle"))
        {
            boat.PaddleForward();
            col.enabled = false;
            otherCol.enabled = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Paddle"))
        {
            boat.PaddleForward();
            col.enabled = false;
            otherCol.enabled = true;
        }
    }
}
