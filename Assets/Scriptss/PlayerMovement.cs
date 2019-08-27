using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;

    Vector3 movement;
    Animator animator;
    Rigidbody rigidbody;
    int floorMask;
    float camLenght = 100f;

    void Awake() 
    {
        floorMask = LayerMask.GetMask("Floor");
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }
    void FixedUpdate() {
    float h = Input.GetAxisRaw("Horizontal");
    float v = Input.GetAxisRaw("Vertical");    

    Move(h, v);
    Turning();
    Animating(h, v);
    }
    void Move(float h, float v) {
        movement.Set(h, 0f, v);
        movement = movement.normalized * speed * Time.deltaTime;

        rigidbody.MovePosition(transform.position + movement);   
    }

    void Turning()
    {

    }

    void Animating(float h, float v)
    {

    }
    
}
