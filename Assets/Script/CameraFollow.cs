// using UnityEngine;

// public class CameraFollow : MonoBehaviour
// {
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }

using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;         // Player transform
    public float smoothSpeed = 0.125f; // Camera follow smoothness
    public Vector3 offset;           // Camera offset (e.g., (0,0,-10))

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}

