using UnityEngine;

public class ColorChanger : MonoBehaviour {
	private GameObject cube;
	private GameObject cylinder;
	public Color cubeColor;
	public Color cylinderColor;

  void Start() {
		cube = GameObject.FindWithTag("Cube");
		cylinder = GameObject.FindWithTag("Cylinder");
		
  }

  void Update() {
    if (Input.GetKeyDown(KeyCode.C)) {
			cylinder.GetComponent<Renderer>().material.color = cylinderColor;
		}
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			cube.GetComponent<Renderer>().material.color = cubeColor;
		}
  }
}
