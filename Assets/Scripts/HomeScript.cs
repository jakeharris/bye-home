using UnityEngine;
using System.Collections;

public class HomeScript : MonoBehaviour {

    void Awake()
    {
        if (Application.isEditor)
        {
            //PlayerPrefs.DeleteAll();
        }
    }

    void OnGUI()
    {
        if (GUI.Button(
            new Rect(
                0,
                0,
                Screen.width / 3,
                Screen.height
            ), "Adventure!")
        )
        {
            int random = Random.Range(1, Application.levelCount - 1);
            while(PlayerPrefs.HasKey(getLevelNameFromInt(random))) {
                random = Random.Range(1, Application.levelCount - 1);
            }
            Application.LoadLevel(random);
        }
        if (GUI.Button(
              new Rect(
                Screen.width / 3,
                0,
                Screen.width / 3,
                Screen.height
            ), "Mementos")
        )
        {
            Application.LoadLevel("memento");
        }
        if (GUI.Button(
            new Rect(
                Screen.width * 2 / 3,
                0,
                Screen.width / 3,
                Screen.height
            ), "Quit")
        )
        {
            Application.Quit();
        }
    }

    string getLevelNameFromInt(int r)
    {
        switch (r) {
            case 1:
                return "tundra";
            case 2:
                return "grasslands";
            case 3:
                return "desert";
            default:
                return "";
        }
    }
}
