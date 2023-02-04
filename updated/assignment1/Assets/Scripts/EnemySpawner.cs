using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float SpawnRate = 1f;

    [SerializeField] private GameObject enemyPrefabs;

    [SerializeField] private bool CanSpawn = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }
    private IEnumerator Spawner() 
    {
        WaitForSeconds wait = new WaitForSeconds (SpawnRate);
        while (CanSpawn)
        {
            yield return wait;

            Instantiate(enemyPrefabs, transform.position, Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
