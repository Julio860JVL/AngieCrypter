namespace AngieCrypter
{
    internal class EncryptSwap
    {
        internal static void Characters()
        {
            char[] msgToEncrypt = Console.ReadLine().ToLower().ToCharArray();

            for (int i = 0; i < msgToEncrypt.Length; i++)
            {
                // letters (a thru z) swapped.
                if (msgToEncrypt[i] == AtoZ.charA)
                {
                    msgToEncrypt[i] = AtoZ.modA;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charB)
                {
                    msgToEncrypt[i] = AtoZ.modB;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charC)
                {
                    msgToEncrypt[i] = AtoZ.modC;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charD)
                {
                    msgToEncrypt[i] = AtoZ.modD;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charE)
                {
                    msgToEncrypt[i] = AtoZ.modE;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charF)
                {
                    msgToEncrypt[i] = AtoZ.modF;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charG)
                {
                    msgToEncrypt[i] = AtoZ.modG;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charH)
                {
                    msgToEncrypt[i] = AtoZ.modH;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charI)
                {
                    msgToEncrypt[i] = AtoZ.modI;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charJ)
                {
                    msgToEncrypt[i] = AtoZ.modJ;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charK)
                {
                    msgToEncrypt[i] = AtoZ.modK;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charL)
                {
                    msgToEncrypt[i] = AtoZ.modL;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charM)
                {
                    msgToEncrypt[i] = AtoZ.modM;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charN)
                {
                    msgToEncrypt[i] = AtoZ.modN;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charO)
                {
                    msgToEncrypt[i] = AtoZ.modO;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charP)
                {
                    msgToEncrypt[i] = AtoZ.modP;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charQ)
                {
                    msgToEncrypt[i] = AtoZ.modQ;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charR)
                {
                    msgToEncrypt[i] = AtoZ.modR;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charS)
                {
                    msgToEncrypt[i] = AtoZ.modS;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charT)
                {
                    msgToEncrypt[i] = AtoZ.modT;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charU)
                {
                    msgToEncrypt[i] = AtoZ.modU;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charV)
                {
                    msgToEncrypt[i] = AtoZ.modV;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charW)
                {
                    msgToEncrypt[i] = AtoZ.modW;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charX)
                {
                    msgToEncrypt[i] = AtoZ.modX;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charY)
                {
                    msgToEncrypt[i] = AtoZ.modY;
                    continue;
                }

                if (msgToEncrypt[i] == AtoZ.charZ)
                {
                    msgToEncrypt[i] = AtoZ.modZ;
                    continue;
                }

                // special characters (AKA symbols).
                if (msgToEncrypt[i] == Symbols.charSpace)
                {
                    msgToEncrypt[i] = Symbols.modSpace;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charTilde)
                {
                    msgToEncrypt[i] = Symbols.modTilde;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charExclamation)
                {
                    msgToEncrypt[i] = Symbols.modExclamation;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charAt)
                {
                    msgToEncrypt[i] = Symbols.modAt;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charPound)
                {
                    msgToEncrypt[i] = Symbols.modPound;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charDollar)
                {
                    msgToEncrypt[i] = Symbols.modDollar;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charPercent)
                {
                    msgToEncrypt[i] = Symbols.modPercent;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charCaret)
                {
                    msgToEncrypt[i] = Symbols.modCaret;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charAmpersand)
                {
                    msgToEncrypt[i] = Symbols.modAmpersand;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charAsterisk)
                {
                    msgToEncrypt[i] = Symbols.modAsterisk;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charOpenParenthesis)
                {
                    msgToEncrypt[i] = Symbols.modOpenParenthesis;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charCloseParenthesis)
                {
                    msgToEncrypt[i] = Symbols.modCloseParenthesis;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charUnderscore)
                {
                    msgToEncrypt[i] = Symbols.modUnderscore;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charPlus)
                {
                    msgToEncrypt[i] = Symbols.modPlus;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charOpenCurly)
                {
                    msgToEncrypt[i] = Symbols.modOpenCurly;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charCloseCurly)
                {
                    msgToEncrypt[i] = Symbols.modCloseCurly;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charVerticalBar)
                {
                    msgToEncrypt[i] = Symbols.modVerticalBar;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charColon)
                {
                    msgToEncrypt[i] = Symbols.modColon;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charQuotation)
                {
                    msgToEncrypt[i] = Symbols.modQuotation;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charLessThan)
                {
                    msgToEncrypt[i] = Symbols.modLessThan;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charGreaterThan)
                {
                    msgToEncrypt[i] = Symbols.modGreaterThan;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charQuestion)
                {
                    msgToEncrypt[i] = Symbols.modQuestion;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charBacktick)
                {
                    msgToEncrypt[i] = Symbols.modBacktick;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charNum1)
                {
                    msgToEncrypt[i] = Symbols.modNum1;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charNum2)
                {
                    msgToEncrypt[i] = Symbols.modNum2;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charNum3)
                {
                    msgToEncrypt[i] = Symbols.modNum3;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charNum4)
                {
                    msgToEncrypt[i] = Symbols.modNum4;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charNum5)
                {
                    msgToEncrypt[i] = Symbols.modNum5;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charNum6)
                {
                    msgToEncrypt[i] = Symbols.modNum6;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charNum7)
                {
                    msgToEncrypt[i] = Symbols.modNum7;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charNum8)
                {
                    msgToEncrypt[i] = Symbols.modNum8;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charNum9)
                {
                    msgToEncrypt[i] = Symbols.modNum9;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charNum0)
                {
                    msgToEncrypt[i] = Symbols.modNum0;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charHyphen)
                {
                    msgToEncrypt[i] = Symbols.modHyphen;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charEquals)
                {
                    msgToEncrypt[i] = Symbols.modEquals;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charOpenSquare)
                {
                    msgToEncrypt[i] = Symbols.modOpenSquare;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charCloseSquare)
                {
                    msgToEncrypt[i] = Symbols.modCloseSquare;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charBackslash)
                {
                    msgToEncrypt[i] = Symbols.modBackslash;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charSemicolon)
                {
                    msgToEncrypt[i] = Symbols.modSemicolon;
                    continue;
                }

                if (msgToEncrypt[i] == Symbols.charApostrophe)
                {
                    msgToEncrypt[i] = Symbols.modApostrophe;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charComma)
                {
                    msgToEncrypt[i] = Symbols.modComma;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charPeriod)
                {
                    msgToEncrypt[i] = Symbols.modPeriod;
                    continue;
                }
                
                if (msgToEncrypt[i] == Symbols.charSlash)
                {
                    msgToEncrypt[i] = Symbols.modSlash;
                    continue;
                }
            }
            
            Console.WriteLine();
            Console.Write(@"\|/\|/\|/\|/-- ");
            ChangeColor.Red("ENCRYPTED MESSAGE");
            Console.WriteLine(@" --\|/\|/\|/\|/");
            Console.WriteLine();

            foreach (char c in msgToEncrypt)
            {
                Console.Write(c);
            }

            Console.WriteLine("\n");
            Console.Write(@"\|/\|/\|/\|/-- ");
            ChangeColor.Red("ENCRYPTED MESSAGE");
            Console.WriteLine(@" --\|/\|/\|/\|/");
            Console.WriteLine();
        }
    }
}