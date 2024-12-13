using UnityEngine;
using System.Collections;

public class SamuraiController : MonoBehaviour
{
    public float speedMultiplier = 5f;       
    public float smoothing = 0.1f;        
    public float maxLatitude = 28.5f;        
    public float minLatitude = 28.0f;
    public float maxLongitude = -16.0f;      
    public float minLongitude = -16.5f;

    private Quaternion targetRotation;             

    void Start()
    {
        Input.location.Start();
        Input.compass.enabled = true;
        Input.gyro.enabled = true;
        
    }

    void Update()
    {
        UpdateRotation();
        UpdateMovement();
        CheckLocationBounds();
    }

    void UpdateRotation()
    {
        float heading = Input.compass.trueHeading;
        targetRotation = Quaternion.Euler(0, heading, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smoothing);
    }

    void UpdateMovement()
    {
        Vector3 acceleration = Input.acceleration;
        float moveZ = -acceleration.z * speedMultiplier;
        transform.Translate(Vector3.forward * moveZ * Time.deltaTime);
    }

    void CheckLocationBounds()
    {
        if (Input.location.status == LocationServiceStatus.Running)
        {
            float latitude = Input.location.lastData.latitude;
            float longitude = Input.location.lastData.longitude;

            if (latitude > maxLatitude || latitude < minLatitude ||
                longitude > maxLongitude || longitude < minLongitude)
            {
                Debug.Log("Fuera de los límites permitidos. Movimiento detenido.");
                transform.Translate(Vector3.zero);
            }
        }
        else
        {
            Debug.Log("Esperando datos de GPS...");
        }
    }
}
