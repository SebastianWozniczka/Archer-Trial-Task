using UnityEngine;


public class Movement : MonoBehaviour
{
    public Animator anim;

    private Rigidbody2D rb;
    
    private float input;
    private float horizontal;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {
        rb.velocity = new Vector2(horizontal, rb.velocity.y);

        input = Input.GetAxis("Horizontal");
        if (input > 0)
        {
            horizontal = 10;
            anim.SetTrigger("walk");
        }
        else if (input < 0)
        {
            horizontal = -10;
            anim.SetTrigger("walk");
        }
        else
        {
            horizontal = 0;
            anim.SetTrigger("stand");
        }

    }
}
