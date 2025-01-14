using System.Collections.Generic;
using UnityEngine;

public class LookingAway : MonoBehaviour
{
    [SerializeField] List<GameObject> horsemen = new List<GameObject>();
    int current = 0;
    public bool canSwap = false;

    private void OnBecameInvisible()
    {
        if (canSwap)
        {
            if (current == 0)
            {
                horsemen[current].gameObject.SetActive(true);
                current++;
                canSwap = false;
                return;
            }
            if (current == 3)
            {
                horsemen[current - 1].gameObject.SetActive(false);
                canSwap = false;
                return;
            }

            horsemen[current - 1].gameObject.SetActive(false);
            horsemen[current].gameObject.SetActive(true);
            current++;

            canSwap = false;
        }
    }
}
