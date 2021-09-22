using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControler : MonoBehaviour
{
    private bool gyroenable;
    private Gyroscope gyro;

    private GameObject CameraContainer;
    private Quaternion rot;

    // Start is called before the first frame update
    void Start()
    {
        CameraContainer = new GameObject("Camera Container");
        CameraContainer.transform.position = transform.position;
        transform.SetParent(CameraContainer.transform);
        gyroenable = Enablegyro();
    }

    // Update is called once per frame
    void Update()
    {
        if (gyroenable)
        {
            transform.localRotation = gyro.attitude * rot;
        }
    }

    private bool Enablegyro()
    {
        if(SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            CameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            rot = new Quaternion(0, 0, 1, 0);

            return true;
        }
        return false;
    }

    
}
