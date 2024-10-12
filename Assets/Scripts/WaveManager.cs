using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager waveManager;
    private int wave;
    private int nbRemaining;
    public GameObject waveWidget;
    public List<Wave> waves;
    public Wave currentWave;
    private int godzillaSpawned;
    private int serpentSpawned;
    private int moustiqueSpawned;
    private int manteSpawned;
    private void Awake()
    {
        if (waveManager == null)
        {
            waveManager = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        wave = 0;
        BeginWave(wave);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }



    public void GenerateMonster()
    {
        float random = Random.Range(0, 4);
        if (random < 1)
        {
            if (godzillaSpawned < currentWave.godzillaNb)
            {
                spawnMonster(0);
                return;
            }
            else
            {
                GenerateMonster();
            }
        }
        else
        {
            if (random < 2)
            {
                if (serpentSpawned < currentWave.serpentNb)
                {
                    spawnMonster(1);
                    return;
                }
                else
                {
                    GenerateMonster();
                }
            }
            else
            {
                if (random < 3)
                {
                    if (moustiqueSpawned < currentWave.moustiqueNb)
                    {
                        spawnMonster(2);
                        return;
                    }
                    else
                    {
                        GenerateMonster();
                    }
                }
                else
                {
                    if (manteSpawned < currentWave.manteNb)
                    {
                        spawnMonster(3);
                        return;
                    }
                    else
                    {
                        GenerateMonster();
                    }
                }
            }
        }
    }

    public bool isWaveSpawned()
    {
        if (godzillaSpawned == currentWave.godzillaNb && serpentSpawned == currentWave.serpentNb &&
            moustiqueSpawned == currentWave.moustiqueNb && manteSpawned == currentWave.manteNb)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void BeginWave(int waveNb)
    {
        if (waves.Count > waveNb)
        {
            currentWave = waves[wave];
            StartCoroutine(spawnCountdown(currentWave.timeBetweenSpawns));
            
        }
    }

    public void spawnMonster(int monster)
    {
        switch (monster)
        {
            case 0:
                godzillaSpawned++;
                Debug.Log("gozilla");
                break;
            case 1:
                serpentSpawned++;
                Debug.Log("serpent");
                break;
            case 2:
                moustiqueSpawned++;
                Debug.Log("moustique");
                break;
            case 3:
                manteSpawned++;
                Debug.Log("mante religieuse");
                break;
            
        }
    }

    private IEnumerator spawnCountdown(float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            if (isWaveSpawned())
            {
                StopCoroutine(spawnCountdown(time));
            }
            else
            {
                GenerateMonster(); 
            }

            

        }

    }
}
