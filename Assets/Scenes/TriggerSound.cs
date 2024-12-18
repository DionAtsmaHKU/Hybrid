using UnityEngine;
// ChatGPT code

public class TriggerSound : MonoBehaviour
{
    public AudioSource audioSource; // Assign in Inspector or get dynamically

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }
}
