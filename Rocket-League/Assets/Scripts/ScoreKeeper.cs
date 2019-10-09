using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{    
    public int score = 0;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = score.ToString();
    }

    public void ScoreGoal(){
        score++;
        text.text = score.ToString();
    }
}
