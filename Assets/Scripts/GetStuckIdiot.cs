using UnityEngine;

public class GetStuckIdiot : MonoBehaviour
{
    [SerializeField] Rigidbody boatRb;
    [SerializeField] BoatMovement boat;
    [SerializeField] GameObject objToMove;
    [SerializeField] Collider col;
    [SerializeField] Collider otherCol;
    [SerializeField] AudioSource audioSource;

    private Vector3 startPos;
    private bool audioPlayed = false; // Flag to track if the audio has been played

    private void Start()
    {
        startPos = objToMove.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        objToMove.SetActive(true);
        boatRb.velocity = Vector3.zero;
        boat.speed = 0;
        col.enabled = false;
        otherCol.enabled = false;

        if (!audioPlayed) // Check if the audio has been played
        {
            audioSource.Play();
            audioPlayed = true; // Mark the audio as played
        }
    }

    private void Update()
    {
        if (Vector3.Distance(objToMove.transform.position, startPos) > 0.01f)
        {
            boat.speed = 5;
            col.enabled = true;
            objToMove.SetActive(false);
        }
    }
}
