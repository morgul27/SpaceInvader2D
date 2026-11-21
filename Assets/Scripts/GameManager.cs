using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManagerInstance;

    [SerializeField] int lifes = 3;
    [SerializeField] Image[] lifeSprites;

    [SerializeField] GameObject panelGameOver;
    [SerializeField] GameObject player;
    //[SerializeField] TextMeshProUGUI lifeText;

    [Header("Configuración de Vibración")]
    [SerializeField] float duracionVibracion = 0.2f;
    [SerializeField] float intensidadBase = 15f;

    private RectTransform LifeRectTransform;
    private Vector2 posicionOriginal;

    private RectTransform[] lifeRectTransforms;
    private Vector2[] posicionesOriginales;

    private void Awake()
    {
        gameManagerInstance = this;
    }

    private void Start()
    {
        lifeRectTransforms = new RectTransform[lifeSprites.Length];
        posicionesOriginales = new Vector2[lifeSprites.Length];

        for (int i = 0; i < lifeSprites.Length; i++)
        {
            lifeRectTransforms[i] = lifeSprites[i].GetComponent<RectTransform>();
            posicionesOriginales[i] = lifeRectTransforms[i].anchoredPosition;
        }
    }


    public void PlayerLoseLifes()
    {
        lifes--;
        StartCoroutine(VibrateLife());

        //lifeText.text = "x" + lifes.ToString();

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

    private IEnumerator VibrateLife()
    {
        float tiempo = 0f;

        while (tiempo < duracionVibracion)
        {
            float offsetX = Random.Range(-1f, 1f) * intensidadBase;
            float offsetY = Random.Range(-1f, 1f) * intensidadBase;
            Vector2 offset = new Vector2(offsetX, offsetY);

            for (int i = 0; i < lifeRectTransforms.Length; i++)
            {
                lifeRectTransforms[i].anchoredPosition = posicionesOriginales[i] + offset;
            }

            tiempo += Time.unscaledDeltaTime;
            yield return null;
        }
        for (int i = 0; i < lifeRectTransforms.Length; i++)
        {
            lifeRectTransforms[i].anchoredPosition = posicionesOriginales[i];
        }
    }
}
