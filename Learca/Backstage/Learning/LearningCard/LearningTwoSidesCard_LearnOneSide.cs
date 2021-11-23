using System.Collections.Generic;

namespace Learca
{
    /// <summary>
    /// Карточка в процессе изучения заполненная с двух сторон.
    /// Изучение только одной стороны
    /// </summary>
    class LearningTwoSidesCard_LearnOneSide : LearningTwoSidesCard
    {
        public LearningTwoSidesCard_LearnOneSide(Card card, bool typeAnswer, Teacher teacher, bool leftSideIsQuestion)
     : base(card, typeAnswer, teacher, leftSideIsQuestion)
        {

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
                teacher.RemoveCurrentCard();

                teacher.AddToHistory(new HistoryTwoSidesCard(this, ViewResult.Learned, leftIsQuestion));
            }
            else
            {
                teacher.RepeatNextPass(this);
            }

            return result;
        }

        /// <summary>
        /// Создание копии карточки
        /// </summary>
        /// <returns></returns>
        public override AbstractLearningCard Clone()
        {
            return new LearningTwoSidesCard_LearnOneSide(Card, TypeAnswer, teacher, LeftSideIsQuestion);
        }

        /// <summary>
        ///  Создать Создателя Кнопок и Панелей с изображением сторон карточек для LearningPanel   
        /// </summary>
        /// <param name="panel"></param>
        /// <returns></returns>
        public override LearningPanelControlsCreator CreateControlsCreatorFor(MainForm mainForm, LearningPanel panel)
        {
            if (TypeAnswer && AnswerSide.ValueCount > 0)
                return new LearningControlsCreatorForTwoSidesCard_TypeAnswer( mainForm, panel, this);
            
            if (ShowAnswer)
                return new LearningControlsCreatorForTwoSidesCard_OralAnswer_LearnOneSide(mainForm, panel, this);

            return new LearningControlsCreatorForTwoSidesCard_OralQuestion(mainForm, panel, this);
        }

        /// <summary>
        /// Команда на удаление карточки
        /// </summary>
        public override void Remove()
        {
            teacher.RemoveCurrentCard();

            teacher.AddToHistory(new HistoryTwoSidesCard(this, ViewResult.Learned, LeftSideIsQuestion));
        }

        /// <summary>
        /// Команда на повторение карточки
        /// </summary>
        public override void Repeat()
        {
            if (IsLastCard)
            {
                teacher.AddToCardsForChosenDeck(this);
            }
            else
            {
                teacher.Repeat(Clone());
                teacher.RemoveCurrentCard();

                teacher.AddToHistory(new HistoryTwoSidesCard(this, ViewResult.Repeat, LeftSideIsQuestion));
            }
        }
    }
}