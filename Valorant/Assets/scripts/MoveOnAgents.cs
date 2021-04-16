using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveOnAgents : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("Agents");
    }
}
