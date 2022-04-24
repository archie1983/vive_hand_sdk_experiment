using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFeed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WebCamTexture wct = new WebCamTexture();
        WebCamDevice[] devices = WebCamTexture.devices;
        wct.deviceName = devices[0].name;
        this.GetComponent<MeshRenderer>().material.mainTexture = wct;
        wct.Play();
    }
}
