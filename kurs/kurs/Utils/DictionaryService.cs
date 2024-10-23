using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace kurs.Utils
{
    public static class DictionaryService
    {
        private static string path = @"../RUS.txt";
        public static string rus_str = "абвгдеёжзийклмнопрстуфхцчшщьыъэюя";
        
        // флаг для определения слов, содержащих НЕ кириллицу
        private static bool IsRussian(string str)
        {
            return !str.ToLower().Where(c => !rus_str.Contains(c.ToString())).Any();
        }

        // процедура для сортировки/записи/удаления из словаря и получения из него списка строк
        // без параметров - сортировка
        // есть первый параметр - добавление
        // есть второй параметр - удаление

        public static List<string> GetSortedDictionary(string addWord = null, string deleteWord = null, string startFrom = null)
        {
            // создаем пустой список для чтения слов из словаря
            var list = new List<string>();
            // создаем флаг для сравнения нового слова с уже имеющимися
            var isAddWordContains = false;
            // читаем все сиз файла
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    
                    // если есть добавляемое слово - сравниваем его со считываемым словом из словаря, и если оно уже есть, проставляем флаг
                    if (addWord == line)
                    {
                        isAddWordContains = true;
                    }
                    // если есть удаляемое слово, находим его не пишем в список
                    // + пишем только кириллицу
                    if (line != deleteWord && IsRussian(line))
                    {
                        list.Add(line);
                    }
                }
            }

            //// если добавлили слово кириллицей и его нет в словаре - добавляем в список новое слово
            //if (!string.IsNullOrEmpty(addWord) && !isAddWordContains && IsRussian(addWord))
            //{
            //    list.Add(addWord);
            //}

            //// сортируем список по алфавиту
            //list.Sort();

            //// перезаписываем словарь (пишем в него список)
            //using (StreamWriter writer = new StreamWriter(path, false))
            //{
            //    list.ForEach(l => writer.WriteLine(l));
            //}

            //// возвращаем с заданной подстроки, если она указана
            //return list.Where(l => string.IsNullOrEmpty(startFrom) || string.Compare(l, startFrom) >= 0).ToList();
        }
    }
}
