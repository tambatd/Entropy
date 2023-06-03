//Create a UI element. To do this go to Create>UI and select from the list. Attach this script to the UI GameObject to see this script working. The script also works with non-UI elements, but highlighting works better with UI.

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//Use the Selectable class as a base class to access the IsHighlighted method
public class SelectTest : Selectable
{
    //Use this to check what Events are happening
    BaseEventData m_BaseEvent;

    void Update()
    {
        //Check if the GameObject is being highlighted
        if (IsHighlighted(m_BaseEvent) == true)
        {
            //Output that the GameObject was highlighted, or do something else
            Debug.Log("Selectable is Highlighted");
        }
    }
}