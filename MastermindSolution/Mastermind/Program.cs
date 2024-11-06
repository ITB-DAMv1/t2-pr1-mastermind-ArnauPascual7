using System;
namespace Mastermid
{
    public class Program
    {
        // Missatges d'Error
        public const string ErrDifficulty = "ERROR! DIFICULTAT INVALIDA!";
        public const string ErrOutOfRange = "ERROR! NOMBRE FORA DE RANG!";
        public const string ErrFormatException = "ERROR! NO ÉS UN NOMBRE ENTER!";
        public const string ErrOverflowException = "ERROR! EL NOMBRE ÉS MASSA GRAN!";
        public const string ErrException = "ERROR INESPERAT!";

        // Fletxa per a indicar quan l'usuari ha d'introduïr un valor per teclat
        public const string InputArrow = "-> ";

        public static void Main(string[] args)
        {
            // Codi Secret, Llargaria del Codi i Número mínim i màxim
            const string SecretCode = "3513";
            const int SecretCodeLenght = 4;
            const int MinNumOfSecretCode = 1;
            const int MaxNumOfSecretCode = 6;

            // Simbols, Posició Correcte = O, Posició Incorrecte = Ø, No és en el codi = ×
            const char SymbCorrectPosition = 'O';
            const char SymbIncorrectPosition = 'Ø';
            const char SymbNot = '×';

            // Menú Principal, primer missatge del programa
            const string MsgMenu =
                "\n::::    ::::      :::      ::::::::  ::::::::::: :::::::::: :::::::::  ::::    ::::  ::::::::::: ::::    ::: :::::::::" +
                "\n+:+:+: :+:+:+   :+: :+:   :+:    :+:     :+:     :+:        :+:    :+: +:+:+: :+:+:+     :+:     :+:+:   :+: :+:    :+:" +
                "\n+:+ +:+:+ +:+  +:+   +:+  +:+            +:+     +:+        +:+    +:+ +:+ +:+:+ +:+     +:+     :+:+:+  +:+ +:+    +:+" +
                "\n+#+  +:+  +#+ +#++:++#++: +#++:++#++     +#+     +#++:++#   +#++:++#:  +#+  +:+  +#+     +#+     +#+ +:+ +#+ +#+    +:+" +
                "\n+#+       +#+ +#+     +#+        +#+     +#+     +#+        +#+    +#+ +#+       +#+     +#+     +#+  +#+#+# +#+    +#+" +
                "\n#+#       #+# #+#     #+# #+#    #+#     #+#     #+#        #+#    #+# #+#       #+#     #+#     #+#   #+#+# #+#    #+#" +
                "\n###       ### ###     ###  ########      ###     ########## ###    ### ###       ### ########### ###    #### #########" +
                "\nPer: Arnau Pascual" +
                "\n\nBenvigut a MASTERMIND!" +
                "\nL'objectiu d'aquest joc és endevinar una combinació de 4 dígits." +
                "\nLa combinació son nombres del 1 al 6." +
                "\n\nEscull la dificultat:" +
                "\n1. Dificultat novell: 10 intents" +
                "\n2. Dificultat aficionat: 6 intents" +
                "\n3. Dificultat expert: 4 intents" +
                "\n4. Dificultat Màster: 3 intents" +
                "\n5. Dificultat personalitzada";

            // Separació i espai, per separar seccions i missatges
            const string Section = "__________________________________________________\n";
            const string Space = " ";

            // Intents de cada Dificultat
            const int DiffNovell = 10;
            const int DiffAficionat = 6;
            const int DiffExpert = 4;
            const int DiffMaster = 3;

            // Opcions de Dificultat, primera opció a última de la selecció de dificultats
            const int MinDiffOptions = 1;
            const int MaxDiffOptions = 5;

            // Màxim i mínim d'intents de la Dificultat personalitzada
            const int MinAttempts = 1;
            const int MaxAttempts = 20;

            // Missatges de resposta dirigits a l'usuari
            const string MsgSecretQuestion = "Quin és el codi secret?";
            const string MsgAttempt = "Intent número";
            const string MsgYourCode = "El teu codi:";
            const string MsgClue = "Casi! Pista:";
            const string MsgCustomDifficulty = "Introdueix el nombre d'intents que vols tenir:";
            const string MsgInserNum = "Introdueix el nombre de la posició";
            const string MsgWin = "HAS GUANYAT, HAS ENDEVINAT LA COMBINACIÓ CORRECTA";
            const string MsgLose = "HAS PERDUT, HAS ESGOTAT TOTS ELS INTENTS ¯\\_(ツ)_/¯";
            const string MsgCorrectConvination = "La combinació correcta era";
            const string MsgEnd = "Prem enter per finalitzar";

            /* Varibles de tipus int
             * Dificultat del joc, Intents totals, Intent actual, Total de números encertats de la combinació
             */
            int difficulty = 0;
            int totalAttempts = 0;
            int attempt = 0;
            int correctNums = 0;

            // Array per el codi que introdueix l'usuari
            int[] arrUserSecretCode = new int[SecretCodeLenght];

            /* Variables de tipus string
             * Codi que introdueix l'usuari
             * Conjunt de simbols (Posició Correcte, Posició Incorrecte, No està)
             * S'utilitzen per a mostra per pantalla tots els valors junts
             */
            string strUserSecretCode = "";
            string strClue = "";

            // Booleà per si l'usuari encerta els 4 valors del Codi
            bool winner = false;

            Console.WriteLine(MsgMenu);

            // Demana la dificultat del joc a traves de ReadLineToIntRange(min,max) amb un valor mínim i màxim
            difficulty = ReadLineToIntRange(MinDiffOptions,MaxDiffOptions);

            /* Switch que assigna els intents totals a través de la resposta de l'usuari,
             * si la dificultat és personalitzada torna a utilitzar ReadLineToIntRange(min,max) per al nombre d'intents
             */
            switch (difficulty)
            {
                case 1:
                    totalAttempts = DiffNovell;
                    break;
                case 2:
                    totalAttempts = DiffAficionat;
                    break;
                case 3:
                    totalAttempts = DiffExpert;
                    break;
                case 4:
                    totalAttempts = DiffMaster;
                    break;
                case 5:
                    Console.WriteLine(Section);
                    Console.WriteLine(MsgCustomDifficulty);
                    totalAttempts = ReadLineToIntRange(MinAttempts,MaxAttempts);
                    break;
                default:
                    Console.WriteLine(ErrDifficulty);
                    break;
            }

            /* Do While que demana els 4 nombres de la combinació amb ReadLineToIntRange(min,max),
             * mentre l'intent actual (attempt) sigui menor al total d'intents (totalAttempts) i winner sigui fals,
             * els nombres es guarden en arrUserSecretCode[i]
             * Compara els 4 nombres de la combinació de l'usuari amb el Codi Secret
             * Si un nombre està en la seva posició afegeix el valor de SymbCorrectPosition (O) a Clue (Pista)
             * Si un nombre està en el Codi, però no en la posició afegeix el valor de SymbIncorrectPosition (Ø) a Clue (Pista)
             * Si un nombre no hi és en la combinació afegeix el valor de SymbNot (×) a Clue (Pista)
             * 
             * Per cada nombre que encerta en la seva posició afegeix 1 a correctNums,
             * si correctNums és igual a la llargaria del Codi Secret, winner és igual a true i surt del bucle,
             * si no mostra Clue per pantalla, reinicialitza correctNums a 0 i aumenta en 1 attempt
             */
            do
            {
                Console.WriteLine(Section);
                Console.WriteLine($"{MsgAttempt} {attempt}. {MsgSecretQuestion}");

                for (int i = 0; i < SecretCodeLenght; i++)
                {
                    Console.WriteLine($"\n{MsgInserNum} {i + 1}");
                    arrUserSecretCode[i] = ReadLineToIntRange(MinNumOfSecretCode,MaxNumOfSecretCode);
                    strUserSecretCode = String.Concat(strUserSecretCode, IntToString(arrUserSecretCode[i]), Space);
                }
                for (int i = 0; i < SecretCodeLenght; i++)
                {
                    if (SecretCode.Contains(IntToChar(arrUserSecretCode[i])))
                    {
                        if (SecretCode[i] == IntToChar(arrUserSecretCode[i]))
                        {
                            strClue = String.Concat(strClue, SymbCorrectPosition, Space);
                            correctNums++;
                        } else
                        {
                            strClue = String.Concat(strClue, SymbIncorrectPosition, Space);
                        }
                    } else
                    {
                        strClue = String.Concat(strClue, SymbNot, Space);
                    }
                }

                Console.WriteLine($"\n{MsgYourCode} {strUserSecretCode}");

                if (correctNums == SecretCodeLenght)
                {
                    winner = true;
                } else
                {
                    Console.WriteLine($"{MsgClue} {strClue}");
                    correctNums = 0;
                    attempt++;
                }

                strClue = "";
                strUserSecretCode = "";

            } while (attempt < totalAttempts && !winner);

            Console.WriteLine(Section);

            // Si winner és true mostra el missatge de victòria, si no el de derrota
            if (winner)
            {
                Console.WriteLine(MsgWin);
            } else
            {
                Console.WriteLine(MsgLose);
            }

            Console.WriteLine($"{MsgCorrectConvination} {SecretCode}");
            Console.Write(MsgEnd);
            Console.ReadLine();
        }
        /* Funció per a llegir un nombre per teclat a través d'un rang de nombres
         * Utilitza ReadLineToInt(ref num, ref error) per a llegir el nombre i transformar-lo a int
         * Amb el valor int si és dins del rang acaba la funció,
         * si és fora del rang salta un error i torna a demanar el nombre.
         */
        public static int ReadLineToIntRange(int min, int max)
        {
            int num = 0;
            bool error = false;

            do
            {
                ReadLineToInt(ref num, ref error);
                if ((num < min || num > max) && !error) Console.WriteLine(ErrOutOfRange);
                error = false;
            } while (num < min || num > max);
            return num;
        }
        /* Funció per a llegir un nombre per teclat i intentar-lo pasar de string a int
         * Utilitza un try per a comprovar errors i un Parse per a transformar el valor
         * No retorna cap valor, però modifica el valor de num, una variable referenciada
         * També, si el resultat és algún error modifica error, variable referenciada, a true
         */
        public static void ReadLineToInt(ref int num, ref bool error)
        {
            Console.Write(InputArrow);
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine(ErrFormatException);
                error = true;
            }
            catch (OverflowException)
            {
                Console.WriteLine(ErrOverflowException);
                error = true;
            }
            catch (Exception)
            {
                Console.WriteLine(ErrException);
                error = true;
            }
        }
        public static char IntToChar(int num)
        {
            return StringToChar(IntToString(num));
        }
        public static string IntToString(int num)
        {
            return Convert.ToString(num);
        }
        public static char StringToChar(string str)
        {
            return Convert.ToChar(str);
        }
    }
}