using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreen : MonoBehaviour
{
    [SerializeField] Camera camera1;
    [SerializeField] Camera camera2;
    [SerializeField] GameObject titleScreenUI;

    public void StartProject()
    {
        camera1.gameObject.SetActive(false);
        camera2.gameObject.SetActive(true);
        titleScreenUI.SetActive(false);
    }
}
