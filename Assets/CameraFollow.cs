using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; 
    public float smoothSpeed = 0.125f; 
    public Vector3 offset; 

    void FixedUpdate()
    {
        Vector3 desiredPosition = new Vector3(target.position.x, transform.position.y, target.position.z) + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
