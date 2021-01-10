namespace HW6_1
{
    public class QA
    {
        private string question;
        private string[] answer;
        private byte indexCorrectAnswer;

        public QA(string quest, byte ind, params string[] ans)
        { 
            question = quest;
            answer = ans;
            indexCorrectAnswer = ind;
        }

        public string Question
        {
            get => question;
            set => question = value;
        }

        public string[] Answer
        {
            get => answer;
            set => answer = value;
        }

        public byte IndexCorrectAnswer
        {
            get => indexCorrectAnswer;
            set => indexCorrectAnswer = value;
        }
    }
}