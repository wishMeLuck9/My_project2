using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public GameObject projectilePrefab;
    public Vector3 projectileSpawnOffset = new Vector3(0.0f, 0.0f, 1.0f);

    void Update()
    {
        // Keep the player inside the side borders.
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Move the player left and right.
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Spawn an apple in front of the player.
            Instantiate(
                projectilePrefab,
                transform.position + projectileSpawnOffset,
                projectilePrefab.transform.rotation);
        }
    }
}
