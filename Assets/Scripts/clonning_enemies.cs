using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonning_enemies : MonoBehaviour
{
    GameObject enemy_pattern;
    GameObject new_enemy;
    public static int nr_of_enemies = 0;
    void Start()
    {
        enemy_pattern = GameObject.Find("giraffe_enemy");
    }
    private void adding_enemy()
    {
        new_enemy = Instantiate(enemy_pattern, new Vector3(Random.Range(-99,100),Random.Range(-99,100),enemy_pattern.transform.position.z), Quaternion.identity);
        nr_of_enemies++;
    }
    void Update()
    {
        if(nr_of_enemies < 15)
        {
            adding_enemy();
        }
    }
}
