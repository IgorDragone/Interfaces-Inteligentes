using UnityEngine;

public class MarkerScript : MonoBehaviour {
  private GameObject obj1;
  private GameObject obj2;
  private GameObject obj3;  
  void Start() {
    obj1 = GameObject.FindWithTag("MovingCube1");
    obj2 = GameObject.FindWithTag("MovingCube2");
    obj3 = GameObject.FindWithTag("MovingCube3");
  }

	void Update() {
		if (Input.GetKeyDown(KeyCode.Space)) {
			obj1.GetComponent<Transform>().position += obj1.GetComponent<ObjectDisplacement>().displacement;
			obj2.GetComponent<Transform>().position += obj2.GetComponent<ObjectDisplacement>().displacement;
			obj3.GetComponent<Transform>().position += obj3.GetComponent<ObjectDisplacement>().displacement;
		}
	}
}
