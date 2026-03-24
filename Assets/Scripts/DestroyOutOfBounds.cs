using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    void Update()
    {
        // Remove apples that leave the top of the screen.
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        // Remove animals that reach the bottom of the screen.
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
