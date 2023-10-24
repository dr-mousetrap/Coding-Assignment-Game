using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuEvents : MonoBehaviour
{
    public void LoadLevel (int index)
    {
        SceneManager.LoadScene(index);
    }

}
