using System;
using System.Collections.Generic;

namespace MainEnDeCryption
{
    public class NSTFR
    {
        /// <summary>
        /// Шифрование текста комбинация 1
        /// </summary>
        /// <param name="N0"> исходный текст </param>
        /// <returns></returns>
        public static string EnCombo1(string N0)
        {
            List<int> S1(string _N0)
            {
                List<int> code = new List<int>();

                foreach (char i in _N0)
                {
                    code.Add(NT117.indexSymNT117(i));
                }

                return code;
            }

            List<string> T1(List<int> _S1)
            {
                List<string> S1T1 = new List<string>();

                foreach (int i in _S1)
                {
                    S1T1.Add(Trinary.To3(i));
                }

                return S1T1;
            }

            List<string> F1(List<string> _T1)
            {
                List<string> _R0 = new List<string>();

                char c = '0';
                string b1 = "|";
                string b2;

                char r = 'k';
                int z = 1;

                foreach (string i in _T1)
                {
                    if (z >= 10)
                    {
                        z++;
                        if (z <= 10) z = 1;
                    }

                    foreach (char j in i)
                    {
                        if (c == j)
                        {
                            z++;

                            r = (char)new Random().Next('a', 'z' + z);

                            b1 = b1.Replace(b1[0], r);
                            break;
                        }
                        else
                        {
                            b1 = "|";
                        }

                    }

                    b2 = NT117.symIndex_NT177(Trinary.Back3(i)).ToString();

                    if (b1 != "|")
                    {
                        _R0.Add(b2 + b1);
                    }
                    else
                    {
                        _R0.Add(b2);
                    }
                }

                return _R0;
            }

            string R0(List<string> _F1)
            {
                string b = "";
                foreach (string i in _F1)
                {
                    b += i;
                }
                return b;
            }

            return R0(F1(T1(S1(N0))));
        }

        /// <summary>
        /// Дешифрование текста комбинация 1
        /// </summary>
        /// <param name="R0"> исходный текст </param>
        /// <returns></returns>
        public static string DeCombo1(string R0)
        {
            List<int> S1(string _N0)
            {
                List<int> code = new List<int>();

                foreach (char i in _N0)
                {
                    code.Add(NT117.indexSym_NT117(i));
                }

                return code;
            }

            List<string> T1(List<int> _S1)
            {
                List<string> S1T1 = new List<string>();

                foreach (int i in _S1)
                {
                    S1T1.Add(Trinary.To3(i));
                }

                return S1T1;
            }

            List<string> F1(List<string> _T1)
            {
                List<string> _N0 = new List<string>();

                int i_ = 0;
                bool t = false;

                for (int i = 0; i < _T1.Count;)
                {
                    if (_T1.Count > i)
                    {
                        for (int j = 0; _T1[i].Length > j; j++)
                        {
                            if (_T1[i][j] == '0')
                            {
                                t = true;
                                break;
                            }
                            else t = false;
                        }

                        if (t == true)
                        {
                            _N0.Add(_T1[i]);
                            i += 2;
                        }
                        else
                        {
                            _N0.Add(_T1[i]);
                            i++;
                        }
                    }

                    i_++;
                }

                return _N0;
            }

            string N0(List<string> _F1)
            {
                string n0 = "";

                foreach (string i in _F1)
                {
                    n0 += NT117.symIndexNT177(Trinary.Back3(i)).ToString();
                }

                return n0;
            }

            return N0(F1(T1(S1(R0))));
        }

        #region Дополнение 
        /// <summary>
        /// Моя библиотека символов и методов для шифрования и дешифрования текста
        /// </summary>
        class NT117
        {
            private readonly static string AlfEN_simple = "IaAbBвВdDefFgGhHijJkKlLЕmMnNoOpPqQrRsStTuUwWxXyYzZ";
            private readonly static string AlfRU_simple = "ЯаАбБгГдДcCеёЁжЖзЗиИйЙкКлЛмМнНоОпПрРсСтТEуУфФхХцЦчЧшШщЩъЪыЫьЬэЭюЮя";
            private readonly static string Numb_simple = "0123456789";
            private readonly static string Symb_simple = "~!@#$%^& ()_+`";

