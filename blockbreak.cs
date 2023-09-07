using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockbreak : MonoBehaviour
{
    bool hit = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit" + other);

        //Check if the collider's perent has the tag Player
        if(other.transform.root.CompareTag("Player"))
        {
            hit = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (hit == true)
        {
            Destroy(gameObject);
            hit = false;
        }


    }
}
