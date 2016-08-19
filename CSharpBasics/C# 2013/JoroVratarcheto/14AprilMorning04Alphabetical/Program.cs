using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//22:15 - 22:26 | 19:10 -  den i polovin madafaka!

namespace _14AprilMorning04Alphabetical
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());


            List<char[]> charArrList = new List<char[]>();
            string currentLine = string.Empty;
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++, k++)
                {
                    if (k == word.Length)
                    {
                        k = 0;
                    }
                    currentLine += word[k];
                }
                charArrList.Add(currentLine.ToArray());
                currentLine = string.Empty;
            }

////RIGHT
            string rightWord = string.Empty;
            string alphaWordCur = string.Empty;
            string alphaWordPrev = string.Empty;
            char[] charArrCurLine = new char[n];

            for (int i = 0; i < n; i++)
            {
                charArrCurLine = charArrList[i];
                for (int j = 0; j < n; j++)
                {
                    if (alphaWordCur == string.Empty)
                    {
                        alphaWordCur += Convert.ToString(charArrCurLine[j]);
                    }
                    else if (charArrCurLine[j - 1] < charArrCurLine[j] && j != n - 1)
                    {
                        alphaWordCur += Convert.ToString(charArrCurLine[j]);
                    }
                    else if (charArrCurLine[j - 1] < charArrCurLine[j])
                    {
                        alphaWordCur += Convert.ToString(charArrCurLine[j]);
                        if (alphaWordCur.Length > alphaWordPrev.Length)
                        {
                            alphaWordPrev = alphaWordCur;
                        }
                        else if (alphaWordCur.Length == alphaWordPrev.Length)
                        {
                            if (string.Compare(alphaWordCur, alphaWordPrev) < 0)
                            {
                                alphaWordPrev = alphaWordCur;
                            }
                        }
                        alphaWordCur = Convert.ToString(charArrCurLine[j]);
                    }
                    else
                    {
                        if (alphaWordCur.Length > alphaWordPrev.Length)
                        {
                            alphaWordPrev = alphaWordCur;
                        }
                        alphaWordCur = Convert.ToString(charArrCurLine[j]);
                    }
                }
                if (alphaWordPrev.Length > rightWord.Length)
                {
                    rightWord = alphaWordPrev;
                }
                else if (alphaWordPrev.Length == rightWord.Length)
                {
                    if ((string.Compare(alphaWordPrev, rightWord) < 0))
                    {
                        rightWord = alphaWordPrev;
                    }
                }
                alphaWordCur = string.Empty;
            }

////LEFT
            string leftWord = string.Empty;
            alphaWordCur = string.Empty;
            alphaWordPrev = string.Empty;
            for (int i = 0; i < n; i++)
            {
                charArrCurLine = charArrList[i];
                Array.Reverse(charArrCurLine);
                for (int j = 0; j < n; j++)
                {
                    if (alphaWordCur == string.Empty)
                    {
                        alphaWordCur += Convert.ToString(charArrCurLine[j]);
                    }
                    else if (charArrCurLine[j - 1] < charArrCurLine[j] && j != n - 1)
                    {
                        alphaWordCur += Convert.ToString(charArrCurLine[j]);
                    }
                    else if (charArrCurLine[j - 1] < charArrCurLine[j])
                    {
                        alphaWordCur += Convert.ToString(charArrCurLine[j]);
                        if (alphaWordCur.Length > alphaWordPrev.Length)
                        {
                            alphaWordPrev = alphaWordCur;
                        }
                        else if (alphaWordCur.Length == alphaWordPrev.Length)
                        {
                            if (string.Compare(alphaWordCur, alphaWordPrev) < 0)
                            {
                                alphaWordPrev = alphaWordCur;
                            }
                        }
                        alphaWordCur = Convert.ToString(charArrCurLine[j]);
                    }
                    else
                    {
                        if (alphaWordCur.Length > alphaWordPrev.Length)
                        {
                            alphaWordPrev = alphaWordCur;
                        }
                        alphaWordCur = Convert.ToString(charArrCurLine[j]);
                    }
                }
                if (alphaWordPrev.Length > leftWord.Length)
                {
                    leftWord = alphaWordPrev;
                }
                else if (alphaWordPrev.Length == leftWord.Length)
                {
                    if ((string.Compare(alphaWordPrev, leftWord) < 0))
                    {
                        leftWord = alphaWordPrev;
                    }
                }
                alphaWordCur = string.Empty;
            }

