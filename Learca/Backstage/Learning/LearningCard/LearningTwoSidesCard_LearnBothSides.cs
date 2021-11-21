using System.Collections.Generic;

namespace Learca
{
    /// <summary>
    /// Карточка в процессе изучения заполненная с двух сторон.
    /// Изучение обоих сторон
    /// </summary>
    class LearningTwoSidesCard_LearnBothSides : LearningTwoSidesCard_LearnOneSide
    {
        /// <summary>
        /// Изучать ли обе стороны. По умолчани true, но по желанию можно изменить
        /// </summary>
        private readonly bool learnBothSides;

        public LearningTwoSidesCard_LearnBothSides(Card card, bool typeAnswer, Teacher teacher, bool leftSideIsQuestion, bool learnBothSides = true)
            : base(card, typeAnswer, teacher, leftSideIsQuestion)
        {
            this.learnBothSides = learnBothSides;
            IsFirstPass = learnBothSides;
        }

        /// <summary>
        /// Команда на удаление карточки.
        /// Если пройдена только одна сторона, тогда переворачиваем карточку и проходим вторую сторону. Иначе, удаляем карточку
        /// </summary>
        public override void Remove()
        {
            bool leftIsQuestion = LeftSideIsQuestion;

            if (IsFirstPass)
            {
                TurnCard();
                teacher.SkipCurrentCard();
                ShowAnswer = false;
            }
            else
            {
                teacher.RemoveCurrentCard();
            }

            teacher.AddToHistory(new HistoryTwoSidesCard(this, ViewResult.Learned, leftIsQuestion));
        }

        /// <summary>
        /// Перевернуть карточку. Поменять местами вопрос и ответ
        /// </summary>
        private void TurnCard()
        {
            IsFirstPass = !IsFirstPass;
            LeftSideIsQuestion = !LeftSideIsQuestion;
        }

        /// <summary>
        /// Команда на проверку ответов пользователя
        /// </summary>
        /// <param name="userAnswer"></param>
        /// <returns></returns>
        public override bool ExamineUser(string[] userAnswer)
        {
            bool leftIsQuestion = LeftSideIsQuestion;

            bool result = AnswerSide.CompareValuesWith(userAnswer);

            if (result)
            {
                if (IsFirstPass)
                {
                    TurnCard();
                    teacher.SkipCurrentCard();
                }
                else
                {
                    teacher.RemoveCurrentCard();
                }

                teacher.AddToHistory(new HistoryTwoSidesCard(this, ViewResult.Learned, leftIsQuestion));
            }
            else
            {
                teacher.RepeatNextPass(this);
            }

            return result;
        }

        /// <summary>
        /// Команда на повторение карточки
        /// </summary>
        public override void Repeat()
        {
            if (IsFirstPass)
            {
                teacher.AddToHistory(new HistoryTwoSidesCard(this, ViewResult.Repeat, LeftSideIsQuestion));

                teacher.RepeatNextPass(Clone());
                TurnCard();
                teacher.SkipCurrentCard();
                ShowAnswer = false;
            }

            else if (IsLastCard)
            {
                teacher.AddToCardsForChosenDeck(this);
            }
            else
            {
                teacher.AddToHistory(new HistoryTwoSidesCard(this, ViewResult.Repeat, LeftSideIsQuestion));

                teacher.Repeat(this.Clone());
                teacher.RemoveCurrentCard();
            }
        }

        /// <summary>
        /// Создание копии карточки
        /// </summary>
        /// <returns></returns>
        public override AbstractLearningCard Clone()
        {
            bool leftIsQuestion = (learnBothSides && !IsFirstPass) ? !LeftSideIsQuestion : LeftSideIsQuestion;

            return new LearningTwoSidesCard_LearnBothSides(Card, TypeAnswer, teacher, leftIsQuestion, learnBothSides);
        }

        /// <summary>
        ///  Получить Создателя Кнопок и Панелей с изображением сторон карточек для LearningPanel   
        /// </summary>
        /// <param name="panel"></param>
        /// <returns></returns>
        public override LearningPanelControlsCreator GetControlsCreatorFor(LearningPanel panel)
        {
            if (TypeAnswer && AnswerSide.ValueCount > 0)
            {
                return new LearningControlsCreatorForTwoSidesCard_TypeAnswer(panel, this);
            }

            if (ShowAnswer)
            {
                return new LearningControlsCreatorForTwoSidesCard_OralAnswer_LearnBothSides(panel, this);
            }

            return new LearningControlsCreatorForTwoSidesCard_OralQuestion(panel, this);
        }
    }
}