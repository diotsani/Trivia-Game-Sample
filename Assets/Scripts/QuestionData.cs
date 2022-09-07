using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class QuestionData
{
    public string question;
    public Sprite hintImage;
    public List<string> answerList;//= new List<string>{"Merah","Biru","Hijau","Kuning"};
    public string correctAnswer;
}
