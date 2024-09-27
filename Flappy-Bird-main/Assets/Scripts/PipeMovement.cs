using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float MoveSpeed = 1f;
    public float DeadZone = -45;

    // Update is called once per frame
    void Update()
    {
        // Updating its position with a constant speed to the left regardless of FPS.
        transform.position = transform.position + (Vector3.left * MoveSpeed) * Time.deltaTime;

        if(transform.position.x < DeadZone )
        {
            Destroy(gameObject);
        }
    }
}
