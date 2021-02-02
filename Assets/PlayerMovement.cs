using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed, jumpForce, points;
    private Rigidbody2D rb2d;
    private bool grounded;

    void Start()
    {
        rb2d= GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        gameObject.transform.Translate(new Vector2(horizontal, 0));

        if (Input.GetKeyDown(KeyCode.Space) & grounded)
        {
            rb2d.AddForce(new Vector2(0, jumpForce * 100));
            grounded = false;
        }
    }

    public void setGrounded(bool ground)
    {
        grounded = ground;
    }

    public void addPoint(int addition)
    {
        points += addition;
    }
    public int GetPoints()
    {
        return points;
    }
}


