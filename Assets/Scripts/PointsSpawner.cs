using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsSpawner : MonoBehaviour
{
    public int minSec = 1;

    public int maxSec = 8;

    public int timeToSpawn = 6;

    public float timer = 3;

    public GameObject stars = null;

    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn = Random.Range(minSec, maxSec);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeToSpawn)
        {
            Instantiate(stars, transform);
            timer = 0;
            timeToSpawn = Random.Range(minSec, maxSec);
        }
    }
}
