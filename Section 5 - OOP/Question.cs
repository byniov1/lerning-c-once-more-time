namespace Section_5___OOP;

public class Question
{
    public string  QuestionText { get; set; }

    public string[]  Anwsers { get; set; }
    
    public int  CorrectAnwserIndex { get; set; }

    public Question(string  questionText, string[] anwsers, int correctAnwserIndex)
    {
        QuestionText = questionText;
        Anwsers = anwsers;
        CorrectAnwserIndex = correctAnwserIndex;
    }

    public bool IsCorrectAnswer(int choice)
    {
        return CorrectAnwserIndex == choice;
    }
    
}