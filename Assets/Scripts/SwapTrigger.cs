using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapTrigger : MonoBehaviour
{
    [SerializeField] LookingAway lookingAway;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boat"))
        {
            lookingAway.canSwap = true;
        }
    }
}
