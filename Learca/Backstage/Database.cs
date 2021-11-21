using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using Learca.Properties;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Класс для работы с Файлом содержащим всю базу карточек
    /// </summary>
    static class Database
    {
        /// <summary>
        /// Путь к файлу с карточками
        /// </summary>
        private static readonly string deckSetPath;
        /// <summary>
        /// Путь к файлу с избранными карточками
        /// </summary>
        private static readonly string chosenDeckSetPath;

        /// <summary>
        /// Набор Колод
        /// </summary>
        public static DeckSet DeckSet { get; private set; }
        /// <summary>
        /// Набор Избранных Колод
        /// </summary>
        public static ChosenDeckSet ChosenDeckSet { get; private set; }

        /// <summary>
        /// Флаг для приветствия пользователя
        /// </summary>
        private static bool greeting;

        static Database()
        {
            deckSetPath = Settings.Default.Path_DeckSet;
            chosenDeckSetPath = Settings.Default.Path_ChosenDeckSet;
            DeckSet = new DeckSet();
            ChosenDeckSet = new ChosenDeckSet();
            greeting = true;

            InitDeckSet(deckSetPath, DeckSet);
            InitDeckSet(chosenDeckSetPath, ChosenDeckSet);
        }

        /// <summary>
        /// Инициализация Набора колод из файла Xml
        /// </summary>
        /// <param name="path">Путь  к файлу Xml</param>
        /// <param name="deckSet"></param>
        private static void InitDeckSet(string path, AbstractDeckSet deckSet)
        {
            using (var file = new FileStream(path, FileMode.OpenOrCreate))
            {
                var xmlDoc = new XmlDocument();

                try
                {
                    xmlDoc.Load(file);
                    deckSet.InitFromXmlNode(xmlDoc.DocumentElement);
                }
                catch
                {
                    if (greeting)
                    {
                        MessageBox.Show("Hello from LEARCA");
                        greeting = false;
                    }
                }
            }
        }

        /// <summary>
        /// Запись всех колод с картами в файлы Xml
        /// </summary>
        public static void WriteXml()
        {
            WriteXml_DeckSet(deckSetPath, DeckSet);
            WriteXml_DeckSet(chosenDeckSetPath, ChosenDeckSet);
        }

        /// <summary>
        ///  Запись набора колод по указанному пути в файл Xml
        /// </summary>
        /// <param name="path"></param>
        /// <param name="deckSet"></param>
        private static void WriteXml_DeckSet(string path, AbstractDeckSet deckSet)
        {
            using (var writer = new XmlTextWriter(path, Encoding.Default))
            {
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 4;
                writer.IndentChar = ' ';

                writer.WriteStartDocument();

                deckSet.WriteXml(writer);

                writer.WriteEndDocument();
            }
        }
    }
}
