using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShooterEnemy : MonoBehaviour
{
    public GameObject enemyProjectile, player;
    public Transform reference;
    void Start()
    {
        StartCoroutine(shoot());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setPlayer(GameObject character)
    {
        player = character;
    }
    IEnumerator shoot()
    {
        while (true)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
            if (distanceToPlayer < 20)
            {
                Instantiate(enemyProjectile, reference.position, reference.rotation);
            }
            yield return new WaitForSeconds(4f);
        }
    }
}
