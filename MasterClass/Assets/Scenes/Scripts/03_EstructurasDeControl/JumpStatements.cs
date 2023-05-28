using UnityEngine;

public struct PlayerData
{
    public int score;
    public bool isAlive;
}

public class JumpStatements : MonoBehaviour
{
    public PlayerData[] playersData;

    private void CheckMaxScore()
    {
        for (int i = 0; i < playersData.Length; i++)
        {
            if (playersData[i].score >= 10)
            {
                //quizas se derive en un bug y se debera pensar de nuevo la logica a utilizar
                break;
            }
        }
    }

    private void CheckPlayersScore()
    {
        for (int i = 0; i < playersData.Length; i++)
        {
            if (!playersData[i].isAlive)
            {
                continue;
            }
        }
    }

    private void CheckPlayerScore(int index)
    {
        if (playersData[index].isAlive)
        {
            return;
        }
    }
}
