using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void Load01()
    {
        SceneManager.LoadScene(1);
    }

    public void Load02()
    {
        SceneManager.LoadScene(2);
    }

    public void Load03()
    {
        SceneManager.LoadScene(3);
    }
}
