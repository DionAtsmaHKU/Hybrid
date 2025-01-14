using UnityEngine;

public class AnimAudio : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource
    public AudioClip[] audioClips; // Array to hold the audio clips

    // Method to play a specific sound by index
    public void PlaySound(int clipIndex)
    {
        if (clipIndex >= 0 && clipIndex < audioClips.Length)
        {
            audioSource.clip = audioClips[clipIndex];
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("Clip index out of range!");
        }
    }
}
