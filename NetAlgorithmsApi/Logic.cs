namespace NetAlgorithmsApi;
public class Logic
{
    public bool IsMatch(ExpressionMatchRequest expressionMatchRequest)
    {
        string sentence = expressionMatchRequest.Sentence;
        string pattern = expressionMatchRequest.Pattern;

        return sentence == pattern;
    }
}
