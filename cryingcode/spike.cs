using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike : MonoBehaviour
{
    private GameObject Player;

    bool hit = false;

    // Start is called before the first frame update
    void Awake()
    {
        Player = GameObject.Find("Player");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit" + other);

        //Check if the collider's perent has the tag Player
        if (other.transform.root.CompareTag("Player"))
        {
    
            hit = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
        if (hit == true)
        {
            Player.GetComponent<target>().PlayerTakeDamage(50f); 
            hit = false;
        }


    }
}
