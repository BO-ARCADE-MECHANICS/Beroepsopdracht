using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Text ScoreText;
    public int RubyCount;


    void Update()
    {
        ScoreText.text = RubyCount.ToString();
    }
}
