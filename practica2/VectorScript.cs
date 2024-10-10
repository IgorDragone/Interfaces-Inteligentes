using UnityEngine;

public class VectorScript : MonoBehaviour {
  public Vector3 vectorA;
  public Vector3 vectorB;
  public float magnitudeA; // |A|
  public float magnitudeB; // |B|
  public float angleBetween;
  public float distanceBetween;
  public string higherVectorMessage;

  void Start() {
    magnitudeA = vectorA.magnitude;
    magnitudeB = vectorB.magnitude;
    angleBetween = Vector3.Angle(vectorA, vectorB);
    distanceBetween = Vector3.Distance(vectorA, vectorB);

    if (vectorA.y > vectorB.y) {
      higherVectorMessage = "Vector A está a una mayor altura.";
    } else if (vectorA.y < vectorB.y) {
      higherVectorMessage = "Vector B está a una mayor altura.";
    } else {
      higherVectorMessage = "Ambos vectores están a la misma altura.";
    }

    Debug.Log("Magnitud de Vector A: " + magnitudeA);
    Debug.Log("Magnitud de Vector B: " + magnitudeB);
    Debug.Log("Ángulo entre los vectores (en grados): " + angleBetween);
    Debug.Log("Distancia entre los vectores: " + distanceBetween);
    Debug.Log(higherVectorMessage);
  }
}
