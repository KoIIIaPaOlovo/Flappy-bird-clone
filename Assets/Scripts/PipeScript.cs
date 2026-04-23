using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PipeScript : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        //rb.linearVelocity = new Vector3(1f, 1f, 1f);
        rb.MovePosition(new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z));
        //rb.AddForce(new Vector3(-1,0,0).normalized * 5, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision!!!");
        if (collision.gameObject.CompareTag("trigger_destroy-pipe"))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision!!!");
        if (other.gameObject.CompareTag("trigger_destroy-pipe"))
        {
            Destroy(gameObject);
        }
    }

}
