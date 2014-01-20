using UnityEngine;
using System.Collections;

public class HomeScript : MonoBehaviour {

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
            int random = Random.Range(1, Application.levelCount);
            Application.LoadLevel(random);
        }
    }
}
