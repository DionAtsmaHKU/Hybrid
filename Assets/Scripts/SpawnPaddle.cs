using UnityEngine;

public class SpawnPaddle : MonoBehaviour
{
    [SerializeField] GameObject paddle;

    private void OnTriggerEnter(Collider other)
    {
        paddle.SetActive(true);
    }
}
