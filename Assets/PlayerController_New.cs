using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController_New : MonoBehaviour
{
    public float moveSpeed;
    private Animator anim;
    private Vector2 movement;
    private Rigidbody2D rb;

    void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>(); 
    }

    void OnMove(InputValue value)
    {
        movement =value.Get<Vector2>();
    }
    
    void Update()
    {
        if(movement != Vector2.zero)
        {
            anim.SetFloat("LookX", movement.x);
            anim.SetFloat("LookY", movement.y);
        }
        anim.SetFloat("Speed", movement.sqrMagnitude);
    }
}
