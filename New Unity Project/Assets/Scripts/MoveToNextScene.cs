using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextScene : MonoBehaviour
{
    public GameObject player;

    public int LoadNextOrPrevious = 1;

    private int nextSceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + LoadNextOrPrevious;
        player.gameObject.GetComponent<scriptintro>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision = player.GetComponent<Collider2D>();

        if(collision)
        {
            SceneManager.LoadScene(nextSceneToLoad);
        }
        
    }
   
}
