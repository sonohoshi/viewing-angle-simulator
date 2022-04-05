using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FovController : MonoBehaviour
{
    [SerializeField] private Camera camera;
    [SerializeField] private Slider fovSlider;
    [SerializeField] private Text fovText;

    private const string FovFormat = "Now FOV value : {0:F}°";
    
    private void Awake()
    {
        fovText.text = string.Format(FovFormat, camera.fieldOfView);
        fovSlider.value = camera.fieldOfView;
        fovSlider.onValueChanged.AddListener(value =>
        {
            camera.fieldOfView = value;
            fovText.text = string.Format(FovFormat, camera.fieldOfView);
        });
    }
}
