using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoScene : MonoBehaviour
{
    [Header("Tiempos")]
    [SerializeField] float timeToChangeScene = 3f;
    [SerializeField] float fadeDuration = 1.5f;

    [Header("Referencias")]
    [SerializeField] CanvasGroup fadeCanvasGroup;

    private void Start()
    {
        StartCoroutine(GoToMenuCorrutina());
    }

    IEnumerator GoToMenuCorrutina()
    {
        yield return new WaitForSeconds(timeToChangeScene);

        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            fadeCanvasGroup.alpha = Mathf.Clamp01(elapsedTime / fadeDuration);
            yield return null;
        }
        yield return null;
        fadeCanvasGroup.alpha = 1f;
        SceneManager.LoadScene(1);

        //otro que se usa es: "yield return null", que retrasa un frame
    }
}
