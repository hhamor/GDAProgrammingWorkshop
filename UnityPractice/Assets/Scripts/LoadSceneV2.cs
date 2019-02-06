using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneV2 : MonoBehaviour
{
    SceneFadeV2 fadeScreen;
    public int sceneNumber;

    void Awake() {
        fadeScreen = GameObject.FindObjectOfType<SceneFadeV2>();
    }

    public void Trigger() {
        Debug.Log("Begin EndScene");
        fadeScreen.BeginTransition(sceneNumber);
    }
}
