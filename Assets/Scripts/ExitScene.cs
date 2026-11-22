using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScene : MonoBehaviour
{
    [SerializeField] int sceneGo;

    public void GoScene()
    {
        SceneManager.LoadScene(sceneGo);
        Time.timeScale = 1f;
    }
}
