using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour
{

    GameObject[] enemies = new GameObject[10];
    public float spawnTime = 60f;
    public GameObject asteroid;
    private void AsteroidRain(){
        Vector3 character_position = GameObject.Find("giraffe").transform.position;
        for(int i=0;i<10;i++){
            enemies[i] = GameObject.Instantiate(asteroid, new Vector3(Random.Range(-10,10), 10, 0), Quaternion.identity);
            enemies[i].SetActive(false);
        }
        for(int i = 0; i < 10; i++){
            
            enemies[i].transform.position = new Vector3(character_position.x + Random.Range(-20,20), character_position.y + Random.Range(30, 50), 0);
            enemies[i].SetActive(true);
            Destroy(enemies[i], 10f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime -= Time.deltaTime;
        if(spawnTime <= 0){
            AsteroidRain();
            spawnTime = 60f;
        }
    }
}
