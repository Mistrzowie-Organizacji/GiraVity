using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public int points = 0;
    public int killPoints = 100;
    public void OnKillEnemy()
    {
        points += killPoints;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Points").GetComponent<TextMeshProUGUI>().text = "Points: " + points;
    }
}
