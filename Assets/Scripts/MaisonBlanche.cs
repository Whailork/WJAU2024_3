using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaisonBlanche : MonoBehaviour
{
    // Variables
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArrayDay;
    public Sprite[] spriteArrayNight;
    public int pointDeVie;
    public int etat;
    public bool isDay;

    // Start is called before the first frame update
    void Start()
    {
        etat = 5;
        spriteArrayDay[0] = Resources.Load<Sprite>("d_damage1");
        spriteArrayDay[1] = Resources.Load<Sprite>("d_damage2");
        spriteArrayDay[2] = Resources.Load<Sprite>("d_damage3");

        spriteArrayNight[0] = Resources.Load<Sprite>("n_damage1");
        spriteArrayNight[1] = Resources.Load<Sprite>("n_damage2");
        spriteArrayNight[2] = Resources.Load<Sprite>("n_damage3");
    }

    // TODO : vérifier si elle change
    void Update()
    {
        if (GameManager.gameManager.Hp == 0 && etat != 2)
        {
            etat = 2;
            ChangeSprite(etat);
        }
        else if (GameManager.gameManager.Hp < 50 && etat != 1)
        {
            etat = 1;
            ChangeSprite(etat);
        }
        else if (GameManager.gameManager.Hp < 100 && etat != 0)
        {
            etat = 0;
            ChangeSprite(etat);
        }

    }

    void ChangeSprite(int x)
    {
        if (isDay)
        {
            spriteRenderer.sprite = spriteArrayDay[x];
        }
        else
        {
            spriteRenderer.sprite = spriteArrayNight[x];
        }
    }

    public void takeDamage(int damages)
    {
        pointDeVie -= damages;
    }

    void changeState()
    {

    }
}
