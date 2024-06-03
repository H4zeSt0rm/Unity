using UnityEngine;
using UnityEngine.UIElements;

public class ScoreManager : MonoBehaviour
{
    public static Label scoreLabel;
    public static int score;

    private void Awake()
    {
        scoreLabel = GetComponent<UIDocument>().rootVisualElement.Query<Label>("Score");
        score = 0;
    }

    public static void addScore(int val)
    {
        score += val;
        scoreLabel.text = $"{score}";
    }
}