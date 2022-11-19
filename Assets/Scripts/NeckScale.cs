using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeckScale : MonoBehaviour
{
    // Start is called before the first frame update
   

    float neckLength = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject head;
        GameObject neck;
        GameObject body;
        head = GameObject.Find("Head");
        neck = GameObject.Find("Neck");
        body = GameObject.Find("Body");
        Vector3 headPos = head.transform.position - new Vector3(0.5f,0,0);
        Vector3 bodyPos = body.transform.position + new Vector3(0.7f,0,0);

        Vector3 bodyToHead = headPos - bodyPos;

        neck.transform.localScale = new Vector3(1, bodyToHead.magnitude, 1);
        neck.transform.position = bodyPos + (bodyToHead / 2);
        neck.transform.rotation = Quaternion.FromToRotation(Vector2.up, bodyToHead);

        head.transform.position = bodyPos + new Vector3(0, neckLength, 0);
        if(Input.GetKey(KeyCode.W)){
            neckLength += 0.1f;
            
        }
        
        if(Input.GetKey(KeyCode.S)){
            neckLength -= 0.1f;
        }
    }

    void FixedUpdate()
    {
        
    }
}
