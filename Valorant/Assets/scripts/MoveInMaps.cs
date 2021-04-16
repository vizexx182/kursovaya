using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveInMaps : MonoBehaviour
{
    public string scane;
    void OnMouseDown()
    {
        SceneManager.LoadScene(scane);
    }
}
