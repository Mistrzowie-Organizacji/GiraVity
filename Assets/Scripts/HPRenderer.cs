using UnityEngine;

public class HPRenderer : MonoBehaviour
{
    private collisionDetection collisionDetection;
    private HPIcon hpIcon;

    // Start is called before the first frame update
    void Start()
    {
        hpIcon = GameObject.Find("HPIcon").GetComponent<HPIcon>();
        for (int i = 0; i < 3; i++)
        {
            GameObject icon = GameObject.Instantiate(hpIcon.gameObject, new Vector3(0 + i * 50, 0, 0), Quaternion.identity);

            icon.transform.SetParent(GameObject.Find("Canvas").transform);
            icon.name = "HPIcon" + i;
        }
        hpIcon.gameObject.SetActive(false);

        collisionDetection = GameObject.Find("giraffe").GetComponent<collisionDetection>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 3; i++)
        {
            if (i + 1 <= collisionDetection.HP)
            {
               hpIcon.active = true;
            }
            else
            {
                hpIcon.active = false;
            }
        }

    }
}
