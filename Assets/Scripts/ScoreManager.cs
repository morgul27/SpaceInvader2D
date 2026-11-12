using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManagerInstance;

    [SerializeField] int puntuacionTotal;
    [SerializeField] TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText.text = "Score: " + puntuacionTotal.ToString();
    }

    private void Awake()
    {
        scoreManagerInstance = this;
    }

    public void AddScore(int number)
    {
        puntuacionTotal = puntuacionTotal + number;
        //Debug.Log("la puntuacion es: " + puntuacionTotal);
        scoreText.text = "Score: " + puntuacionTotal.ToString();
    }

    

}