using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 1000f;      // Movement speed
    public float mouseSensitivity = 2f; // Mouse sensitivity

    private float rotationX = 0f;  // Pitch (up/down)
    private float rotationY = 0f;  // Yaw (left/right)

    void Update()
    {
        float turbo = Input.GetAxisRaw("Turbo");
        float adjustedSpeed = moveSpeed * (1 + 9 * turbo);
        
        rotationX -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        rotationY += Input.GetAxis("Mouse X") * mouseSensitivity;

        // Clamp vertical rotation between -90 and +90 degrees to avoid flipping
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);

        // WASD movement (relative to camera direction)
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDir = transform.forward * vertical + transform.right * horizontal;
        transform.position += moveDir.normalized * adjustedSpeed * Time.deltaTime;
    }
}
