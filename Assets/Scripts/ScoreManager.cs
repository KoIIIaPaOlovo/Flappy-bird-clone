using UnityEngine;

[CreateAssetMenu(fileName = "ScoreManager", menuName = "Scriptable Objects/ScoreManager")]
public class ScoreManager : ScriptableObject
{
    public int playerScore = 0;
    public event System.Action<int> OnChanged;

    public void Add()
    {
        int result = playerScore + 1;
        playerScore = result;
        OnChanged?.Invoke(result);
    }
    
    public void Reset()
    {
        playerScore = 0;
        OnChanged?.Invoke(playerScore);
    }
}
