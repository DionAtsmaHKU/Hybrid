using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] float paddleForce;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude < speed/5) 
        {
            rb.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.Force);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            PaddleForward();
        }
    }

    public void PaddleForward()
    {
        rb.AddForce(Vector3.forward * paddleForce, ForceMode.Impulse);
    }
}