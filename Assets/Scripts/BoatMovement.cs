using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    public float speed;
    [SerializeField] float paddleForce;

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude < speed/5) 
        {
            rb.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.Force);
        }
    }

    public void PaddleForward()
    {
        rb.AddForce(Vector3.forward * paddleForce, ForceMode.Impulse);
    }
}
