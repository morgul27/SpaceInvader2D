using TMPro;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    public static LifeManager lifeManagerInstance;

    [SerializeField] int lifeTotal;
    [SerializeField] TextMeshProUGUI lifeText;

    private void Start()
    {
        lifeText.text = "x" + lifeTotal.ToString();
    }

    private void Awake()
    {
        lifeManagerInstance = this;
    }

    public void LoseLife()
    {
        Debug.Log("te han quitado vida, ahora tiene: " + PlayerLife.playerLifeInstance.life);
        lifeText.text = "x" + PlayerLife.playerLifeInstance.life.ToString();
    }

}
