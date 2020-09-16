using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    void NewScene()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene(1);

    }
   
}
