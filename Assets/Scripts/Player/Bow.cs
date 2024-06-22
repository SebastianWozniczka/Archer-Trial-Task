using NUnit.Framework.Internal;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public GameObject arrow, back, forward;
    public Transform dest;

    public float bulletImpulse = 100.0f;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))     
        {
            Vector2 position = (forward.transform.position - back.transform.position).normalized;

            GameObject ga = Instantiate(arrow, dest.position, transform.rotation);
            Rigidbody2D rb = ga.GetComponent<Rigidbody2D>();

            rb.AddForce(position * bulletImpulse, (ForceMode2D)ForceMode.Impulse);

           
        }
    }
}
