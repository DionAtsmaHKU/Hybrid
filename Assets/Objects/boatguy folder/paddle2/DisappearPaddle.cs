using UnityEngine;

public class DisappearPaddle : MonoBehaviour
{
    public void HideObject()
    {
        gameObject.SetActive(false); // Deactivates the object
    }
}
