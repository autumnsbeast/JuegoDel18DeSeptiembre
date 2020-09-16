using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VolantinScript : MonoBehaviour
{
    public int volantinSpeed = 1;

    public int score = 0;

    public int puntuacionFinal;

    public TextMeshProUGUI scoreUI;

    public TextMeshProUGUI finalScoreUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    { 
       
            Destroy(collision.gameObject);

            score++;

            scoreUI.text = score.ToString();

            puntuacionFinal = score;

            finalScoreUI.text = puntuacionFinal.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up* Time.deltaTime * volantinSpeed;
        }

       if (Input.GetKey(KeyCode.DownArrow))
       {
           transform.position -= transform.up * Time.deltaTime * volantinSpeed;
       }

    }
}
