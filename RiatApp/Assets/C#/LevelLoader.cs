using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void OpenScene(string sceneName) => SceneManager.LoadScene(sceneName);
}