            #region Часть 1 работа с масивом tn117
            /// <summary>
            /// Массив символов tn117
            /// </summary>
            public readonly static char[] tn117 = ("," + "." + "*" + AlfRU_simple + Numb_simple + AlfEN_simple + Symb_simple).ToCharArray();
            /// <summary>
            /// Функция нахождения индекса по задаоному символу из массива tn117
            /// </summary>
            /// <param name="c"> Заданный символ </param>
            /// <returns></returns>
            public static int indexSymNT117(char c)
            {
                int j = 0;

                for (int i = 0; i < tn117.Length; i++)
                {
                    if (c == tn117[i])
                    {

                        break;
                    }
                    else
                    {
                        j++;
                    }
                }

                return j;
            }

            /// <summary>
            ///  Функция нахождения символ по задаоному индексу из массива tn117
            /// </summary>
            /// <param name="j"> Заданный индекс </param>
            /// <returns></returns>
            public static char symIndexNT177(int j)
            {
                for (int i = 0; i < tn117.Length; i++)
                {
                    if (j == i)
                    {
                        return tn117[i];
                    }
                }

                return '|';
            }
            /// <summary>
            ///  Функция нахождения символ по задаоному индексу из массива tn117
            /// </summary>
            /// <param name="j"> Заданный индекс </param>
            /// <returns></returns>
            public static char symIndexNT177(string j)
            {
                int x = Convert.ToInt32(j);

                for (int i = 0; i < tn117.Length; i++)
                {
                    if (x == i)
                    {
                        return tn117[i];
                    }
                }

                return '|';
            }
            #endregion

            #region Часть 2 работа с масивом _tn117
            /// <summary>
            /// Массив символов _tn117
            /// </summary>
            public readonly static char[] _tn117 = ("." + AlfEN_simple + Symb_simple + "*" + "," + Numb_simple + AlfRU_simple).ToCharArray();
            /// <summary>
            /// Функция нахождения индекса по задаоному символу из массива _tn117
            /// </summary>
            /// <param name="c"> Заданный символ </param>
            /// <returns></returns>
            public static int indexSym_NT117(char c)
            {
                int j = 0;

                for (int i = 0; i < _tn117.Length; i++)
                {
                    if (c == _tn117[i])
                    {

                        break;
                    }
                    else
                    {
                        j++;
                    }
                }

                return j;
            }
            /// <summary>
            ///  Функция нахождения символ по задаоному индексу из массива _tn117
            /// </summary>
            /// <param name="j"> Заданный индекс </param>
            /// <returns></returns>
            public static char symIndex_NT177(int j)
            {
                for (int i = 0; i < _tn117.Length; i++)
                {
                    if (j == i)
                    {
                        return _tn117[i];
                    }
                }

                return '|';
            }
            /// <summary>
            ///  Функция нахождения символ по задаоному индексу из массива _tn117
            /// </summary>
            /// <param name="j"> Заданный индекс </param>
            /// <returns></returns>
            public static char symIndex_NT177(string j)
            {
                int x = Convert.ToInt32(j);

                for (int i = 0; i < _tn117.Length; i++)
                {
                    if (x == i)
                    {
                        return _tn117[i];
                    }
                }

                return '|';
            }
            #endregion
        }

        /// <summary>
        /// Моя библиотека для работы с троичной логикой
        /// </summary>
        class Trinary
        {
            /// <summary>
            /// Перевод целочисленных чисел из 10 в 3 систему исчисления
            /// </summary>
            /// <param name="i"> Задаётся целочисленным десятичным числом </param>
            /// <returns></returns>
            static public string To3(int i)
            {
                string buffer = "";

                while (i > 0)
                {
                    buffer = i % 3 + buffer;
                    i /= 3;
                }

                return buffer;
            }

            /// <summary>
            ///  Перевод целочисленных чисел из 3 в 10 систему исчисления
            /// </summary>
            /// <param name="i"> Задаётся троичныйм числом </param>
            /// <returns></returns>
            static public string Back3(string i)
            {
                int _i = 0;
                int size = i.Length - 1;

                for (int j = 0; j <= i.Length - 1; j++)
                {
                    int b = Convert.ToInt32(
                    i[j].ToString());

                    int a = Convert.ToInt32(
                    Math.Pow(3, size));

                    if (size != 0)
                    {
                        size--;
                        _i += b * a;
                    }
                    else
                    {
                        switch (b)
                        {
                            case 1:
                                _i += 1;
                                break;

                            case 2:
                                _i += 2;
                                break;
                        }
                    }
                }

                return _i.ToString();
            }
        }
        #endregion
    }
}