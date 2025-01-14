using UnityEngine;

public class TriggerAnimationController : MonoBehaviour
{
    public Animator animator; // Reference to the Animator

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boat")) // Replace "Player" with the tag of the triggering object
        {
            animator.SetTrigger("NextAnimationTrigger");
        }
    }
}
