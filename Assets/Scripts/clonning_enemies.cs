using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonning_enemies : MonoBehaviour
{
    public GameObject enemy_pattern;
    GameObject new_enemy;
    float seconds = 0;
    public static int nr_of_enemies = 0;
    private void adding_enemy()
    {
        new_enemy = Instantiate(enemy_pattern, new Vector3(Random.Range(-99, 100), Random.Range(-99, 100), enemy_pattern.transform.position.z), Quaternion.identity);
        new_enemy.SetActive(true);
        nr_of_enemies++;
    }
    void Update()
    {
        if(nr_of_enemies < 25 && seconds >= 0.5f)
        {
            adding_enemy();
            seconds = 0;
        }
        if(seconds < 3)
        {
            seconds += Time.deltaTime;
        }
    }
}
