using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Player player;
    public float moveSpeed = 5f;
    private Sprite sprite;

    public Rigidbody2D rb;

    private float abilityCooldown;
    private float abilityCooldownEnd;

    private Vector2 movement;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        abilityCooldown = player.abilityCooldown;
        gameObject.GetComponent<SpriteRenderer>().sprite = player.sprite;

    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        if (Input.GetKeyDown("e") && abilityCooldownEnd <= 0)
        {
            player.Ability();
            abilityCooldownEnd = abilityCooldown;
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
        abilityCooldownEnd -= Time.deltaTime;
    }
}
