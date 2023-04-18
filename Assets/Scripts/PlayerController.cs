using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1.0f;
    [SerializeField] float boostSpeed = 30.0f;
    [SerializeField] float baseSpeed = 20.0f;
    private Rigidbody2D rb;
    private SurfaceEffector2D surfaceEffector2D;
    private bool canMove;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove) {
            RotatePlayer();
            RespondToBoost();
        }
    }

    public void DisableControl() {
        canMove = false;
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-torqueAmount);
        }
    }

    private void RespondToBoost() {
        // if we push up then speed up
        if (Input.GetKey(KeyCode.UpArrow)) {
            // access the surface effector and change its speed
            surfaceEffector2D.speed = boostSpeed;
        }
        else {
            surfaceEffector2D.speed = baseSpeed;
        }
    }
}
