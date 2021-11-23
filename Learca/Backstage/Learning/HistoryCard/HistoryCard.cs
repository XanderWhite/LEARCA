using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learca
{
    /// <summary>
    /// Абстрактная Карточка находящаяся в истории.
    /// Карточка которая была просмотрена пользователем.
    /// </summary>
    public abstract class HistoryCard
    {
        public AbstractLearningCard LearningCard { get; private set; }
        public Color Color
        {
            get
            {
                switch (ViewResult)
                {
                    case ViewResult.Repeat:
                        return Color.LightPink;
                    case ViewResult.Skipped:
                        return Color.LightYellow;
                    case ViewResult.Learned:
                        return Color.LightGreen;
                    default:
                        return Color.LightGray;
                }
            }
        }
        public ViewResult ViewResult { get; set; }

        public HistoryCard(AbstractLearningCard learningCard, ViewResult viewResult)
        {
            this.LearningCard = learningCard ?? throw new ArgumentNullException("AbstractLearningCard learningCard не может быть null");

            ViewResult = viewResult;
        }

        /// <summary>
        /// Повторить Карточку вернув в список learningCards
        /// </summary>
        public virtual void RepeatCurrentCard()
        {
            LearningCard.RepeatRemovedCard();
        }

        /// <summary>
        /// Получить Создателя Кнопок и Панелей с изображением сторон карточек для LearningPanel
        /// </summary>
        /// <param name="panel"></param>
        /// <returns></returns>
        public abstract LearningPanelControlsCreator GetControlsCreatorFor(MainForm mainForm, LearningPanel panel);
    }
}
