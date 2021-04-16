using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveContent : MonoBehaviour
{
    [Range(-20000, 20000)]
    public int max;
    [Range(-20000, 20000)]
    public int min;

    public GameObject prefab;
    public Transform component;
    private RectTransform componentRect;
    private Vector2 pos; 

    // Start is called before the first frame update
    void Start()
    {
        componentRect = prefab.GetComponent<RectTransform>();
        pos = new Vector2(50f, min);
    }

    // Update is called once per frame
    void Update()
    {

        if (componentRect.anchoredPosition.y < min)
        {
            pos.y = min;
            componentRect.anchoredPosition = pos;
        }
        else if (componentRect.anchoredPosition.y > max)
        {
            pos.y = max;
            componentRect.anchoredPosition = pos;
        }
    }
}
