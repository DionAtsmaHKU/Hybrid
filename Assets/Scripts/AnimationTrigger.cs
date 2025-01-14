using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator animator; // Reference to the Animator

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boat")) // Replace "Player" with the tag of the object triggering the event
        {
            animator.SetTrigger("NextAnimation"); // Replace with the appropriate trigger parameter name
        }
    }
}
