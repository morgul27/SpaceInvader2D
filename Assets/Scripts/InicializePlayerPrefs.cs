using UnityEngine;

public class InicializePlayerPrefs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (!PlayerPrefs.HasKey("Record")) //si no existe el documento lo crea con ese titulo
        {
            PlayerPrefs.SetInt("Record", 0); 
        }
    }

}
