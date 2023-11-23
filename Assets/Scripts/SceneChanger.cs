
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public void scene_changer(string Scene_WildCat)
    {
        SceneManager.LoadScene(Scene_WildCat);
    }
}
