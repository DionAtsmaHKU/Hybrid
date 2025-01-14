using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatColliders : MonoBehaviour
{
    [SerializeField] Collider col;
    [SerializeField] Collider otherCol;
    [SerializeField] BoatMovement boat;
    [SerializeField] AudioSource splashSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Paddle"))
        {
            StartCoroutine(Paddle());
        }
    }

    IEnumerator Paddle()
    {
        boat.PaddleForward();
        boat.speed = 8;
        splashSound.Play();
        col.enabled = false;
        yield return new WaitForSeconds(1f);
        otherCol.enabled = true;
    }
}
