using UnityEngine;

public class clonning_enemies : MonoBehaviour
{
    public GameObject enemy_pattern;
    GameObject new_enemy;
    private Transform enemyContainer;

    float seconds = 0;
    public static int nr_of_enemies = 0;

    private void Awake()
    {
        enemyContainer = transform.Find("enemyContainer");
    }

    private void adding_enemy()
    {
        new_enemy = Instantiate(enemy_pattern, new Vector3(Random.Range(-99, 100), Random.Range(-99, 100), enemy_pattern.transform.position.z), Quaternion.identity, enemyContainer);
        new_enemy.SetActive(true);
        nr_of_enemies++;
    }
    void Update()
    {
        if (GameController.Instance == null)
        {
            return;
        }

        spawnEnemy(GameController.Instance.isGameActive);
    }

    private void spawnEnemy(bool isGameActive)
    {
        if (!isGameActive)
            return;

        if (nr_of_enemies < 25 && seconds >= 0.5f)
        {
            adding_enemy();
            seconds = 0;
        }
        if (seconds < 3)
        {
            seconds += Time.deltaTime;
        }
    }
}
