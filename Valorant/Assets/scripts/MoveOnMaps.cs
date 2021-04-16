using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveOnMaps : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("Maps");
    }
}
