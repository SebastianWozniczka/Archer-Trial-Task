using UnityEngine;
using UnityEngine.UI;

public class Tier1 : MonoBehaviour
{
    public Slider slider;
    public GameObject player;
    public Animator anim;

    private DistanceJoint2D distanceJoint2D;

    private float timer;

    void Start()
    {
        distanceJoint2D = GetComponent<DistanceJoint2D>();

        timer = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 0.2f)
        {
            distanceJoint2D.distance -= 0.2f;
            timer = 0;
        }

        if(distanceJoint2D.distance < 1)
        {
            slider.value--;
            anim.speed = 0.5f;
        }

        if (slider.value < 0.1f)
        {
           
            Destroy(slider);           
            Destroy(player,3);
        }

        
    }

    
}
