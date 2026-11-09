using UnityEngine;

public class FXManager : MonoBehaviour
{
    public static FXManager fxManagerInstance;

    [SerializeField] AudioSource source;

    private void Awake()
    {
        fxManagerInstance = this;
    }

    public void PlaySound(AudioClip clip)
    {
        source.PlayOneShot(clip);
    }
}
