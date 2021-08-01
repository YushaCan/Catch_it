using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraResponsive : MonoBehaviour
{
    public GameObject backGround;
    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        ResponsiveScreen();
    }

    private void ResponsiveScreen()
    {
        Vector2 deviceScreenResolution = new Vector2(Screen.width, Screen.height);
        Debug.Log(deviceScreenResolution);

        float scrHeight = Screen.height;
        float scrWidth = Screen.width;

        float DeviceScreenAspect = scrWidth / scrHeight;
        Debug.Log("DEVICE SCREEN ASPECT: " + DeviceScreenAspect.ToString());

        mainCamera.aspect = DeviceScreenAspect;

        float camHeight = 100.0f * mainCamera.orthographicSize * 2.5f;
        float camWidth = camHeight * DeviceScreenAspect;
        Debug.Log("cam Height " + camHeight.ToString());
        Debug.Log("cam Width " + camWidth.ToString());



        SpriteRenderer background = backGround.GetComponent<SpriteRenderer>();
        float bgHeight = background.sprite.rect.height;
        float bgWidth = background.sprite.rect.width;

        Debug.Log("BGHEIGHT: " + bgHeight.ToString());
        Debug.Log("BGWIDTH: " + bgWidth.ToString());

        float backgroundScaleRatioHeight = camHeight / bgHeight;
        float backgroundScaleRatioWidth = camWidth / bgWidth;

        backGround.transform.localScale = new Vector3(backgroundScaleRatioWidth, backgroundScaleRatioHeight, 1);
    }
}
