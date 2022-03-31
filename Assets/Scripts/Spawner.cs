using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform[] mobTypes;
    public int waveLevel = 0;
    public float countdown = 60f;
    public Transform[] spawnPoints;
    public float timeBetweenEnemies = 5f;
    public float waveDuration = 60f;
    public float timeBetweenWaves = 5f;


    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown <= 0)
        {
            if(waveLevel <= mobTypes.Length)
            {
                StartCoroutine(spawnWave());
            }
            else
            {
                //TODO: Make sure all enemies are dead
                GameManager.Instance.gameWon();
            }

        }
        countdown -= Time.deltaTime;
    }

    //Spawns a wave of enemies and 
    IEnumerator spawnWave()
    {
        Debug.Log("Wave " + waveLevel + " is spawning!");
        countdown = waveDuration + timeBetweenWaves;

        for (int i = 0; i < (waveDuration / timeBetweenEnemies); i++) {
            spawnEnemies();
            yield return new WaitForSeconds(timeBetweenEnemies);
        }
        waveLevel++;
    }


    //Spawns a enemy on each spawnpoint
    void spawnEnemies()
    {
        for(int i = 0; i < spawnPoints.Length; i++)
        {
            Instantiate(mobTypes[waveLevel], spawnPoints[i].position, spawnPoints[i].rotation);
        } 
    }
}
