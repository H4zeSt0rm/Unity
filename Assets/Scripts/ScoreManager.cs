using UnityEngine;
using UnityEngine.UIElements;

public class ScoreManager : MonoBehaviour
{
    public static Label scoreLabel;

    private void Awake()
    {
        scoreLabel = GetComponent<UIDocument>().rootVisualElement.Query<Label>("Score");
    }
}