using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1.0f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddTorque(torqueAmount);
        }
        else if(Input.GetKey(KeyCode.RightArrow)) {
            rb.AddTorque(-torqueAmount);
        }
    }
}
