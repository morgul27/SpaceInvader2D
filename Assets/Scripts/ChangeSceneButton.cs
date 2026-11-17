using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneButton : MonoBehaviour
{
    [SerializeField]int sceneIndex;

    public void GoToScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
