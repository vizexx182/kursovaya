using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveOnGameMechanics : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("Game Mechanics");
    }
}
