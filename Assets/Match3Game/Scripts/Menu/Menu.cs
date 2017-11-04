using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Menu : MonoBehaviour {
    Transform target, tr;
	void Start () {
	}
	
	void Update () {
	}

    public void OnStartClick() {
        SceneManager.LoadScene("Menu");
    }

    public void OnFildClick() {
        SceneManager.LoadScene("Game0");
    }
}
