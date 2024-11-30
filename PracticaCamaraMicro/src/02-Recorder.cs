using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recorder : MonoBehaviour
{
    private AudioSource audioSource;
    private string microphoneName;

    void Start()
    {
        // Configura el AudioSource
        audioSource = gameObject.AddComponent<AudioSource>();

        // Obtener el primer micrófono disponible
        if (Microphone.devices.Length > 0)
        {
            microphoneName = Microphone.devices[0];
            Debug.Log("Micrófono detectado: " + microphoneName);
        }
        else
        {
            Debug.LogError("No se detectaron micrófonos en el dispositivo.");
        }
    }

    void Update()
    {
        // Detectar si se está manteniendo presionada la tecla R
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartMicrophone();
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            StopMicrophone();
        }
    }

    void StartMicrophone()
    {
        if (microphoneName != null && !audioSource.isPlaying)
        {
            Debug.Log("Iniciando captura del micrófono...");
            audioSource.clip = Microphone.Start(microphoneName, false, 10, 44100);
            while (!(Microphone.GetPosition(microphoneName) > 0)) { } // Esperar a que el micrófono comience a capturar
            audioSource.Play(); // Reproducir el audio capturado en tiempo real
        }
    }

    void StopMicrophone()
    {
        if (microphoneName != null)
        {
            Debug.Log("Deteniendo captura del micrófono...");
            Microphone.End(microphoneName); // Finalizar la captura
            audioSource.Stop(); // Detener la reproducción
        }
    }
}
