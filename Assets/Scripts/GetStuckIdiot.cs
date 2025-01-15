using UnityEngine;

public class GetStuckIdiot : MonoBehaviour
{
    [SerializeField] Rigidbody boatRb;
    [SerializeField] BoatMovement boat;
    [SerializeField] GameObject objToMove;
    [SerializeField] Collider col;
    [SerializeField] Collider otherCol;
    [SerializeField] Animator animator;

    private Vector3 startPos;

    private void Start()
    {
        startPos = objToMove.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        objToMove.SetActive(true);
        boatRb.velocity = Vector3.zero;
        boat.speed = 0;
        col.enabled = false;
        otherCol.enabled = false;
    }

    private void Update()
    {
        if (objToMove.transform.position != startPos)
        {
            boat.speed = 5;
            col.enabled = true;
            animator.SetTrigger("ByeStuff");
        }
    }
}
