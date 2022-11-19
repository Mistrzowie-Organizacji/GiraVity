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
    private Vector3 gun_position;
    private Quaternion  gun_rotation;
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
        gun_position = GameObject.Find("plasmagun").transform.position;
        gun_rotation = GameObject.Find("plasmagun").transform.rotation;
        character_position = get_character_position();
        direction = (mouse_position - screenposition).normalized;
        projectile = Instantiate(bullet, new Vector3(gun_position.x, gun_position.y, gun_position.z), Quaternion.identity);
        projectile.transform.rotation = gun_rotation;
        projectile.SetActive(true);
        projectile.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        projectile.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y) * 100;
        
       
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-direction.x, -direction.y) * max_velocity/3;

        
        
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
        GameObject gun = GameObject.Find("plasmagun");
        gun.transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(Input.mousePosition.y - Camera.main.WorldToScreenPoint(gun.transform.position).y, Input.mousePosition.x - Camera.main.WorldToScreenPoint(gun.transform.position).x) * Mathf.Rad2Deg);
    }
}
