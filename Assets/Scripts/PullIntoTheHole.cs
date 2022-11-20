using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PullIntoTheHole : MonoBehaviour
{
    private float distance;
    private GameObject blackHole;
    private GameObject player;
    private Vector2 direct;
    private float min_distance = 7f;

    // Start is called before the first frame update
    void Start()
    {
        blackHole = GameObject.Find("black_hole_official");
        player = GameObject.Find("giraffe");
    }

    private void check_collision()
    {
        min_distance += 0.01f;
        distance = Vector3.Distance(blackHole.transform.position, player.transform.position);
        if (distance < min_distance)
        {
            print(min_distance);
            player.transform.position = blackHole.transform.position - (blackHole.transform.position - player.transform.position) * 0.98f;
        }

    }
    // Update is called once per frame
    void Update()
    {
        check_collision();
    }
}

