using UnityEngine;

public class CircularMovement : MonoBehaviour
{
    public float radius = 2f;    // Size of the circle
    public float speed = 2f;     // Rotation speed

    private Vector3 center;
    private float angle;

    void Start()
    {
        center = transform.position;   // Circle center = the starting point
    }

    void Update()
    {
        angle += speed * Time.deltaTime;

        float x = Mathf.Cos(angle) * radius;
        float y = Mathf.Sin(angle) * radius;

        transform.position = center + new Vector3(x, y, 0f);
    }
}
