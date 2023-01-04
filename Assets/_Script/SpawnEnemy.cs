using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public Vector2 spawnArea;
    public float spawnTimer;
    float timer;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer<0f)
        {
            spawn();
            timer = spawnTimer;
        }
    }
    public void spawn()
    {
        Vector3 position = RandomPosition();
        GameObject newEnemy = Instantiate(enemy);
        newEnemy.transform.position = position;
    }
    public Vector3 RandomPosition()
    {
        Vector3 position = new Vector3();
        float f = Random.value > 0.5f ? -1f : 1f;
        if(Random.value>0.5f)
        {
            position.x = Random.Range(-spawnArea.x, spawnArea.x);
            position.y = spawnArea.y * f;
        }
        else
        {
            position.y = Random.Range(-spawnArea.y, spawnArea.y);
            position.x = spawnArea.x * f;
        }
        position.z = 0;
        return position;
    }
}
