using UnityEngine;
using System.Collections;

public class CursorChanger : MonoBehaviour
{

    [SerializeField] Texture2D hand_cursor;
    [SerializeField] Texture2D simple_cursor;

    private void Start()
    {
        Cursor.SetCursor(simple_cursor, Vector2.zero, CursorMode.Auto);
    }

    public void OnMouseOverButton()
    {
        //hand cursor if mouse over button
        Cursor.SetCursor(hand_cursor, Vector2.zero, CursorMode.Auto);
    }
    public void OnMouseNotOverButton()
    {
        //normal cursor if mouse not over a button
        Cursor.SetCursor(simple_cursor, Vector2.zero, CursorMode.Auto);
    }
}