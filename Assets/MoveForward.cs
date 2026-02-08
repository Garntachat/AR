using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust speed in the Inspector

    void Update()
    {
        // Move the object in its local forward direction
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // Alternative method for directly modifying position
        // transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
}
