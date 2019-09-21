using UnityEngine;
using UnityEngine.UI;
public class ScorePlayer : MonoBehaviour
{
    public Transform player;
    public Text score;

    void Update()
    {
        score.text = player.position.z.ToString("0");
    }
	
}
