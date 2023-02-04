using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject hitEffect;


   void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy e = collision.collider.GetComponent<Enemy>();
        if (e != null)
        {
            Destroy(e.gameObject);

        }

        EnemySpawner s = collision.collider.GetComponent<EnemySpawner>();
        if (s != null)
        {
            Destroy(s.gameObject);
        }

        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.5f);
        Destroy(gameObject);
    }
    
}
