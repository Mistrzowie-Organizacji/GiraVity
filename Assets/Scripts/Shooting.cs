using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    private GameObject projectile;
    private Vector3 character_position;
    private Vector3 mouse_position;
    private Vector3 screenposition;
    private Vector3 direction;
    private float max_velocity = 30f;
    private float bullet_speed = 0.10f;
    private Vector3 get_screen_position()
    {
        return Camera.main.WorldToScreenPoint(get_character_position());
    }
    private Vector3 get_character_position()
    {
        return GameObject.Find("giraffe").transform.position;
    }
    private Vector3 get_mouse_position()
    {
        return Input.mousePosition;
    }
    private void shoot()
    {
        screenposition = get_screen_position();
        mouse_position = get_mouse_position();
        character_position = get_character_position();
        direction = (mouse_position - screenposition).normalized;
        projectile = Instantiate(bullet, new Vector3(character_position.x, character_position.y, character_position.z), Quaternion.identity);
        projectile.SetActive(true);
        projectile.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        projectile.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y) * 100;
        
       
       if(gameObject.GetComponent<Rigidbody2D>().velocity.magnitude > max_velocity/2)
        {
            
        }
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-direction.x, -direction.y) * 100);
        
        
        Destroy(projectile, 3f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bullet_speed >= 0.2)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                bullet_speed = 0;
                shoot();
            }
        }
        else
        {
            bullet_speed += Time.deltaTime;
        }
    }

    void FixedUpdate(){
        if(gameObject.GetComponent<Rigidbody2D>().velocity.magnitude > max_velocity)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = gameObject.GetComponent<Rigidbody2D>().velocity.normalized * max_velocity;
        }
        if (gameObject.GetComponent<Rigidbody2D>().velocity.magnitude > 0)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity -= gameObject.GetComponent<Rigidbody2D>().velocity.normalized * 0.01f;
        }
    }
}
