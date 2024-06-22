using UnityEngine;
using UnityEngine.InputSystem.HID;

public class Arrow : MonoBehaviour
{
    public static Arrow instance;
    public GameObject arrow;

    private Rigidbody2D rb;

    void Start()
    {
        arrow = GameObject.FindWithTag("Arrow");
        rb = arrow.GetComponent<Rigidbody2D>();
    }


    private void Awake()
    {
        if (!instance)
            instance = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject, 1);

        if (collision.gameObject.name.Contains("wall"))
        {
            if (rb != null)
                rb.bodyType = RigidbodyType2D.Static;
        }

        if(collision.gameObject.name == "Tier1")
        {
            Destroy(collision.gameObject,1);
        }

    }

    void Update()
    {
        
    }
}
