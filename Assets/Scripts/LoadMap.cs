using UnityEngine;
using System.Collections;

public class LoadMap : MonoBehaviour {

    public void ChangeScene(string changeSceneOne) {
        Application.LoadLevel("level_01");
    }

    public void ChangeScene2(string changeSceneTwo) {
        Application.LoadLevel("level_02");
    }

    public void ChangeScene3(string changeSceneThree) {
        Application.LoadLevel("level_03");
    }

    public void GoBackScene(string goBackToStart) {
        Application.LoadLevel("Starting Scene");
    }

}
