using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable, CreateAssetMenu (fileName = "QuestionScriptable", menuName = "DataScriptable")]
public class QuestionScriptable : ScriptableObject
{
    public List<QuestionData> questionData;
}

