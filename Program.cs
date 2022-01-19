// See https://aka.ms/new-console-template for more information

// TicTacToe
// Author: Dylan Scott


namespace TicTacToe 
{
    class Program
    {
        static void Main()
        {   List<string> numbers = MakeList();
            bool result = false;
            
            PrintGameBoard(numbers);
            
            while (result == false)
            {
                PlayerChoice(numbers);
                
                
                  
                if (numbers[1] == numbers[2] && numbers[2] == numbers[3] ||
                numbers[4] == numbers[5] && numbers[5] == numbers[6] ||
                numbers[7] == numbers[8] && numbers[8] == numbers[9] ||
                numbers[1] == numbers[4] && numbers[4] == numbers[7] ||
                numbers[2] == numbers[5] && numbers[5] == numbers[8] ||
                numbers[3] == numbers[6] && numbers[6] == numbers[9] ||
                numbers[1] == numbers[5] && numbers[5] == numbers[9] ||
                numbers[3] == numbers[5] && numbers[5] == numbers[7])
                {
            
                
                    result = true;
                    Console.WriteLine("Good Game!");
                    PrintGameBoard(numbers);
            
                }
                else {
                    PlayerChoice2(numbers);
                }

                if (!numbers.Contains("1") && !numbers.Contains("2") && !numbers.Contains("3")
                && !numbers.Contains("4") && !numbers.Contains("5") && !numbers.Contains("6") &&
                !numbers.Contains("7") && !numbers.Contains("8") && !numbers.Contains("9"))
                {
                    result = true;
                    Console.WriteLine("Tie Game");
                }
            
            
                
            
    
            
            }

        
        }
        static List<string> MakeList()
        {
            List<string> numbers = new List<string>();
            numbers.Add("0");
            numbers.Add("1");
            numbers.Add("2");
            numbers.Add("3");
            numbers.Add("4");
            numbers.Add("5");
            numbers.Add("6");
            numbers.Add("7");
            numbers.Add("8");
            numbers.Add("9");

            return numbers;
        }

        static void PrintGameBoard(List<string> numbers)
        {
            Console.WriteLine($"{numbers[1]}|{numbers[2]}|{numbers[3]}"); 
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{numbers[4]}|{numbers[5]}|{numbers[6]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{numbers[7]}|{numbers[8]}|{numbers[9]}");
            
        }
    

        static void PlayerChoice(List<string> numbers)
        {
            Console.WriteLine("Player 1's turn");
            int choiceP1 = int.Parse(Console.ReadLine());
            if (numbers[choiceP1] != "o")
            {
                numbers[choiceP1] = "x";
             
            }
            else {
                Console.WriteLine("Choose a different spot");
                
            }
        }

        static void PlayerChoice2(List<string> numbers)
        {    
            PrintGameBoard(numbers);
            Console.WriteLine("Player 2's turn");
            int choiceP2 = int.Parse(Console.ReadLine());
            if (numbers[choiceP2] != "x")
            {
                numbers[choiceP2] = "o";
               
            }
            else {
                Console.WriteLine("Choose a different spot");
                
            }
            PrintGameBoard(numbers);
            
           
            
        }
        
        
            

           
        

    }

}