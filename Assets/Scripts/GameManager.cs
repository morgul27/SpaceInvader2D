using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManagerInstance;

    [SerializeField] int lifes;
    [SerializeField] Image[] lifeSprites;

    [SerializeField] GameObject panelGameOver;
    //[SerializeField] Player 


    private void Awake()
    {
        gameManagerInstance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerDie()
    {
        lifes--;

        for (int i = 0; i < lifeSprites.Length; i++)
        {
            lifeSprites[i].enabled = false;
        }

        for (int i = 0; i < lifes; i++)
        {
            lifeSprites[i].enabled = true;
        }

        if(lifes <= 0)
        {
            panelGameOver.SetActive(true);
        }
        else
        {
            //Instantiate(player, transform.position,);
        }
    }
}
