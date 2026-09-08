using UnityEngine;
using UnityEngine.InputSystem;

public class EnvironmentRotator : MonoBehaviour
{
    [Header("Rotation Settings")]
    [SerializeField] private float rotationSpeed = 100f;

    private void Update()
    {
        if (Keyboard.current == null)
            return;

        // Hold Q to spin the environment in the opposite direction.
        if (Keyboard.current.qKey.isPressed)
        {
            transform.Rotate(
                0f,
                0f,
                -rotationSpeed * Time.deltaTime
            );
        }
    }
}