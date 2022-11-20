using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleMovement : MonoBehaviour
{
    private GameObject blackHole;
    private Vector2 direction;
    private Rigidbody2D rb;
    private float x_move;
    private float y_move;
    // Start is called before the first frame update
    void Start()
    {
        x_move = Random.Range(150, 250);
        y_move = Random.Range(150, 250);
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(20 * Time.deltaTime * x_move, 20 * Time.deltaTime * y_move));
    }

    private void move()
    {
        direction = blackHole.transform.position;
        direction.y += 0.1f;
        direction.x += 0.1f;
        blackHole.transform.position = direction;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            LoadBoss();
        }
    }
    private void LoadBoss()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
