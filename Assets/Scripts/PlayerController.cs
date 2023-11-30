using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public Animator anim;
    private Rigidbody rb;
    public LayerMask layerMask;
    public bool grounded;

    public float Jum = 5;
    public float Dis = 5;
    public GameObject Groundcheck;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Grounded();
        Jump();
        Move();
    }

    private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && this.grounded)
        {
            this.rb.AddForce(Vector3.up * Jum, ForceMode.Impulse);
        }
    }

    private void Grounded()
    {
        if(Physics.CheckSphere(Groundcheck.transform.position , Dis, layerMask))
        {
            this.grounded = true;
        }
        else
        {
            this.grounded = false;
        }

        this.anim.SetBool("jump", !this.grounded);
    }

    private void Move()
    {
        float verticalAxis = Input.GetAxis("Vertical");
        float horizontalAxis = Input.GetAxis("Horizontal");

        Vector3 movement = this.transform.forward * verticalAxis + this.transform.right * horizontalAxis;
        movement.Normalize();

        this.transform.position += movement * 0.08f;

        this.anim.SetFloat("vertical", verticalAxis);
        this.anim.SetFloat("horizontal", horizontalAxis);
    }
}
