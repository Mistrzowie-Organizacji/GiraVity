using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movment : MonoBehaviour
{
    GameObject enemy_pattern;
    GameObject main_character;

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
    private void movement()
    {
        if (distance_to_character() >= 10)
        {
            transform.position = Vector2.MoveTowards(transform.position, get_main_character_position(), 10 * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }
}
