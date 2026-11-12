using System.Collections;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManagerInstance;

    [SerializeField] int puntuacionTotal;
    [SerializeField] TextMeshProUGUI scoreText;

    [Header("Configuración de Vibración")]
    [SerializeField] float duracionVibracion = 0.2f;
    [SerializeField] float intensidadBase = 8f;
    [SerializeField] float intensidadMaxima = 35f;

    [Header("Escalado por Puntos")]
    [SerializeField] int siguienteMeta = 100;
    [SerializeField] float incrementoIntensidad = 10f;

    private float intensidadActual;
    private RectTransform scoreRectTransform;
    private Vector2 posicionOriginal;


    private void Awake()
    {
        scoreManagerInstance = this;
        scoreRectTransform = scoreText.GetComponent<RectTransform>();
    }

    private void Start()
    {
        scoreText.text = "Score: " + puntuacionTotal.ToString();
        posicionOriginal = scoreRectTransform.anchoredPosition;
        intensidadActual = intensidadBase;
    }

    public void AddScore(int number)
    {
        puntuacionTotal = puntuacionTotal + number;
        //Debug.Log("la puntuacion es: " + puntuacionTotal);
        scoreText.text = "Score: " + puntuacionTotal.ToString();

        //a partir de aqui es vibracion de texto
        while (puntuacionTotal >= siguienteMeta)
        {
            siguienteMeta *= 2; 
            intensidadActual = Mathf.Min(intensidadActual + 
                incrementoIntensidad, intensidadMaxima);
        }

        StopAllCoroutines();
        StartCoroutine(VibrarScore());
    }

    private IEnumerator VibrarScore()
    {
        float tiempo = 0f;

        while (tiempo < duracionVibracion)
        {
            float offsetX = Random.Range(-1f, 1f) * intensidadBase;
            float offsetY = Random.Range(-1f, 1f) * intensidadBase;

            scoreRectTransform.anchoredPosition = posicionOriginal + new Vector2(offsetX, offsetY);

            tiempo += Time.unscaledDeltaTime;
            yield return null;
        }

        scoreRectTransform.anchoredPosition = posicionOriginal;
    }


}