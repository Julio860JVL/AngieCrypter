namespace AngieCrypter
{
    internal class DecryptSwap
    {
        internal static void AllCharacters()
        {
            char[] msgToDecrypt = Console.ReadLine().ToLower().ToCharArray();

            for (int i = 0; i < msgToDecrypt.Length; i++)
            {
                // letters (a thru z) swapped back to the uncrypted version,
                // unless the message has been encrypted more than 1 time,
                // then it needs to be decrypted again the same amount of times it was encrypted.
                if (msgToDecrypt[i] == AtoZ.modA)
                {
                    msgToDecrypt[i] = AtoZ.charA;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modB)
                {
                    msgToDecrypt[i] = AtoZ.charB;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modC)
                {
                    msgToDecrypt[i] = AtoZ.charC;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modD)
                {
                    msgToDecrypt[i] = AtoZ.charD;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modE)
                {
                    msgToDecrypt[i] = AtoZ.charE;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modF)
                {
                    msgToDecrypt[i] = AtoZ.charF;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modG)
                {
                    msgToDecrypt[i] = AtoZ.charG;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modH)
                {
                    msgToDecrypt[i] = AtoZ.charH;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modI)
                {
                    msgToDecrypt[i] = AtoZ.charI;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modJ)
                {
                    msgToDecrypt[i] = AtoZ.charJ;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modK)
                {
                    msgToDecrypt[i] = AtoZ.charK;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modL)
                {
                    msgToDecrypt[i] = AtoZ.charL;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modM)
                {
                    msgToDecrypt[i] = AtoZ.charM;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modN)
                {
                    msgToDecrypt[i] = AtoZ.charN;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modO)
                {
                    msgToDecrypt[i] = AtoZ.charO;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modP)
                {
                    msgToDecrypt[i] = AtoZ.charP;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modQ)
                {
                    msgToDecrypt[i] = AtoZ.charQ;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modR)
                {
                    msgToDecrypt[i] = AtoZ.charR;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modS)
                {
                    msgToDecrypt[i] = AtoZ.charS;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modT)
                {
                    msgToDecrypt[i] = AtoZ.charT;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modU)
                {
                    msgToDecrypt[i] = AtoZ.charU;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modV)
                {
                    msgToDecrypt[i] = AtoZ.charV;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modW)
                {
                    msgToDecrypt[i] = AtoZ.charW;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modX)
                {
                    msgToDecrypt[i] = AtoZ.charX;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modY)
                {
                    msgToDecrypt[i] = AtoZ.charY;
                    continue;
                }

                if (msgToDecrypt[i] == AtoZ.modZ)
                {
                    msgToDecrypt[i] = AtoZ.charZ;
                    continue;
                }

                // special characters (AKA symbols).
                if (msgToDecrypt[i] == Symbols.modSpace)
                {
                    msgToDecrypt[i] = Symbols.charSpace;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modTilde)
                {
                    msgToDecrypt[i] = Symbols.charTilde;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modExclamation)
                {
                    msgToDecrypt[i] = Symbols.charExclamation;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modAt)
                {
                    msgToDecrypt[i] = Symbols.charAt;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modPound)
                {
                    msgToDecrypt[i] = Symbols.charPound;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modDollar)
                {
                    msgToDecrypt[i] = Symbols.charDollar;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modPercent)
                {
                    msgToDecrypt[i] = Symbols.charPercent;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modCaret)
                {
                    msgToDecrypt[i] = Symbols.charCaret;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modAmpersand)
                {
                    msgToDecrypt[i] = Symbols.charAmpersand;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modAsterisk)
                {
                    msgToDecrypt[i] = Symbols.charAsterisk;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modOpenParenthesis)
                {
                    msgToDecrypt[i] = Symbols.charOpenParenthesis;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modCloseParenthesis)
                {
                    msgToDecrypt[i] = Symbols.charCloseParenthesis;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modUnderscore)
                {
                    msgToDecrypt[i] = Symbols.charUnderscore;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modPlus)
                {
                    msgToDecrypt[i] = Symbols.charPlus;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modOpenCurly)
                {
                    msgToDecrypt[i] = Symbols.charOpenCurly;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modCloseCurly)
                {
                    msgToDecrypt[i] = Symbols.charCloseCurly;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modVerticalBar)
                {
                    msgToDecrypt[i] = Symbols.charVerticalBar;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modColon)
                {
                    msgToDecrypt[i] = Symbols.charColon;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modQuotation)
                {
                    msgToDecrypt[i] = Symbols.charQuotation;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modLessThan)
                {
                    msgToDecrypt[i] = Symbols.charLessThan;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modGreaterThan)
                {
                    msgToDecrypt[i] = Symbols.charGreaterThan;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modQuestion)
                {
                    msgToDecrypt[i] = Symbols.charQuestion;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modBacktick)
                {
                    msgToDecrypt[i] = Symbols.charBacktick;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modNum1)
                {
                    msgToDecrypt[i] = Symbols.charNum1;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modNum2)
                {
                    msgToDecrypt[i] = Symbols.charNum2;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modNum3)
                {
                    msgToDecrypt[i] = Symbols.charNum3;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modNum4)
                {
                    msgToDecrypt[i] = Symbols.charNum4;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modNum5)
                {
                    msgToDecrypt[i] = Symbols.charNum5;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modNum6)
                {
                    msgToDecrypt[i] = Symbols.charNum6;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modNum7)
                {
                    msgToDecrypt[i] = Symbols.charNum7;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modNum8)
                {
                    msgToDecrypt[i] = Symbols.charNum8;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modNum9)
                {
                    msgToDecrypt[i] = Symbols.charNum9;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modNum0)
                {
                    msgToDecrypt[i] = Symbols.charNum0;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modHyphen)
                {
                    msgToDecrypt[i] = Symbols.charHyphen;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modEquals)
                {
                    msgToDecrypt[i] = Symbols.charEquals;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modOpenSquare)
                {
                    msgToDecrypt[i] = Symbols.charOpenSquare;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modCloseSquare)
                {
                    msgToDecrypt[i] = Symbols.charCloseSquare;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modBackslash)
                {
                    msgToDecrypt[i] = Symbols.charBackslash;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modSemicolon)
                {
                    msgToDecrypt[i] = Symbols.charSemicolon;
                    continue;
                }

                if (msgToDecrypt[i] == Symbols.modApostrophe)
                {
                    msgToDecrypt[i] = Symbols.charApostrophe;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modComma)
                {
                    msgToDecrypt[i] = Symbols.charComma;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modPeriod)
                {
                    msgToDecrypt[i] = Symbols.charPeriod;
                    continue;
                }
                
                if (msgToDecrypt[i] == Symbols.modSlash)
                {
                    msgToDecrypt[i] = Symbols.charSlash;
                    continue;
                }
            }

            Console.WriteLine();
            Console.Write(@"\|/\|/\|/\|/-- ");
            ChangeColor.Green("ENCRYPTED MESSAGE");
            Console.WriteLine(@" --\|/\|/\|/\|/");
            Console.WriteLine();

            foreach (char c in msgToDecrypt)
            {
                Console.Write(c);
            }

            Console.WriteLine("\n");
            Console.Write(@"\|/\|/\|/\|/-- ");
            ChangeColor.Green("ENCRYPTED MESSAGE");
            Console.WriteLine(@" --\|/\|/\|/\|/");
            Console.WriteLine();
        }
    }
}
