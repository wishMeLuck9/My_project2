using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Remove both objects when they touch.
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
