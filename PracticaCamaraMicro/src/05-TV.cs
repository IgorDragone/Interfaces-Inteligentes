using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TV : MonoBehaviour
{
    private WebCamTexture webcamTexture;
    private Renderer screenRenderer;
    private Texture2D photoTexture;
    void Start()
    {
        screenRenderer = GetComponent<Renderer>();
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

    void Update()
    {
        if (Input.GetKey("s")) {
            if (!webcamTexture.isPlaying)
            {
                webcamTexture.Play();
            }
            screenRenderer.material.mainTexture = webcamTexture;
        }
        if (Input.GetKey("p")) {
            if (webcamTexture.isPlaying)
            {
                webcamTexture.Stop();
                Debug.Log("Cámara detenida.");
            }
        }
        if (Input.GetKey("x")) {
            if (webcamTexture.isPlaying)
            {
                TakePhoto();
            }
        }
    }

    private void TakePhoto()
    {
        photoTexture = new Texture2D(webcamTexture.width, webcamTexture.height, TextureFormat.RGB24, false);
        photoTexture.SetPixels(webcamTexture.GetPixels());
        photoTexture.Apply();
        screenRenderer.material.mainTexture = photoTexture;
        SaveTextureAsPNG(photoTexture, "CapturedImage_" + System.DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png");
        Debug.Log("Foto capturada y guardada.");
    }

    private void SaveTextureAsPNG(Texture2D texture, string fileName)
    {
        byte[] bytes = texture.EncodeToPNG();
        string path = Path.Combine(Application.dataPath, "Captures");
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        string fullPath = Path.Combine(path, fileName);
        File.WriteAllBytes(fullPath, bytes);
        Debug.Log("Archivo guardado en: " + fullPath);
    }
}
