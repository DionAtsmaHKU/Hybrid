using System.Collections; // Required for IEnumerator and coroutines
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class GetStuckIdiotFinal : MonoBehaviour
{
    [SerializeField] private Rigidbody boatRb;
    [SerializeField] private BoatMovement boat;
    [SerializeField] private Collider col;
    [SerializeField] private Collider otherCol;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private float delayBeforeSceneChange = 1f; // Time after fade before changing scenes
    [SerializeField] private string nextSceneName; // Name of the scene to load

    private void OnTriggerEnter(Collider other)
    {
        boatRb.velocity = Vector3.zero;
        boat.speed = 0;
        col.enabled = false;
        otherCol.enabled = false;

        if (audioSource != null)
        {
            StartCoroutine(PlayAudioAndSwitchScene());
        }
    }

    private IEnumerator PlayAudioAndSwitchScene()
    {
        // Play the audio
        audioSource.Play();

        // Wait for the audio to finish
        yield return new WaitForSeconds(audioSource.clip.length);

        // Wait an additional delay (optional)
        yield return new WaitForSeconds(delayBeforeSceneChange);

        // Load the next scene
        SceneManager.LoadScene(nextSceneName);
    }
}
