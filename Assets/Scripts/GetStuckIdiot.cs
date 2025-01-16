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
    [SerializeField] XRGrabInteractable grabInteractable; // Reference to the XRGrabInteractable component

    private bool hasInteracted = false; // Ensure interaction happens only once
    private bool audioPlayed = false; // Ensure audio is played only once

    private void Start()
    {
        // Subscribe to the selectEntered event
        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.AddListener(OnGrab);
        }
        else
        {
            Debug.LogWarning("No XRGrabInteractable assigned to the script!");
        }
    }

    private void OnDestroy()
    {
        // Unsubscribe from the selectEntered event
        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.RemoveListener(OnGrab);
        }
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

    private void OnGrab(SelectEnterEventArgs args)
    {
        if (!hasInteracted)
        {
            StartBoatMovement();
        }
    }

    private void StartBoatMovement()
    {
        boat.speed = 5; // Restore speed
        boatRb.velocity = boat.transform.forward * boat.speed; // Explicitly set velocity

        col.enabled = true;
        objToMove.SetActive(false);
        gameObject.GetComponent<Collider>().enabled = false;

        hasInteracted = true; // Prevent multiple interactions
        Debug.Log("Boat started moving after grab!");
    }
}
