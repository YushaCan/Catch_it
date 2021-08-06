using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DynamicListView : MonoBehaviour
{
    public GameObject listItemPrefab;
    public Transform listItemHolder;
    public int numOfListItems;
    public List<GameObject> images;

    private void Start()
    {
        for(int i = 0; i < numOfListItems; i++)
        {
            Instantiate(listItemPrefab, listItemHolder);
            images.Add(listItemPrefab);
        }
    }


    public void ChangeColor()
    {
        //images[LevelChange.previousLevel].GetComponent<Image>().color = new Color32(0,255,19,255);
    }
}
