using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LogoScene : MonoBehaviour
{
    [SerializeField] float timeToChangeScene;

    private void Start()
    {
        StartCoroutine(GoToMenuCorrutina());
    }

    IEnumerator GoToMenuCorrutina()
    {
        yield return new WaitForSeconds(timeToChangeScene);
        SceneManager.LoadScene(1);

        //otro que se usa es: "yield return null", que retrasa un frame
    }
}
