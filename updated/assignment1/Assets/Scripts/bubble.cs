using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubble : MonoBehaviour
{
    private PlayerMovement PM;

    // Start is called before the first frame update
    void Start()
    {
        GameObject PlayerObject = GameObject.FindWithTag("Player");

        if (PlayerObject != null)
        {
            PM = PlayerObject.GetComponent<PlayerMovement>();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (PM != null) 
        {
            PM.ChangeBubble();
            Destroy(gameObject);
        }
    }

}
