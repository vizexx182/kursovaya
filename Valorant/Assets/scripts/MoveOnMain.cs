using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveOnMain : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("main");
    }
}
