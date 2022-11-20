using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPRenderer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            GameObject icon = GameObject.Instantiate(GameObject.Find("HPIcon"), new Vector3(0+i*50, 0, 0), Quaternion.identity);
            
            icon.transform.SetParent(GameObject.Find("Canvas").transform);
            icon.name = "HPIcon" + i;
        }
        GameObject.Find("HPIcon").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int HP = GameObject.Find("giraffe").GetComponent<collisionDetection>().HP;
        for(int i=0; i<3; i++)
        {
            if(i+1 <= HP)
            {
                GameObject.Find("HPIcon" + i).GetComponent<HPIcon>().active = true;
            }
            else
            {
                GameObject.Find("HPIcon" + i).GetComponent<HPIcon>().active = false;
            }
        }
        
    }
}
