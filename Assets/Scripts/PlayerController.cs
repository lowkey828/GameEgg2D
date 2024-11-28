using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 3f;

    private Rigidbody2D rb;
    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float inputMove = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(inputMove * moveSpeed, 0f);

        if (inputMove > 0f)
        {
            transform.localScale = new Vector3(0.7f, 0.7f, 1f);
        }
        else if (inputMove < 0f)
        {
            transform.localScale = new Vector3(-0.7f, 0.7f, 1f);
        }

        if (inputMove != 0f)
        {
            anim.SetBool("IsRunning", true);
        }
        else
        {
            anim.SetBool("IsRunning", false);
        }
    }
}
