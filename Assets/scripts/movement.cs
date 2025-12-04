using UnityEngine;

public class SideToSide : MonoBehaviour
{
    public float speed = 2f;       // Movement speed
    public float distance = 3f;    // How far left/right to move

    private float startX;

    void Start()
    {
        startX = transform.position.x;
    }

    void Update()
    {
        float x = startX + Mathf.PingPong(Time.time * speed, distance * 2) - distance;
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
