using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionDetection : MonoBehaviour
{
    private GameController gameController;


    private void Awake()
    {
        gameController = transform.parent.parent.GetComponent<GameController>();    
    }

    // Start is called before the first frame update
    public int HP = 3;
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.ToString() == "enemy_bullet(Clone) (UnityEngine.GameObject)")
        {
            HP -= 1;
            Destroy(collision.gameObject);
        }
        if (HP == 0)
        {
            SceneManager.LoadScene("MainMenuScene");
            PlayerPrefs.SetInt("Score", GameObject.Find("GameController").GetComponent<PointSystem>().points);
            PlayerPrefs.SetInt("Lost", 1);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
