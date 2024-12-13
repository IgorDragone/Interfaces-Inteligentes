using UnityEngine;
using TMPro;

public class SensorDisplay : MonoBehaviour
{
    // Referencias a los TextMeshPro Texts en la UI
    public TMP_Text angularVelocityText;
    public TMP_Text accelerationText;
    public TMP_Text altitudeText;
    public TMP_Text gravityText;
    public TMP_Text longitudeText;
    public TMP_Text latitudeText;

    private float gravity = 9.81f;
    private bool locationStarted = false;

    void Start()
    {
        if (Input.location.isEnabledByUser)
        {
            Input.location.Start(10f, 1f);
            Input.compass.enabled = true;
            locationStarted = true;
        }
        else
        {
            Debug.Log("GPS no habilitado por el usuario");
            latitudeText.text = "Latitud: GPS no habilitado";
            longitudeText.text = "Longitud: GPS no habilitado";
            altitudeText.text = "Altitud: GPS no habilitado";
        }
    }

    void Update()
    {
        UpdateAngularVelocity();
        UpdateAcceleration();
        UpdateGravity();
        UpdateLocation();
    }

    void UpdateAngularVelocity()
    {
        if (SystemInfo.supportsGyroscope)
        {
            Vector3 angularVelocity = Input.gyro.rotationRate;
            angularVelocityText.text = $"Velocidad Angular: {angularVelocity.magnitude:F2} rad/s";
        }
        else
        {
            angularVelocityText.text = "Velocidad Angular: Giroscopio no disponible";
        }
    }

    void UpdateAcceleration()
    {
        Vector3 acceleration = Input.acceleration;
        accelerationText.text = $"Aceleración: {acceleration.magnitude:F2} m/s²";
    }

    void UpdateGravity()
    {
        gravityText.text = $"Gravedad: {gravity:F2} m/s²";
    }

    void UpdateLocation()
    {
        if (locationStarted && Input.location.status == LocationServiceStatus.Running)
        {
            latitudeText.text = $"Latitud: {Input.location.lastData.latitude:F6}";
            longitudeText.text = $"Longitud: {Input.location.lastData.longitude:F6}";
            altitudeText.text = $"Altitud: {Input.location.lastData.altitude:F2} m";
        }
        else if (locationStarted && Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.Log("Error al obtener la ubicación");
            latitudeText.text = "Latitud: Error";
            longitudeText.text = "Longitud: Error";
            altitudeText.text = "Altitud: Error";
        }
    }

    void OnDestroy()
    {
        if (locationStarted)
        {
            Input.location.Stop();
        }
    }
}
