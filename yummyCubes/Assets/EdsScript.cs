using UnityEngine;

public class EdsScript : MonoBehaviour
{
    float WalkingSpeed = 2;
    float turningspeed = 190;
    Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("is_walking", false);
        if (Input.GetKey(KeyCode.W))
        {

            animator.SetBool("is_walking", true);
            transform.position += WalkingSpeed * transform.forward * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.A))
        {

            animator.SetBool("is_walking", true);
            transform.Rotate(Vector3.up, turningspeed * Time.deltaTime);
        }

    }
}   
