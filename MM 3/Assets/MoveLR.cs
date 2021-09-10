using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLR : MonoBehaviour
{
    Rigidbody2D player;
    float horizontal;
    public float moveSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        player.velocity = new Vector2(horizontal * moveSpeed,0);
    }
}
