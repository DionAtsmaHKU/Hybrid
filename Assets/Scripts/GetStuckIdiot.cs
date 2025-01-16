using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;

public class GetStuckIdiot : MonoBehaviour
{
    [SerializeField] Rigidbody boatRb;
    [SerializeField] BoatMovement boat;
    [SerializeField] GameObject objToMove;
    [SerializeField] Collider col;
    [SerializeField] Collider otherCol;
    [SerializeField] AudioSource audioSource;

    private Vector3 startPos;

    private bool hasInteracted = false; // Ensure interaction happens only once
    private bool audioPlayed = false; // Ensure audio is played only once

    private void Start()
    {
        startPos = objToMove.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boat"))
        {
            objToMove.SetActive(true);
            boatRb.velocity = Vector3.zero;
            boat.speed = 0;
            col.enabled = false;
            otherCol.enabled = false;

            if (!audioPlayed)
            {
                audioSource.Play();
                audioPlayed = true;
            }
        }
    }

    private void Update()
    {
        if (objToMove.transform.position.z - startPos.z > 1 && !hasInteracted)
        {
            StartBoatMovement();
        }
    }

    private void StartBoatMovement()
    {
        boat.speed = 10; // Restore speed
        boatRb.velocity = boat.transform.forward * boat.speed; // Explicitly set velocity

        col.enabled = true;
        objToMove.SetActive(false);
        gameObject.GetComponent<Collider>().enabled = false;

        hasInteracted = true; // Prevent multiple interactions
        Debug.Log("Boat started moving after grab!");
        Debug.Log(objToMove.transform.position.x - startPos.x);
    }
}
