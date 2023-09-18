using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void levelTrack()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Datatrack.level += 1;
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneBuildIndex:Datatrack.level);
        }
    }

}
