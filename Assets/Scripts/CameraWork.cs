using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWork : MonoBehaviour
{

    public Camera[] cameras = new Camera[9]; // Kamera dizisi
    private int currentCameraIndex = 0;

    void Start()
    {
        // Ba�lang��ta sadece ilk kameray� etkinle�tir
        SwitchCamera(currentCameraIndex);
    }

    void Update()
    {
        // Tu�lara bas�ld���nda kameray� de�i�tir
        for (int i = 0; i < cameras.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i)) // Alpha1, Alpha2, ... Alpha9
            {
                SwitchCamera(i);
            }
        }
    }

    void SwitchCamera(int index)
    {
        // Ge�erli kameray� devre d��� b�rak
        cameras[currentCameraIndex].gameObject.SetActive(false);

        // Yeni kameray� etkinle�tir
        currentCameraIndex = index;
        cameras[currentCameraIndex].gameObject.SetActive(true);
    }
}
