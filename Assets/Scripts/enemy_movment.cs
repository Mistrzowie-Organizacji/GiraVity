using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movment : MonoBehaviour
{
    public GameObject bullet;
    private GameObject projectile_enemy;
    GameObject enemy_pattern;
    GameObject main_character;
    private Vector3 direction;

    void Start()
    {
        main_character = GameObject.Find("giraffe");
        enemy_pattern = GameObject.Find("giraffe_enemy");
    }
    private Vector3 get_main_character_position()
    {
        return main_character.transform.position;
    }
    private float distance_to_character()
    {
        //ponizej obliczana jest odleglosc z wzoru: sqrt( (x1 - x2)^2 + (y1 - y2)^2 )
        float distance = (get_main_character_position().x - gameObject.transform.position.x) * (get_main_character_position().x - gameObject.transform.position.x) + (get_main_character_position().y - gameObject.transform.position.y) * (get_main_character_position().y - gameObject.transform.position.y);
        return Mathf.Sqrt(distance);
    }
    private void enemy_shooting()
    {
        direction = (main_character.transform.position - transform.position).normalized;
        projectile_enemy = Instantiate(bullet, new Vector3(transform.position.x,transform.position.y,transform.position.z), Quaternion.identity);
        projectile_enemy.SetActive(true);
        projectile_enemy.transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg);
        projectile_enemy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        projectile_enemy.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y) * 100;
        Destroy(projectile_enemy, 3f);
    }
    private void movement()
    {
        if (distance_to_character() >= 10)
        {
            if (Random.Range(0, 10) > 2)
            {
                transform.position = Vector2.MoveTowards(transform.position, get_main_character_position(), 10 * Time.deltaTime);
            }
        }
        else
        {
            enemy_shooting();
        }
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }
}
