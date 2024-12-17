using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleRespawn : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] Transform respawn;
    [SerializeField] Rigidbody rb;
    [SerializeField] float safeDistance;

    // Update is called once per frame
    void Update()
    {
        if ((playerTransform.position - transform.position).magnitude > safeDistance || transform.position.y < -0.5)
        {
            rb.velocity = Vector3.zero;
            transform.position = respawn.position;
        }
    }
}
