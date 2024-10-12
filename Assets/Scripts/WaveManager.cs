using System.Collections;
using System.Collections.Generic;
using Monster;
using Unity.Mathematics;
//using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

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

    public Godzilla godzillaReference;
    public Serpent serpentReference;
    public Insecte moustiqueReference;
    public ManteReligieuse manteReference;
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
        if (isWaveSpawned() && GameManager.gameManager.enemies.Count == 0)
        {
            Debug.Log("newWave!");
            wave++;
            godzillaSpawned = 0;
            serpentSpawned = 0;
            moustiqueSpawned = 0;
            manteSpawned = 0;
            
            BeginWave(wave);
        }
        
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
        Monster.Monster newMonster;
        switch (monster)
        {
            case 0:
                godzillaSpawned++;
                newMonster = Instantiate(godzillaReference, MapManager.mapManager.pointsRepere[0], quaternion.identity);
                GameManager.gameManager.enemies.Add(newMonster);
                break;
            case 1:
                serpentSpawned++;
                newMonster = Instantiate(serpentReference, MapManager.mapManager.pointsRepere[0], quaternion.identity);
                GameManager.gameManager.enemies.Add(newMonster);
                Debug.Log("serpent");
                break;
            case 2:
                moustiqueSpawned++;
                newMonster = Instantiate(moustiqueReference, MapManager.mapManager.pointsRepere[0], quaternion.identity);
                GameManager.gameManager.enemies.Add(newMonster);
                Debug.Log("moustique");
                break;
            case 3:
                manteSpawned++;
                newMonster = Instantiate(manteReference, MapManager.mapManager.pointsRepere[0], quaternion.identity);
                GameManager.gameManager.enemies.Add(newMonster);
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
