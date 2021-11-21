using System.Collections.Generic;
using System;

namespace Learca
{
    /// <summary>
    /// Абстрактная карточка в процессе изучения заполненная с двух сторон
    /// </summary>
    abstract class LearningTwoSidesCard : AbstractLearningCard
    {
        /// <summary>
        /// Является ли левая сторона вопросом
        /// </summary>
        public bool LeftSideIsQuestion { get; set; }

        /// <summary>
        /// Показать ответ
        /// </summary>
        public bool ShowAnswer { get; set; }

        /// <summary>
        /// Печатать ли ответ
        /// </summary>
        public bool TypeAnswer { get; private set; }

        /// <summary>
        /// Первый ли проход по карточке. Важно, когда у карточки изучаются обе стороны
        /// </summary>
        public bool IsFirstPass { get; protected set; }

        public CardSide QuestionSide
        {
            get { return LeftSideIsQuestion ? Card.LeftSide : Card.RightSide; }
        }
        public CardSide AnswerSide
        {
            get { return LeftSideIsQuestion ? Card.RightSide : Card.LeftSide; }
        }

        public LearningTwoSidesCard(Card card, bool typeAnswer, Teacher teacher, bool leftSideIsQuestion)
            : base(card, teacher)
        {
            LeftSideIsQuestion = leftSideIsQuestion;
            TypeAnswer = typeAnswer;
            ShowAnswer = false;
            IsFirstPass = true;
        }

        /// <summary>
        /// Команда на проверку ответов пользователя
        /// </summary>
        /// <param name="userAnswer"></param>
        /// <returns></returns>
        public abstract bool ExamineUser(string[] userAnswer);

        /// <summary>
        /// Команда пропустить карточку
        /// </summary>
        public override void Skip()
        {
            teacher.AddToHistory(new HistoryTwoSidesCard(this, ViewResult.Skipped, LeftSideIsQuestion));

            teacher.SkipCurrentCard();
        }
    }
}