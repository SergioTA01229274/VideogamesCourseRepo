using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
   // public SpawnningPoint[] spawnningPoints;
    public int enemyQuantity;
    private List<Enemy> enemies;
    public GameObject enemy, player;
   


    void Start()
    {
        enemies = new List<Enemy>();
        StartCoroutine(createEnemies());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void deleteEnemy(Enemy enemyI)
    {
        enemies.Remove(enemyI);
    }
    public int getEnemiesLength()
    {
        return enemies.Count;
    }

    IEnumerator createEnemies()
    {
        while (true)
        {
            if (enemies.Count < 5)
            {
                GameObject newEnemy = Instantiate(enemy);
                newEnemy.GetComponentInChildren<Enemy>().setWaveController(gameObject);
                newEnemy.GetComponentInChildren<Enemy>().setPlayer(player);
                newEnemy.GetComponentInChildren<EnemyMovement>().setPlayer(player);
                newEnemy.GetComponentInChildren<EnemyTurret>().setPlayer(player);
                newEnemy.GetComponentInChildren<CannonShooterEnemy>().setPlayer(player);
                newEnemy.GetComponentInChildren<EnemyHealthBar>().setPlayer(player);
                enemies.Add(newEnemy.GetComponentInChildren<Enemy>());
            }
            yield return new WaitForSeconds(10f);
        }
    }
}
