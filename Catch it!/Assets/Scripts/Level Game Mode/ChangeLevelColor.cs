using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLevelColor : MonoBehaviour
{
  
    public List<Image> imageToChangeColors = new List<Image>();
    public List<LevelDesign> levels;
    // Start is called before the first frame update
    void Start()
    {
        GetComponentsInChildren(imageToChangeColors);
        ColorChange();
    }
    private void OnEnable()
    {
        ColorChange();
    }
    void ColorChange()
    {
        if (levels[0].isLevelCompleted == false && levels[1].isLevelCompleted == false)
        {
            imageToChangeColors[0].color = new Color32(216, 0, 255, 255);
        }
        for (int i = 1; i < imageToChangeColors.Count; i++)
        {
            if (levels[i].isLevelCompleted == false && levels[i - 1].isLevelCompleted == true)
            {
                imageToChangeColors[i].color = new Color32(216, 0, 255, 255);
            }
        }
        for (int i = 0; i < imageToChangeColors.Count; i++)
        {
            if (levels[i].isLevelCompleted == true)
            {
                imageToChangeColors[i].color = new Color32(0, 255, 19, 255);
            }
        }
    }
}
