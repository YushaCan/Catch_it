using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DynamicListView : MonoBehaviour
{
    public Transform listItemHolder;
    //public int numOfListItems;
    public List<GameObject> images;
    public List<LevelDesign> levels;
    public GameManager gameManager;
    private void Start()
    {
        for(int i = 0; i < levels.Count; i++)
        {
            Instantiate(levels[i].image, listItemHolder);
            images.Add(levels[i].image);
        }
    }
}
