using UnityEngine;

public class Moveforward : MonoBehaviour
{
    public float speed = 40.0f;

    void Update()
    {
        // Move the object forward every frame.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
