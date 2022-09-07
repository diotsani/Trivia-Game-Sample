using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class GameplayLevel : MonoBehaviour
{
    private QuestionData questionData;
    [SerializeField] private QuestionScriptable questionScriptable;
    [SerializeField] private List<QuestionData> questionDataList;
    private int _amountAnswer = 4;

    [SerializeField] private TMP_Text questionText;
    [SerializeField] private string correctAnswer;
    [SerializeField] private Image hintImage;
    [SerializeField] private List<AnswerObject> answerObjectsList = new List<AnswerObject>();

    [SerializeField] private AnswerObject answerPrefab;
    [SerializeField] private Transform answerParent;

    private void Awake()
    {
        questionDataList = questionScriptable.questionData;

        questionData = questionDataList[0];
    }

    private void Start()
    {
        InitAnswer();
    }

    void InitAnswer()
    {
        questionText.text = questionData.question;
        correctAnswer = questionData.correctAnswer;
        hintImage.sprite = questionData.hintImage;

        List<string> answerName = questionData.answerList;
        for (int i = 0; i < _amountAnswer; i++)
        {
            AnswerObject answerObj = Instantiate(answerPrefab, answerParent);
            answerObjectsList.Add(answerObj);

            answerObj.answerName.text = answerName[i];
            answerObj.name = answerName[i];
        }
    }
}
