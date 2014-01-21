using UnityEngine;
using System.Collections;

public class EndNode : ConversationNode {

    public bool completesQuest = false;
    private bool isEnding = false;

    public void End()
    {
        isEnding = true;
        if (completesQuest)
        {
            PlayerPrefs.SetInt("Tundra", 0); //basically just say SOMETHING about the tundra to signal that we beat it
            GameObject background = GameObject.Find("Background");
            if (background != null)
            {
                Color tempcolor = background.GetComponent<SpriteRenderer>().color;
                tempcolor.a = 1.0f;
                background.GetComponent<SpriteRenderer>().color = tempcolor;
            }
        }
    }

    public bool isConversationEnding()
    {
        return isEnding;
    }

}
