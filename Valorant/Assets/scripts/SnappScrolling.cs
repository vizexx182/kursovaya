using UnityEngine;

public class SnappScrolling : MonoBehaviour
{
    [Range (0, 1000f)]
    public float scaleOffset;

    public GameObject[] instPans;

    [Range(1, 1000f)]
    public float hight;
    [Range(1, 1000f)]
    public float space;

    private Vector2[] pansPos;
    private int pansSerchID;
    [Range(1, 100f)]
    public float snapSpeed;

    private RectTransform contentRect;

    private Vector2 contentVector;

    private bool isScrolling;

    private Vector2[] pansScale;

    void Start()
    {
        contentRect = GetComponent<RectTransform>();
        pansPos = new Vector2[instPans.Length];
        pansScale = new Vector2[instPans.Length];
        for (int i = 0; i < instPans.Length; ++i)
        {
            if (i > 0)
                instPans[i].transform.localPosition = new Vector2(instPans[i].transform.localPosition.x, instPans[i - 1].transform.localPosition.y - hight - space);
            
            pansPos[i] = instPans[i].transform.localPosition;
        }
    }

    private void FixedUpdate()
    {
        float minLength = float.MaxValue;
        for (int i = 0; i < instPans.Length; ++i)
        {
            float distans = Mathf.Abs(contentRect.anchoredPosition.y - pansPos[i].y);
            if (distans < minLength)
            {
                minLength = distans;
                pansSerchID = i;
            }
        }

        if (isScrolling) return;

        contentVector.y = Mathf.SmoothStep(contentRect.anchoredPosition.y, pansPos[pansSerchID].y, snapSpeed * Time.fixedDeltaTime);
        contentVector.x = contentRect.anchoredPosition.x;
        contentRect.anchoredPosition = contentVector;
    }

    public void scrolling (bool scroll)
    {
        isScrolling = scroll;
    }
}
