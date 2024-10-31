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
        // Baþlangýçta sadece ilk kamerayý etkinleþtir
        SwitchCamera(currentCameraIndex);
    }

    void Update()
    {
        // Tuþlara basýldýðýnda kamerayý deðiþtir
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
        // Geçerli kamerayý devre dýþý býrak
        cameras[currentCameraIndex].gameObject.SetActive(false);

        // Yeni kamerayý etkinleþtir
        currentCameraIndex = index;
        cameras[currentCameraIndex].gameObject.SetActive(true);
    }
}
