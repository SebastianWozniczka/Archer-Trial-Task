using UnityEngine;


public class Movement : MonoBehaviour
{
    public Animator anim;

    private Rigidbody2D rb;
    
    private float input;
    private float horizontal;
    private bool isFacingRight;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void Rotation()
    {
        if (isFacingRight && horizontal > 0f || !isFacingRight && horizontal < 0f)
        {
            {
                Flip();
            }
        }
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;

        Vector2 localScale = transform.localScale;

        localScale.x *= -1f;
        transform.localScale = localScale;
    }


    void Update()
    {


        Rotation();

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
