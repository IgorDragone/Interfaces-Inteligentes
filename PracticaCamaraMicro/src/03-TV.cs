using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV : MonoBehaviour
{
    // declaracion de variables: Material, WebCamTexture y String para almacenar el path del directorio dodne almacenaremos las captura
    private WebCamTexture webcamTexture;
    private Renderer screenRenderer;
    private Texture2D photoTexture;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        screenRenderer = GetComponent<Renderer>();
        //Inicializamos el material al que posteriormente se le asignara cada frame de la camara
         if (WebCamTexture.devices.Length > 0)
        {
            string cameraName = WebCamTexture.devices[0].name;
            Debug.Log("Cámara detectada: " + cameraName);
            webcamTexture = new WebCamTexture(cameraName);
        }
        else
        {
            Debug.LogError("No se detectaron cámaras en el dispositivo.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("s")) {
            //Asignamos a la mainTexture del material el frame actual de la camara. La captura se inicia con Start()
            // Si la cámara no está activa, iníciala
            if (!webcamTexture.isPlaying)
            {
                webcamTexture.Play();
            }

            // Asignar el video de la cámara al material
            screenRenderer.material.mainTexture = webcamTexture;

        }
        if (Input.GetKey("p")) {
             // Detener la captura de la cámara
            if (webcamTexture.isPlaying)
            {
                webcamTexture.Stop();
                Debug.Log("Cámara detenida.");
            }
        }
        if (Input.GetKey("x")) {
            //Tomar foto
            // Tomar una foto y asignarla como textura
            if (webcamTexture.isPlaying)
            {
                TakePhoto();
            }
        }
    }

    private void TakePhoto()
    {
        // Crear una nueva textura con el tamaño del frame de la cámara
        photoTexture = new Texture2D(webcamTexture.width, webcamTexture.height, TextureFormat.RGB24, false);

        // Copiar los píxeles de la cámara a la textura
        photoTexture.SetPixels(webcamTexture.GetPixels());
        photoTexture.Apply();

        // Asignar la textura de la foto al material
        screenRenderer.material.mainTexture = photoTexture;

        Debug.Log("Foto tomada.");
    }
}
