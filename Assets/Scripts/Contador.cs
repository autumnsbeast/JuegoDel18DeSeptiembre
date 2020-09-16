using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
    public float timeLeft;

    public TextMeshProUGUI tiempo;

    public GameObject gameOver;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        {
            timeLeft -= Time.deltaTime;
            tiempo.text = timeLeft.ToString("0");

            if (timeLeft < 0)
            {
                gameOver.SetActive(true);

                timeLeft = 0;

                Time.timeScale = 0f;
            }

           
        }
    }
}
