using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundThingy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject character = GameObject.Find("giraffe");
        Vector3 character_position = character.transform.position;
        Vector3 charOnBackground = gameObject.transform.position - character_position;
       
        
    }
}
