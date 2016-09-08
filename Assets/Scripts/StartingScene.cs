using UnityEngine;
using System.Collections;


public class StartingScene : MonoBehaviour {
    public void ChangeScene(string changeSceneTo) {
        Application.LoadLevel("main");

    }
    public void ChangeAnotherScene(string goBackScene) {
        Application.LoadLevel("Starting Scene");
    }
    public void QuitGame() {
        Application.Quit();
    }
}
