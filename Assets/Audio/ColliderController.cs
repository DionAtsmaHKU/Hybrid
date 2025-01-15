using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    public Collider colliderToControl;

    // Call this method from an animation event to enable the collider
    public void EnableCollider()
    {
        colliderToControl.enabled = true;
    }

    // Call this method from an animation event to disable the collider
    public void DisableCollider()
    {
        colliderToControl.enabled = false;
    }
}
