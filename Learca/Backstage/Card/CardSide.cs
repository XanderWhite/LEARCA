using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Learca
{
    public class CardSide : IEnumerable<string>
    {
        private string imagePath;
        private readonly List<string> values;
        public CardSide OtherSide
        {
            get
            {
                if (ParentCard == null)
                    return null;

                if (Side == Side.Left)
                    return ParentCard.RightSide;

                return ParentCard.LeftSide;
            }
        }
        public int ValueCount => values.Count;
        public Card ParentCard { get; private set; }
        public char Separator { get; set; }
        public string ImagePath
        {
            get { return imagePath; }
            set
            {
                if (!string.IsNullOrWhiteSpace(imagePath))
                   File.Delete(ImagePath);

                imagePath = value;
            }
        }

        /// <summary>
        /// Имеет ли сторона изображение
        /// </summary>
        public bool HasImage => ImageHandler.GetImage(ImagePath) != null;

        /// <summary>
        /// Перемешивать значения во время изучения
        /// </summary>
        public bool MixValues { get; set; }
        public Side Side { get; private set; }

        public bool IsEmpty
        {
            get
            {
                return values.Count == 0 && string.IsNullOrWhiteSpace(ImagePath);
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="parent">Карта</param>
        /// <param name="side">Сторона карты</param>
        /// <param name="separator">Разделитель значений при выводе значений, как списка</param>
        public CardSide(Card parent, Side side, char separator = ';')
        {
            ParentCard = parent ?? throw new ArgumentNullException("Card parent не может быть null");
            Side = side;
            Separator = separator;
            values = new List<string>();
        }

        /// <summary>
        /// Добавление значения
        /// </summary>
        /// <param name="value"></param>
        public void Add(string value)
        {
            if (!String.IsNullOrWhiteSpace(value))
                values.Add(value);
        }

        /// <summary>
        /// Добавление нескольких значений
        /// </summary>
        /// <param name="values"></param>
        void Add(IEnumerable<string> values)
        {
            foreach (string value in values)
            {
                Add(value);
            }
        }

        /// <summary>
        /// Замена значений на новые
        /// </summary>
        /// <param name="values"></param>
        public void ReplaceValues(IEnumerable<string> values)
        {
            if (values == null)
                throw new ArgumentNullException("IEnumerable<string> values не может быть null");

            this.values.Clear();
            Add(values);
        }

        /// <summary>
        /// Удаление значения по индексу
        /// </summary>
        /// <param name="index"></param>
        public void RemoveValueAt(int index)
        {
            if (index >= 0 && index < values.Count)
                values.RemoveAt(index);
            else
                throw new IndexOutOfRangeException("index вне диапазона values");
        }

        /// <summary>
        /// Очистить сторону в том числе и удаление файла изображения связанного с картой
        /// </summary>
        public void Clear()
        {
            values.Clear();
            ImagePath = string.Empty;
            MixValues = false;
        }

        /// <summary>
        /// Сравнение сохраненных значений с значениями пользователя
        /// </summary>
        /// <param name="values">Значения пользователя</param>
        /// <returns></returns>
        public bool Compare(IEnumerable<string> values)
        {
            var list = new List<string>();

            foreach (string val in values)
            {
                if (!string.IsNullOrWhiteSpace(val))
                    list.Add(val.Trim());
            }

            if (list.Count != this.values.Count)
                return false;

            foreach (var value in this.values)
            {
                if (!list.Remove(value.Trim()))
                    return false;
            }

            return list.Count == 0;
        }

        /// <summary>
        /// Получить перемешанный массив значений
        /// </summary>
        /// <returns></returns>
        public string[] GetShuffledValues()
        {
            var shuffledValues = values.ToArray();

            Random rand = new Random();

            for (int i = 0; i < shuffledValues.Length; i++)
            {
                int randIndex = rand.Next(i, shuffledValues.Length);

                Swap(i, randIndex, shuffledValues);
            }

            return shuffledValues;
        }

        /// <summary>
        /// Получить массив значений
        /// </summary>
        /// <returns></returns>
        public string[] GetValues()
        {
            return values.ToArray();
        }

        private void Swap(int leftIndex, int rightIndex, string[] items)
        {
            if (leftIndex < 0 || leftIndex >= items.Length || rightIndex < 0 || rightIndex >= items.Length)
                throw new IndexOutOfRangeException("index вне диапазона items");

            if (leftIndex == rightIndex) return;

            string temp = items[leftIndex];
            items[leftIndex] = items[rightIndex];
            items[rightIndex] = temp;
        }

        /// <summary>
        /// Поиск частичного совпадения в списке значений
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public bool PartialMatch(string search)
        {
            if (string.IsNullOrWhiteSpace(search))
                return true;

            search = search.Trim().ToLower();

            foreach (var value in values)
            {
                if (value.ToLower().Contains(search))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Сравнить ответы пользователя с значениями на стороне карточки
        /// </summary>
        /// <param name="userAnswer"></param>
        /// <returns></returns>
        public bool CompareValuesWith(string[] userAnswer)
        {
            if (userAnswer == null)
                throw new ArgumentNullException("List<string> userAnswer не может быть null");

            foreach (var value in values)
            {
                for (int i = 0; i < userAnswer.Length; i++)
                {
                    if (userAnswer[i].Trim().ToLower() == value.Trim().ToLower())
                        break;

                    if (i == userAnswer.Length - 1)
                        return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Возвращает значения(values) в строку 
        /// </summary>
        /// <returns></returns>
        public string GetValuesToString()
        {
            if (values.Count == 0)
                return string.Empty;

            StringBuilder builder = new StringBuilder();

            foreach (string value in values)
            {
                builder.Append($"{value} {Separator} ");
            }

            builder.Remove(builder.Length - 3, 3);

            return builder.ToString();
        }

        /// <summary>
        /// Возвращает значения(values) в столбик 
        /// </summary>
        /// <returns></returns>
        public string GetValuesInColumn()
        {
            var t = string.Empty;

            for (int i = 0; i < values.Count; i++)
            {
                t += values[i];

                if (i != values.Count - 1)
                {
                    t += Environment.NewLine;
                    t += new string('-', 20);
                    t += Environment.NewLine;
                }
            }

            return t;
        }

        /// <summary>
        /// Инициализация Стороны Карты из Xml-документа
        /// </summary>
        /// <param name="node">Узел в Xml-документе</param>
        public void InitFromXmlNode(XmlNode node)
        {
            if (node == null)
                throw new ArgumentNullException("XmlNode node не может быть null");

            if (node.Name != "Left" && node.Name != "Right")
                return;

            ImagePath = node.Attributes["ImagePath"].Value;
            MixValues = bool.Parse(node.Attributes["MixValues"].Value);

            foreach (XmlNode childNode in node.ChildNodes)
            {
                if (childNode.Name == "Values")
                {
                    foreach (XmlNode node_value in childNode.ChildNodes)
                    {
                        if (node_value.Name == "Value")
                            Add(node_value.InnerText);
                    }
                }
            }
        }

        /// <summary>
        /// Запись стороны в Xml-документ
        /// </summary>
        /// <param name="writer"></param>
        public void WriteXml(XmlTextWriter writer)
        {
            if (writer == null)
                throw new ArgumentNullException("XmlTextWriter writer не может быть null");

            writer.WriteStartElement(Side.ToString());
            {
                writer.WriteStartAttribute("ImagePath");
                writer.WriteString(ImagePath);
                writer.WriteEndAttribute();

                writer.WriteStartAttribute("MixValues");
                writer.WriteString(MixValues.ToString());
                writer.WriteEndAttribute();

                writer.WriteStartElement("Values");

                foreach (string value in values)
                {
                    writer.WriteStartElement("Value");
                    writer.WriteString(value);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        public IEnumerator<string> GetEnumerator()
        {
            return values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}