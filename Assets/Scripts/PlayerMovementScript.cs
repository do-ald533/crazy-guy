using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovementScript : MonoBehaviour
{
    public float movementSpeed = 5;

    public Rigidbody2D rb;
    public int playScore;
    public Text score;

    private Vector2 movement;

    // Update is called once per frame
    void Update()
    // input
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() 
    // movement
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        playScore += 1;
        score.text = playScore.ToString();
    }
}
