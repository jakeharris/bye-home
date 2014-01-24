using UnityEngine;
using System.Collections;

public class MementoScript : MonoBehaviour {

    public GUIStyle completionLabelStyle;

    void OnGUI()
    {
        int completionLabelHeight = 100;
        int completionLabelCount = 0;
        if (PlayerPrefs.HasKey("tundra"))
        {
            GUI.Label(
                new Rect(
                    0, completionLabelCount * completionLabelHeight, 300, completionLabelHeight
                ), "Akko the Arctic Fox", completionLabelStyle
            );
            GUI.Label(
                new Rect(
                    0, completionLabelCount * completionLabelHeight + 30, 300, completionLabelHeight
                ), "Akko is a tundra-dwelling arctic fox. He's a family animal, so he's very happy to be back in his den, reunited with his family.", completionLabelStyle
            );
            completionLabelCount++;
        }
        if (PlayerPrefs.HasKey("desert"))
        {
            GUI.Label(
                new Rect(
                    0, completionLabelCount * completionLabelHeight, 300, completionLabelHeight
                ), "Gamma the Desert Shrew", completionLabelStyle
            );
            GUI.Label(
                new Rect(
                    0, completionLabelCount * completionLabelHeight + 30, 300, completionLabelHeight
                ), "Gamma is a survivor of the desert, a desert shrew. She's glad to have found her way back to her favorite shrub for shade.", completionLabelStyle
            );
            completionLabelCount++;
        }
        if (PlayerPrefs.HasKey("grasslands"))
        {
            GUI.Label(
                new Rect(
                    0, completionLabelCount * completionLabelHeight, 300, completionLabelHeight
                ), "Phaze the Zebra", completionLabelStyle
            );
            GUI.Label(
                new Rect(
                    0, completionLabelCount * completionLabelHeight + 30, 300, completionLabelHeight
                ), "Phaze is a majestic equine of the grasslands, a zebra. He's very social, so he's glad to see his friends again by the watering hole.", completionLabelStyle
            );
            completionLabelCount++;
        }
    }
}
