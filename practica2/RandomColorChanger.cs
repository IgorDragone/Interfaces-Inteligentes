using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorChanger : MonoBehaviour {
  public int frameDelay = 120; // public, so it can be set in the Inspector
  private Color color; 
  private Renderer objRenderer;
  private int frameCount;

  void Start() {
    objRenderer = GetComponent<Renderer>(); // Get the Renderer component
    color = new Color(Random.value, Random.value, Random.value);
    objRenderer.material.color = color;
    frameCount = 0;
  }

  void Update() {
    frameCount++;
    if (frameCount >= frameDelay) {
      int randomIndex = Random.Range(0, 3);    
      switch (randomIndex) {
        case 0:
          color.r = Random.value; // Changes the value of R
          break;
        case 1:
          color.g = Random.value; // Changes the value of G
          break;
        case 2:
          color.b = Random.value; // Changes the value of B
          break;
      }
      objRenderer.material.color = color;
      frameCount = 0;
    }
  }
}

