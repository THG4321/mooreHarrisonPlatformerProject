using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        Application.targetFrameRate = 60;

    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
