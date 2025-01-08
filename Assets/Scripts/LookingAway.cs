using System.Collections.Generic;
using UnityEngine;

public class LookingAway : MonoBehaviour
{
    [SerializeField] List<GameObject> horsemen = new List<GameObject>();
    int current = 0;

    private void OnBecameInvisible()
    {
        horsemen[current].gameObject.SetActive(false);
        current++;
        if (current == horsemen.Count) current = 0;
        horsemen[current].gameObject.SetActive(true);
    }
}
