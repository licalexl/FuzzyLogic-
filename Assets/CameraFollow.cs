using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El objetivo que la cámara seguirá (tu personaje)
    public float smoothSpeed = 0.125f; // La velocidad de desplazamiento de la cámara
    public Vector3 offset; // El desplazamiento de la cámara respecto al personaje

    void FixedUpdate()
    {
        Vector3 desiredPosition = new Vector3(target.position.x, transform.position.y, target.position.z) + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
