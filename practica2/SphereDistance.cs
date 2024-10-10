using UnityEngine;

public class SphereDistance : MonoBehaviour {
  private GameObject cube;
  private GameObject cylinder;

  void Start() {
    cube = GameObject.FindWithTag("Cube");
    cylinder = GameObject.FindWithTag("Cylinder");
    if (cube != null && cylinder != null) {
      Vector3 spherePosition = transform.position;
      Vector3 cubePosition = cube.transform.position;
      Vector3 cylinderPosition = cylinder.transform.position;
      float distanceToCube = Vector3.Distance(spherePosition, cubePosition);
      float distanceToCylinder = Vector3.Distance(spherePosition, cylinderPosition);
      Debug.Log("Distancia desde la esfera al cubo: " + distanceToCube);
      Debug.Log("Distancia desde la esfera al cilindro: " + distanceToCylinder);
    } else {
      Debug.LogError("No se pudieron encontrar el cubo o el cilindro.");
    }
  }
}