////DOWN
            string verticalLine = string.Empty;
            List<char[]> VerticalcharArrList = new List<char[]>();
            char[] downVerticalCharArr = new char[n];
            string downWord = string.Empty;
            alphaWordCur = string.Empty;
            alphaWordPrev = string.Empty;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    downVerticalCharArr[j] = charArrList[j][i];
                    if (alphaWordCur == string.Empty)
                    {
                        alphaWordCur += Convert.ToString(downVerticalCharArr[j]);
                    }
                    else if (downVerticalCharArr[j - 1] < downVerticalCharArr[j] && j != n - 1)
                    {
                        alphaWordCur += Convert.ToString(downVerticalCharArr[j]);
                    }
                    else if (downVerticalCharArr[j - 1] < downVerticalCharArr[j])
                    {
                        alphaWordCur += Convert.ToString(downVerticalCharArr[j]);
                        if (alphaWordCur.Length > alphaWordPrev.Length)
                        {
                            alphaWordPrev = alphaWordCur;
                        }
                        else if (alphaWordCur.Length == alphaWordPrev.Length)
                        {
                            if (string.Compare(alphaWordCur, alphaWordPrev) < 0)
                            {
                                alphaWordPrev = alphaWordCur;
                            }
                        }
                        alphaWordCur = Convert.ToString(downVerticalCharArr[j]);
                    }
                    else
                    {
                        if (alphaWordCur.Length > alphaWordPrev.Length)
                        {
                            alphaWordPrev = alphaWordCur;
                        }
                        alphaWordCur = Convert.ToString(downVerticalCharArr[j]);
                    }
                    verticalLine += downVerticalCharArr[j];
                }
                if (alphaWordPrev.Length > downWord.Length)
                {
                    downWord = alphaWordPrev;
                }
                else if (alphaWordPrev.Length == downWord.Length)
                {
                    if ((string.Compare(alphaWordPrev, downWord) < 0))
                    {
                        downWord = alphaWordPrev;
                    }
                }
                alphaWordCur = string.Empty;
                VerticalcharArrList.Add(verticalLine.ToArray());
                verticalLine = string.Empty;
            }

////UP
            string upWord = string.Empty;
            alphaWordCur = string.Empty;
            alphaWordPrev = string.Empty;
            char[] upVerticalCharArr = new char[n];
            for (int i = 0; i < n; i++)
            {
                upVerticalCharArr = VerticalcharArrList[i];
                Array.Reverse(upVerticalCharArr);
                for (int j = 0; j < n; j++)
                {
                    if (alphaWordCur == string.Empty)
                    {
                        alphaWordCur += Convert.ToString(upVerticalCharArr[j]);
                    }
                    else if (upVerticalCharArr[j - 1] < upVerticalCharArr[j] && j != n - 1)
                    {
                        alphaWordCur += Convert.ToString(upVerticalCharArr[j]);
                    }
                    else if (upVerticalCharArr[j - 1] < upVerticalCharArr[j])
                    {
                        alphaWordCur += Convert.ToString(upVerticalCharArr[j]);
                        if (alphaWordCur.Length > alphaWordPrev.Length)
                        {
                            alphaWordPrev = alphaWordCur;
                        }
                        else if (alphaWordCur.Length == alphaWordPrev.Length)
                        {
                            if (string.Compare(alphaWordCur, alphaWordPrev) < 0)
                            {
                                alphaWordPrev = alphaWordCur;
                            }
                        }
                        alphaWordCur = Convert.ToString(upVerticalCharArr[j]);
                    }
                    else
                    {
                        if (alphaWordCur.Length > alphaWordPrev.Length)
                        {
                            alphaWordPrev = alphaWordCur;
                        }
                        alphaWordCur = Convert.ToString(upVerticalCharArr[j]);
                    }
                    verticalLine += upVerticalCharArr[j];
                }
                if (alphaWordPrev.Length > upWord.Length)
                {
                    upWord = alphaWordPrev;
                }
                else if (alphaWordPrev.Length == upWord.Length)
                {
                    if ((string.Compare(alphaWordPrev, upWord) < 0))
                    {
                        upWord = alphaWordPrev;
                    }
                }
                alphaWordCur = string.Empty;
                verticalLine = string.Empty;
            }

            string leftOrRight = string.Empty;
            if (rightWord.Length == leftWord.Length)
            {
                if (string.Compare(rightWord, leftWord) < 0)
                {
                    leftOrRight = rightWord;
                }
                else
                {
                    leftOrRight = leftWord;
                }
            }
            else
            {
                if (rightWord.Length > leftWord.Length)
                {
                    leftOrRight = rightWord;
                }
                else
                {
                    leftOrRight = leftWord;
                }
            }

            string upOrDown = string.Empty;
            if (downWord.Length == upWord.Length)
            {
                if (string.Compare(downWord, upWord) < 0)
                {
                    upOrDown = downWord;
                }
                else
                {
                    upOrDown = upWord;
                }
            }
            else
            {
                if (downWord.Length > upWord.Length)
                {
                    upOrDown = downWord;
                }
                else
                {
                    upOrDown = upWord;
                }
            }


            string output = string.Empty;

            if (leftOrRight.Length == upOrDown.Length)
            {
                if (string.Compare(leftOrRight, upOrDown) < 0)
                {
                    output = leftOrRight;
                }
                else
                {
                    output = upOrDown;
                }

            }
            else
            {
                if (leftOrRight.Length > upOrDown.Length)
                {
                    output = leftOrRight;
                }
                else
                {
                    output = upOrDown;
                }
            }

            if (word.Length == 1)
            {
                Console.WriteLine(word);
            }
            else if (n == 1)
            {
                Console.WriteLine(word[0]);
            }
            else
            {
                Console.WriteLine(output);
            }

        }
    }
}
