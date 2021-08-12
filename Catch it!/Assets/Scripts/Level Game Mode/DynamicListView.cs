using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;
public class DynamicListView : MonoBehaviour
{
    public Transform listItemHolder;
    public List<Image> images;
    public List<LevelDesign> levels;
    private void Start()
    {
        for(int i = 0; i < levels.Count; i++)
        {
            Instantiate(levels[i].image, listItemHolder);
            images.Add(levels[i].image);
        }
    }
}
