using UnityEngine;

public class DisableAnimator : MonoBehaviour
{
    public Animator animator;

    // This method will be called by the animation event
    public void DisableAnimatorAfterAnimation()
    {
        animator.enabled = false;
    }
}
