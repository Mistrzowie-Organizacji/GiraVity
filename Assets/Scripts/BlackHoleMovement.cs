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
        x_move = Random.Range(70, 100);
        y_move = Random.Range(70, 100);
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(20 * Time.deltaTime * 70, 20 * Time.deltaTime * 70));
    }

    private void move()
    {
        direction = blackHole.transform.position;
        direction.y += 0.1f;
        direction.x += 0.1f;
        blackHole.transform.position = direction;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
