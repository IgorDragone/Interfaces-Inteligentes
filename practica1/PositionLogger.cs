using UnityEngine;

public class PositionLogger : MonoBehaviour
{
    void Start()
    {
        // Log la posición de este objeto en la consola al inicio
        Debug.Log(gameObject.name + " está en la posición: " + transform.position);
    }
}