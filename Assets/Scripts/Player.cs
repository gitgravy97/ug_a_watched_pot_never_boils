using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    private Vector2 moveInput;
     private Rigidbody rb;
     
     // Runs on Script Load, before Start
     void Awake() {
         rb = GetComponent<Rigidbody>();
     }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        // GetComponent<PlayerInput>().actions.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 

    public void OnMove(InputValue value) {
        moveInput = value.Get<Vector2>();
        Debug.Log("Move input: " + moveInput);
    }

    void FixedUpdate() {
        Vector3 movement = new Vector3(moveInput.x, 0, moveInput.y);
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
