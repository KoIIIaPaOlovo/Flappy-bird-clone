using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerScript : MonoBehaviour
{
    private Rigidbody rb;

    [Header("Input Manager")]
    public InputManager inputManager;

    [Header("Настройки прыжка")]
    public float jumpForce = 8f;
    //public Transform groundCheck;
    public float groundDistance = 0.2f;
    //public LayerMask groundMask;

    private bool isGrounded;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        //isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        isGrounded = true;

        if (inputManager != null &&
            inputManager.Jump.WasPressedThisFrame() &&
            isGrounded)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            Debug.Log("Прыгнул!");
        }
    }

    private void OnDrawGizmosSelected()
    {
        //if (groundCheck != null)
        //{
        //    Gizmos.color = isGrounded ? Color.green : Color.red;
        //    Gizmos.DrawWireSphere(groundCheck.position, groundDistance);
        //}
    }
}