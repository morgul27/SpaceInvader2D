using DG.Tweening;
using UnityEngine;

public class AlienPath : MonoBehaviour
{
    public Transform[] nodos; //Los nodos del camino
    public float duracion = 5f; //Tiempo en hacer el camino, en segundos

    private void Awake()
    {
        int indiceAleatorio = Random.Range(0, 2);
        Debug.Log("numero aleatorio es " + indiceAleatorio);
        nodos = SpawnersManagers.spawnersManagersInstance.nodos;
    }

    void Start()
    {
        Vector3[] vectoresCoordenadas = new Vector3[nodos.Length];

        //inicializacion(int i), condicion de mantenimiento(puntos.lenght) y actualizacion(i++)
        for (int i = 0; i < nodos.Length; i++) //la i significa Iterador
        {
            vectoresCoordenadas[i] = nodos[i].position;
        }

        //CatmullRom
        transform.DOPath(vectoresCoordenadas, duracion, PathType.Linear).SetEase(Ease.Linear);
        //mirar https://easings.net/ y poner .SetEase(Ease.) y lo que sea, no hace falta poner el .SetEase
    }
}
