using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Chat item
/// </summary>
public class ChatItem : MonoBehaviour {

    /// <summary>
    /// Link to bg
    /// </summary>
    [SerializeField]
    Image Background = null;

    /// <summary>
    /// Link to message
    /// </summary>
    [SerializeField]
    Text MessageText = null;

    /// <summary>
    /// Link to container
    /// </summary>
    [SerializeField]
    RectTransform Container = null;


    void Start() {
        // Set text content with Unicode emoji string
    }
    /// <summary>
    /// Add message to item
    /// </summary>
    /// <param name="message">Message text</param>
    /// <param name="isMyMessage">Flag to highlight</param>
    public void SetData(string message, bool isMyMessage) {
        MessageText.text = message;
        Background.color = isMyMessage ? Color.white : Color.gray;
        Container.anchorMax = isMyMessage ? Vector2.one : Vector2.up;
        Container.anchorMin = isMyMessage ? Vector2.one : Vector2.up;
        Container.pivot = isMyMessage ? Vector2.one : Vector2.up;
    }
}
