using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManagerInstance;

    [SerializeField] int lifes = 3;
    [SerializeField] Image[] lifeSprites;

    [SerializeField] GameObject panelGameOver;
    [SerializeField] GameObject player;
    [SerializeField] TextMeshProUGUI lifeText;


    private void Awake()
    {
        gameManagerInstance = this;
    }


    public void PlayerLoseLifes()
    {
        lifes--;
        Debug.Log("ha pasado 1 vez, " + lifes);
        lifeText.text = "x" + lifes.ToString();

        for (int i = 0; i < lifeSprites.Length; i++)
        {
            lifeSprites[i].enabled = false;
        }

        for (int i = 0; i < lifes; i++)
        {
            lifeSprites[i].enabled = true;
        }

        if (lifes <= 0)
        {
            panelGameOver.SetActive(true);
        }
        else
        {
            Instantiate(player, transform.position, Quaternion.identity);
        }
    }
}
