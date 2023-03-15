using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCameraToImage : MonoBehaviour
{
    public UnityEngine.UI.RawImage image;

    private RenderTexture rt;
    private Camera targetCamera;

    private void Start()
    {
        targetCamera = GetComponent<Camera>();
        int resWidth = Screen.width / 2;
        int resHeight = Screen.height;
        rt = new RenderTexture(resWidth, resHeight, 24);
    }

    private void LateUpdate()
    {
        targetCamera.targetTexture = rt;
        image.texture = rt;

        targetCamera.Render();

        RenderTexture.active = rt;
        targetCamera.targetTexture = null;
        RenderTexture.active = null;
    }
}
