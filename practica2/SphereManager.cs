using UnityEngine;

public class SphereManager : MonoBehaviour {
  private GameObject cube;
  public float heightIncrease = 3.0f;
  public Color distantColor = Color.red;
	private GameObject closestSphere;
	private GameObject farthestSphere;

	void Start() {
		cube = GameObject.FindWithTag("ReferenceCube");
		closestSphere = GetClosestSphere("T2Sphere");
		if (closestSphere != null) {
      closestSphere.transform.position += new Vector3(0, heightIncrease, 0);
    }

		farthestSphere = GetFarthestSphere("T2Sphere");
	}

  void Update() {
  

    if (Input.GetKeyDown(KeyCode.Space)) {
      if (farthestSphere != null) {
        Renderer sphereRenderer = farthestSphere.GetComponent<Renderer>();
        sphereRenderer.material.color = distantColor;
      }
    }
    }

    // Método para obtener la esfera de tipo 2 más cercana al cubo
  GameObject GetClosestSphere(string tag) {
    GameObject[] spheres = GameObject.FindGameObjectsWithTag(tag);
    GameObject closestSphere = null;
    float closestDistance = Mathf.Infinity;
    foreach (GameObject sphere in spheres) {
      float distance = Vector3.Distance(cube.transform.position, sphere.transform.position);
			Debug.Log("Distance: " + distance);
      if (distance < closestDistance) {
        closestDistance = distance;
        closestSphere = sphere;
      }
    }
    return closestSphere;
  }

    // Método para obtener la esfera de tipo 2 más lejana al cubo
  GameObject GetFarthestSphere(string tag) {
    GameObject[] spheres = GameObject.FindGameObjectsWithTag(tag);
    GameObject farthestSphere = null;
    float farthestDistance = 0;
    foreach (GameObject sphere in spheres) {
      float distance = Vector3.Distance(cube.transform.position, sphere.transform.position);
      if (distance > farthestDistance) {
      	farthestDistance = distance;
      	farthestSphere = sphere;
      }
    }
    return farthestSphere;
  }
}

